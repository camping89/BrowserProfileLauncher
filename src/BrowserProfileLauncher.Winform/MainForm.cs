using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Common.Constants;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using BrowserProfileLauncher.Services.ProfileGroups;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Diagnostics;
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
        private PaginationModel ProfilesPagination;
        private PaginationModel UsersPagination;
        private PaginationModel ProfileGroupsPagination;
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
            ProfilesPagination = new PaginationModel { PageSize = 2 };
            UsersPagination = new PaginationModel();
            ProfileGroupsPagination = new PaginationModel();
        }

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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var workers = Process.GetProcessesByName("chromedriver");
            foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
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
            this.Dispose();
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
            var pagedList = _browserProfileService.GetPagedList(Global.CurrentUser, pageSize: ProfilesPagination.PageSize, pageIndex: ProfilesPagination.PageIndex, search: search);
            browserProfileDataGridView.AutoGenerateColumns = false;
            browserProfileBindingSource.DataSource = pagedList.Items;
            browserProfileDataGridView.Columns[0].Visible = false;

            UpdatePaginationDetails(ProfilesPagination, pagedList);
            UpdateProfilePaginationVisibilities();
        }

        private void UpdateProfilePaginationVisibilities()
        {
            txtCurrentProfilePage.Maximum = ProfilesPagination.TotalPages;
            txtCurrentProfilePage.Value = ProfilesPagination.PageIndex + 1;
            btnPreviousProfilePage.Enabled = ProfilesPagination.HasPreviousPage;
            btnFirstProfilePage.Enabled = ProfilesPagination.HasPreviousPage;
            btnNextProfilePage.Enabled = ProfilesPagination.HasNextPage;
            btnLastProfilePage.Enabled = ProfilesPagination.HasNextPage;
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
                string customAgent = dialogResult == DialogResult.OK ? customAgentForm.txtUserAgent.Text : null;
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
            ProfilesPagination.PageIndex = 0;
            LoadBrowserProfiles();
        }

        private void BtnPreviousProfilePage_Click(object sender, EventArgs e)
        {
            ProfilesPagination.PageIndex--;
            LoadBrowserProfiles();
        }

        private void BtnNextProfilePage_Click(object sender, EventArgs e)
        {
            ProfilesPagination.PageIndex++;
            LoadBrowserProfiles();
        }

        private void BtnLastProfilePage_Click(object sender, EventArgs e)
        {
            ProfilesPagination.PageIndex = ProfilesPagination.TotalPages - 1;
            LoadBrowserProfiles();
        }

        private void TxtCurrentProfilePage_ValueChanged(object sender, EventArgs e)
        {
            ProfilesPagination.PageIndex = (int)txtCurrentProfilePage.Value - 1;
            LoadBrowserProfiles();
        }

        #endregion

        #region Profile Groups

        private void LoadProfileGroups(int pageIndex = 0)
        {
            var pagedList = _profileGroupService.GetPagedList(pageIndex: pageIndex);
            profileGroupDataGridView.AutoGenerateColumns = false;
            profileGroupBindingSource.DataSource = pagedList.Items;
            profileGroupDataGridView.Columns[0].Visible = false;
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


        #endregion

        #region users

        private void LoadUsers(int pageIndex = 0)
        {
            var pagedList = _accountService.GetPagedList(pageIndex: pageIndex);
            userDataGridView.AutoGenerateColumns = false;
            userBindingSource.DataSource = pagedList.Items;
            userDataGridView.Columns[0].Visible = false;
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

        #endregion      
    }
}
