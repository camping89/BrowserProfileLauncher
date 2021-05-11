using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Common.Constants;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using BrowserProfileLauncher.Services.ProfileGroups;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class MainForm : Form
    {
        private readonly IBrowserProfileService _browserProfileService;
        private readonly IAccountService _accountService;
        private readonly IProfileGroupService _profileGroupService;
        private readonly IServiceProvider _serviceProvider;
        private readonly PaginationModel _profilesPagination;
        private readonly PaginationModel _usersPagination;
        private readonly PaginationModel _profileGroupsPagination;
        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            browserProfileDataGridView.DataSource = browserProfileBindingSource;
            profileGroupDataGridView.DataSource = profileGroupBindingSource;
            userDataGridView.DataSource = userBindingSource;
            _browserProfileService = serviceProvider.GetRequiredService<IBrowserProfileService>();
            _accountService = serviceProvider.GetRequiredService<IAccountService>();
            _profileGroupService = serviceProvider.GetRequiredService<IProfileGroupService>();
            _serviceProvider = serviceProvider;
            _profilesPagination = new PaginationModel { PageSize = PageSize };
            _usersPagination = new PaginationModel { PageSize = PageSize };
            _profileGroupsPagination = new PaginationModel { PageSize = PageSize };
        }

        private static int PageSize => 10;

        #region general private class methods

        private void MainForm_Load(object sender, EventArgs e)
        {
                SetupComponentVisibilities();
                LoadBrowserProfiles();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0:
                    LoadBrowserProfiles();
                    break;
                case 1:
                    LoadUsers();
                    break;
                case 2:
                    LoadProfileGroups();
                    break;
                default:
                    break;
            }
        }

        private void SetupComponentVisibilities()
        {
            if (!Global.CurrentUser.RoleNames.Contains(RoleNameConstants.AdminRole))
            {
                mainTabControl.TabPages.Remove(userTabPage);
                mainTabControl.TabPages.Remove(profileGroupTabPage);
                btnCreateProfile.Visible = false;
                browserProfileDataGridView.Columns["EditProfile"].Visible = false;
                browserProfileDataGridView.Columns["DeleteProfile"].Visible = false;
            }
        }

        private bool IsDeleteConfirmed()
        {
            return MessageBox.Show("Do you really want to delete the selected row", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void Logout(object? sender, EventArgs eventArgs)
        {
            Global.CurrentUser = null;
            var loginForm = new LoginForm(_serviceProvider);
            Hide();
            loginForm.Show();
            Dispose();
        }

        private void UpdatePaginationDetails<T>(PaginationModel pagination, IPagedList<T> pagedList)
        {
            pagination.TotalPages = pagedList.TotalPages;
            pagination.HasNextPage = pagedList.HasNextPage;
            pagination.HasPreviousPage = pagedList.HasPreviousPage;
            pagination.IndexFrom = pagedList.IndexFrom;
            pagination.TotalCount = pagedList.TotalCount;
            pagination.PageIndex = pagedList.PageIndex;
            pagination.PageSize = pagedList.PageSize;
        }

        #endregion

        #region Browser Profiles methods
        private void BtnSearchProfile_Click(object sender, EventArgs e)
        {
            LoadBrowserProfiles();
        }

        private void LoadBrowserProfiles()
        {
            var search = txtSearchProfileName.Text;
            var pagedList = _browserProfileService.GetPagedList(Global.CurrentUser, pageSize: _profilesPagination.PageSize, pageIndex: _profilesPagination.PageIndex, search: search);
            browserProfileDataGridView.AutoGenerateColumns = false;
            browserProfileBindingSource.DataSource = pagedList.Items;
            browserProfileDataGridView.Columns[0].Visible = false;

            UpdatePaginationDetails(_profilesPagination, pagedList);
            UpdateProfilePaginationVisibilities();
        }

        private void UpdateProfilePaginationVisibilities()
        {
            txtCurrentProfilePage.Value = _profilesPagination.PageIndex + 1;
            txtCurrentProfilePage.Maximum = _profilesPagination.TotalPages > 0 ? _profilesPagination.TotalPages : 1;
            btnPreviousProfilePage.Enabled = _profilesPagination.HasPreviousPage;
            btnFirstProfilePage.Enabled = _profilesPagination.HasPreviousPage;
            btnNextProfilePage.Enabled = _profilesPagination.HasNextPage;
            btnLastProfilePage.Enabled = _profilesPagination.HasNextPage;
            lblProfileTotalPages.Text = _profilesPagination.TotalPages.ToString();
        }

        private async void BrowserProfileDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (IsDeleteConfirmed())
            {
                var profile = (BrowserProfileModel)e.Row.DataBoundItem;
                await DeleteBrowserProfile(profile);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async Task DeleteBrowserProfile(BrowserProfileModel profile)
        {
            await _browserProfileService.Delete(Global.CurrentUser.Id, profile.Id);
        }

        private void PingProfileProxy(BrowserProfileModel profile)
        {
            var pingSuccess = _browserProfileService.Ping(profile);
            if (pingSuccess)
            {
                MessageBox.Show("Ping proxy successfully", "Ping result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ping proxy failed", "Ping result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaunchBrowserProfile(BrowserProfileModel profile)
        {
            var customAgentForm = new CustomUserAgentForm();
            var dialogResult = customAgentForm.ShowDialog(this);
            if (dialogResult != DialogResult.Cancel)
            {
                string customAgent = dialogResult == DialogResult.OK ? customAgentForm.cbUserAgent.Text : null;
                _browserProfileService.Launch(profile, customAgent);
            }
        }

        private async Task EditBrowserProfile(DataGridViewRow selectedRow)
        {
            var profile = (BrowserProfileModel)selectedRow.DataBoundItem;
            var editForm = new BrowserProfileDetailsForm(_profileGroupService, profile);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                profile.ProfileName = editForm.txtProfileName.Text;
                profile.ProxyIp = editForm.txtProxyIp.Text;
                profile.ProxyPort = int.Parse(editForm.txtProxyPort.Text);
                profile.ProxyUsername = editForm.txtProxyUsername.Text;
                profile.ProxyPassword = editForm.txtPassword.Text;
                profile.ProxyProtocol = editForm.txtProxyProtocol.Text;
                var selectGroup = (ProfileGroupModel)editForm.cbProfileGroup.SelectedItem;
                profile.GroupId = selectGroup?.Id;

                await _browserProfileService.Update(Global.CurrentUser.Id, profile);

                selectedRow.Cells["ProfileName"].Value = profile.ProfileName;
                selectedRow.Cells["ProxyIp"].Value = profile.ProxyIp;
                selectedRow.Cells["ProxyPort"].Value = profile.ProxyPort;
                selectedRow.Cells["ProxyUsername"].Value = profile.ProxyUsername;
                selectedRow.Cells["ProxyPassword"].Value = profile.ProxyPassword;
                selectedRow.Cells["ProxyProtocol"].Value = profile.ProxyProtocol;
                selectedRow.Cells["GroupName"].Value = selectGroup?.GroupName;

            }
            editForm.Dispose();
        }

        private async void BrowserProfileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var senderGrid = (DataGridView)sender;
                var selectedRow = browserProfileDataGridView.Rows[e.RowIndex];
                var profile = (BrowserProfileModel)selectedRow.DataBoundItem;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn column && e.RowIndex >= 0)
                {
                    switch (column.Name)
                    {
                        case "DeleteProfile":
                            if (IsDeleteConfirmed())
                            {
                                await DeleteBrowserProfile(profile);
                                browserProfileDataGridView.Rows.RemoveAt(e.RowIndex);
                            }
                            break;
                        case "EditProfile":
                            await EditBrowserProfile(selectedRow);
                            break;

                        case "PingProxy":
                            PingProfileProxy(profile);
                            break;
                        case "LaunchBrowser":
                            LaunchBrowserProfile(profile);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private async void BtnCreateProfile_Click(object sender, EventArgs e)
        {
            var newProfileForm = new BrowserProfileDetailsForm(_profileGroupService);
            if (newProfileForm.ShowDialog(this) == DialogResult.OK)
            {
                var selectGroup = (ProfileGroupModel)newProfileForm.cbProfileGroup.SelectedItem;
                var profile = new BrowserProfileModel
                {
                    ProfileName = newProfileForm.txtProfileName.Text,
                    ProxyIp = newProfileForm.txtProxyIp.Text,
                    ProxyPort = int.Parse(newProfileForm.txtProxyPort.Text),
                    ProxyUsername = newProfileForm.txtProxyUsername.Text,
                    ProxyPassword = newProfileForm.txtPassword.Text,
                    ProxyProtocol = newProfileForm.txtProxyProtocol.Text,
                    GroupId = selectGroup?.Id,
                    UserId = Global.CurrentUser.Id
                };
                await _browserProfileService.Create(profile);
                LoadBrowserProfiles();
            };
            newProfileForm.Dispose();
        }

        private void BtnFirstProfilePage_Click(object sender, EventArgs e)
        {
            _profilesPagination.PageIndex = 0;
            LoadBrowserProfiles();
        }

        private void BtnPreviousProfilePage_Click(object sender, EventArgs e)
        {
            _profilesPagination.PageIndex--;
            LoadBrowserProfiles();
        }

        private void BtnNextProfilePage_Click(object sender, EventArgs e)
        {
            _profilesPagination.PageIndex++;
            LoadBrowserProfiles();
        }

        private void BtnLastProfilePage_Click(object sender, EventArgs e)
        {
            _profilesPagination.PageIndex = _profilesPagination.TotalPages - 1;
            LoadBrowserProfiles();
        }

        private void TxtCurrentProfilePage_ValueChanged(object sender, EventArgs e)
        {
            _profilesPagination.PageIndex = (int)txtCurrentProfilePage.Value - 1;
            LoadBrowserProfiles();
        }

        #endregion

        #region Profile Groups

        private void LoadProfileGroups()
        {
            var pagedList = _profileGroupService.GetPagedList(pageIndex: _profileGroupsPagination.PageIndex, pageSize: _profileGroupsPagination.PageSize);
            profileGroupDataGridView.AutoGenerateColumns = false;
            profileGroupBindingSource.DataSource = pagedList.Items;
            profileGroupDataGridView.Columns[0].Visible = false;

            UpdatePaginationDetails(_profileGroupsPagination, pagedList);
            UpdateProfileGroupPaginationVisibilities();
        }

        private void UpdateProfileGroupPaginationVisibilities()
        {
            txtCurrentProfileGroupPage.Maximum = _profileGroupsPagination.TotalPages;
            txtCurrentProfileGroupPage.Value = _profileGroupsPagination.PageIndex + 1;
            btnPreviousProfileGroupPage.Enabled = _profileGroupsPagination.HasPreviousPage;
            btnFirstProfileGroupPage.Enabled = _profileGroupsPagination.HasPreviousPage;
            btnNextProfileGroupPage.Enabled = _profileGroupsPagination.HasNextPage;
            btnLastProfileGroupPage.Enabled = _profileGroupsPagination.HasNextPage;
            lblTotalProfileGroupPages.Text = _profileGroupsPagination.TotalPages.ToString();
        }

        private async Task DeleteBrowserProfileGroup(ProfileGroupModel profile)
        {
            await _profileGroupService.Delete(profile.Id);
        }

        private async Task EditBrowserProfileGroup(DataGridViewRow selectedRow)
        {
            var group = (ProfileGroupModel)selectedRow.DataBoundItem;
            var editForm = new ProfileGroupDetailsForm(group);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                group.GroupName = editForm.txtGroupName.Text;

                await _profileGroupService.Update(group);

                selectedRow.Cells["ProfileGroupName"].Value = group.GroupName;

            }
            editForm.Dispose();
        }

        private async void ProfileGroupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var senderGrid = (DataGridView)sender;
                var selectedRow = profileGroupDataGridView.Rows[e.RowIndex];
                var group = (ProfileGroupModel)selectedRow.DataBoundItem;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn column && e.RowIndex >= 0)
                {
                    switch (column.Name)
                    {
                        case "DeleteProfileGroup":
                            if (IsDeleteConfirmed())
                            {
                                await DeleteBrowserProfileGroup(group);
                                profileGroupDataGridView.Rows.RemoveAt(e.RowIndex);
                            }
                            break;
                        case "EditProfileGroup":
                            await EditBrowserProfileGroup(selectedRow);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private async void BtnCreateProfileGroup_Click(object sender, EventArgs e)
        {
            var newProfileGroupForm = new ProfileGroupDetailsForm();
            if (newProfileGroupForm.ShowDialog(this) == DialogResult.OK)
            {
                var profile = new ProfileGroupModel
                {
                    GroupName = newProfileGroupForm.txtGroupName.Text,
                };
                await _profileGroupService.Create(profile);
                LoadProfileGroups();
            };
            newProfileGroupForm.Dispose();
        }

        private async void ProfileGroupDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (IsDeleteConfirmed())
            {
                var group = (ProfileGroupModel)e.Row.DataBoundItem;
                await DeleteBrowserProfileGroup(group);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnFirstProfileGroupPage_Click(object sender, EventArgs e)
        {
            _profileGroupsPagination.PageIndex = 0;
            LoadProfileGroups();
        }

        private void BtnPreviousProfileGroupPage_Click(object sender, EventArgs e)
        {
            _profileGroupsPagination.PageIndex--;
            LoadProfileGroups();
        }

        private void BtnNextProfileGroupPage_Click(object sender, EventArgs e)
        {
            _profileGroupsPagination.PageIndex++;
            LoadProfileGroups();
        }

        private void BtnLastProfileGroupPage_Click(object sender, EventArgs e)
        {
            _profileGroupsPagination.PageIndex = _profileGroupsPagination.TotalPages - 1;
            LoadProfileGroups();
        }

        private void TxtCurrentProfileGroupPage_ValueChanged(object sender, EventArgs e)
        {
            _profileGroupsPagination.PageIndex = (int)txtCurrentProfileGroupPage.Value - 1;
            LoadProfileGroups();
        }

        #endregion

        #region users

        private void LoadUsers()
        {
            var pagedList = _accountService.GetPagedList(pageIndex: _usersPagination.PageIndex, pageSize: _usersPagination.PageSize);
            userDataGridView.AutoGenerateColumns = false;
            userBindingSource.DataSource = pagedList.Items;
            userDataGridView.Columns[0].Visible = false;

            UpdatePaginationDetails(_usersPagination, pagedList);
            UpdateUserPaginationVisibilities();
        }

        private void UpdateUserPaginationVisibilities()
        {
            txtCurrentUserPage.Maximum = _usersPagination.TotalPages;
            txtCurrentUserPage.Value = _usersPagination.PageIndex + 1;
            btnPreviousUserPage.Enabled = _usersPagination.HasPreviousPage;
            btnFirstUserPage.Enabled = _usersPagination.HasPreviousPage;
            btnNextUserPage.Enabled = _usersPagination.HasNextPage;
            btnLastUserPage.Enabled = _usersPagination.HasNextPage;
            lblTotalUserPages.Text = _usersPagination.TotalPages.ToString();
        }

        private async Task DeleteUserAccount(UserModel user)
        {
            await _accountService.Delete(user.Id);
        }
        private async Task ChangeLoginPassword(UserModel user)
        {
            var editForm = new ChangeUserPasswordForm(_accountService, user.Id);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var newPassword = editForm.txtNewPassword.Text;
                await _accountService.ChangePassword(user.Id, newPassword);
            }
            editForm.Dispose();
        }

        private async Task EditUserAccount(UserModel user)
        {
            var editForm = new UserDetailsForm(_accountService, _profileGroupService, user.Id);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                user.ProfileGroupIds = editForm.lbxProfileGroups.SelectedItems.Cast<ProfileGroupModel>()
                                                                              .Select(pg => pg.Id).ToList();
                await _accountService.Update(user);
            }
            editForm.Dispose();
        }

        private async void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var senderGrid = (DataGridView)sender;
                var selectedRow = userDataGridView.Rows[e.RowIndex];
                var user = (UserModel)selectedRow.DataBoundItem;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn column && e.RowIndex >= 0)
                {
                    switch (column.Name)
                    {
                        case "DeleteUser":
                            if (IsDeleteConfirmed())
                            {
                                await DeleteUserAccount(user);
                                userDataGridView.Rows.RemoveAt(e.RowIndex);
                            }
                            break;
                        case "EditUser":
                            {
                                await EditUserAccount(user);
                                break;
                            }
                        case "ChangeUserPassword":
                            {
                                await ChangeLoginPassword(user);
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }

        private async void UserDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (IsDeleteConfirmed())
            {
                var user = (UserModel)e.Row.DataBoundItem;
                await DeleteUserAccount(user);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async void BtnCreateUser_Click(object sender, EventArgs e)
        {
            var newUserForm = new CreateUserForm(_accountService, _profileGroupService);
            if (newUserForm.ShowDialog(this) == DialogResult.OK)
            {
                var user = new UserModel
                {
                    Id = Guid.NewGuid(),
                    Username = newUserForm.txtUsername.Text,
                    Password = newUserForm.txtPassword.Text,
                    ProfileGroupIds = newUserForm.lbxProfileGroups.SelectedItems.Cast<ProfileGroupModel>()
                                                                              .Select(pg => pg.Id).ToList()
                };
                await _accountService.Create(user);
                LoadUsers();
            };
            newUserForm.Dispose();
        }

        private void BtnFirstUserPage_Click(object sender, EventArgs e)
        {
            _usersPagination.PageIndex = 0;
            LoadUsers();
        }

        private void BtnPreviousUserPage_Click(object sender, EventArgs e)
        {
            _usersPagination.PageIndex--;
            LoadUsers();
        }

        private void BtnNextUserPage_Click(object sender, EventArgs e)
        {
            _usersPagination.PageIndex++;
            LoadUsers();
        }

        private void BtnLastUserPage_Click(object sender, EventArgs e)
        {
            _usersPagination.PageIndex = _usersPagination.TotalPages - 1;
            LoadUsers();
        }

        private void TxtCurrentUserPage_ValueChanged(object sender, EventArgs e)
        {
            _usersPagination.PageIndex = (int)txtCurrentUserPage.Value - 1;
            LoadUsers();
        }
        #endregion

        private void BtnReload_Click(object sender, EventArgs e)
        {
            txtSearchProfileName.Text = string.Empty;
            LoadBrowserProfiles();
        }
    }
}
