using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Common.Constants;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class MainForm : Form
    {
        private readonly IBrowserProfileService _browserProfileService;
        private readonly IAccountService _accountService;
        public MainForm(IBrowserProfileService browserProfileService, IAccountService accountService)
        {
            InitializeComponent();
            this.browserProfileDataGridView.DataSource = this.browserProfileBindingSource;
            _browserProfileService = browserProfileService;
            _accountService = accountService;
            SetupComponentVisibilities();
            LoadBrowserProfiles();
        }

        private void SetupComponentVisibilities()
        {
            if (!Global.CurrentUser.RoleNames.Contains(RoleNameConstants.AdminRole))
            {
                mainTabControl.TabPages.Remove(userTabPage);
                btnCreateProfile.Visible = false;
            }
        }

        private void LoadBrowserProfiles(int pageIndex = 0)
        {
            var browserProfiles = _browserProfileService.GetPagedList(Global.CurrentUser.Id, pageIndex: pageIndex);
            browserProfileDataGridView.AutoGenerateColumns = false;
            browserProfileBindingSource.DataSource = browserProfiles.Items;
            browserProfileDataGridView.Columns[0].Visible = false;
        }

        private void Logout(object? sender, EventArgs eventArgs)
        {
            Global.CurrentUser = null;
            var loginForm = new LoginForm(_accountService, _browserProfileService);
            Hide();
            loginForm.Show();
        }

        private async void browserProfileDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (IsDeleteProfileConfirmed())
            {
                var profile = (BrowserProfileModel)e.Row.DataBoundItem;
                await DeleteBrowserProfile(profile);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool IsDeleteProfileConfirmed()
        {
            return MessageBox.Show("Do you really want to delete the selected row", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes;
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
                        if (IsDeleteProfileConfirmed())
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

        private async void browserProfileDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var selectedRow = browserProfileDataGridView.Rows[e.RowIndex];
            var profile = (BrowserProfileModel)selectedRow.DataBoundItem;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn column && e.RowIndex >= 0)
            {
                switch (column.Name)
                {
                    case "DeleteProfile":
                        if (IsDeleteProfileConfirmed())
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

        private async void browserProfileDataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (IsDeleteProfileConfirmed())
            {
                var profile = (BrowserProfileModel)e.Row.DataBoundItem;
                await DeleteBrowserProfile(profile);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
