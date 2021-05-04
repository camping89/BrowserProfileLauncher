using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Common.Constants;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using BrowserProfileLauncher.Services.ProfileGroups;
using Microsoft.Extensions.DependencyInjection;
using System;
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
        }

        #region general private class methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupComponentVisibilities();
            LoadBrowserProfiles();
            LoadProfileGroups();
            LoadUsers();
        }

        private void SetupComponentVisibilities()
        {
            if (!Global.CurrentUser.RoleNames.Contains(RoleNameConstants.AdminRole))
            {
                mainTabControl.TabPages.Remove(userTabPage);
                btnCreateProfile.Visible = false;
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
        }

        #endregion

        #region Browser Profiles methods

        private void LoadBrowserProfiles(int pageIndex = 0)
        {
            var pagedList = _browserProfileService.GetPagedList(Global.CurrentUser.Id, pageIndex: pageIndex);
            browserProfileDataGridView.AutoGenerateColumns = false;
            browserProfileBindingSource.DataSource = pagedList.Items;
            browserProfileDataGridView.Columns[0].Visible = false;
        }

        private async void browserProfileDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

        private async Task EditBrowserProfile(DataGridViewRow selectedRow)
        {
            var profile = (BrowserProfileModel)selectedRow.DataBoundItem;
            var editForm = new BrowserProfileDetailsForm(profile);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                profile.ProfileName = editForm.txtProfileName.Text;
                profile.ProxyIp = editForm.txtProxyIp.Text;
                profile.ProxyPort = int.Parse(editForm.txtProxyPort.Text);
                profile.ProxyUsername = editForm.txtProxyUsername.Text;
                profile.ProxyPassword = editForm.txtPassword.Text;
                profile.ProxyProtocol = editForm.txtProxyProtocol.Text;

                await _browserProfileService.Update(Global.CurrentUser.Id, profile);

                selectedRow.Cells["ProfileName"].Value = profile.ProfileName;
                selectedRow.Cells["ProxyIp"].Value = profile.ProxyIp;
                selectedRow.Cells["ProxyPort"].Value = profile.ProxyPort;
                selectedRow.Cells["ProxyUsername"].Value = profile.ProxyUsername;
                selectedRow.Cells["ProxyPassword"].Value = profile.ProxyPassword;
                selectedRow.Cells["ProxyProtocol"].Value = profile.ProxyProtocol;

            }
            editForm.Dispose();
        }

        private async void browserProfileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        {
                            await EditBrowserProfile(selectedRow);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private async void btnCreateProfile_Click(object sender, EventArgs e)
        {
            var newProfileForm = new BrowserProfileDetailsForm();
            if (newProfileForm.ShowDialog(this) == DialogResult.OK)
            {
                var profile = new BrowserProfileModel
                {
                    ProfileName = newProfileForm.txtProfileName.Text,
                    ProxyIp = newProfileForm.txtProxyIp.Text,
                    ProxyPort = int.Parse(newProfileForm.txtProxyPort.Text),
                    ProxyUsername = newProfileForm.txtProxyUsername.Text,
                    ProxyPassword = newProfileForm.txtPassword.Text,
                    ProxyProtocol = newProfileForm.txtProxyProtocol.Text,
                    UserId = Global.CurrentUser.Id
                };
                await _browserProfileService.Create(profile);
                LoadBrowserProfiles();
            };
            newProfileForm.Dispose();
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

        private async void profileGroupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        {
                            await EditBrowserProfileGroup(selectedRow);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private async void btnCreateProfileGroup_Click(object sender, EventArgs e)
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

        private async void profileGroupDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            var editForm = new UserDetailsForm(_accountService, user.Id);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                await _accountService.Update(user);
            }
            editForm.Dispose();
        }

        #endregion

        private async void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private async void userDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
    }
}
