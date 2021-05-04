using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.ProfileGroups;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class UserDetailsForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IProfileGroupService _profileGroupService;
        private readonly Guid? _userId;
        private UserModel _user;
        public UserDetailsForm(IAccountService accountService, IProfileGroupService profileGroupService, Guid? userId = null)
        {
            InitializeComponent();
            _accountService = accountService;
            _userId = userId;
            _profileGroupService = profileGroupService;
        }

        private async Task LoadUserDetails()
        {
            var user = await _accountService.GetById(_userId.GetValueOrDefault());
            if (user != null)
            {
                _user = user;
                txtUsername.Text = user.Username;
            }
        }
        private async Task LoadProfileGroups()
        {
            var groups = await _profileGroupService.GetAll();
            lbxProfileGroups.DataSource = groups;
            lbxProfileGroups.DisplayMember = nameof(ProfileGroupModel.GroupName);
            lbxProfileGroups.ValueMember = nameof(ProfileGroupModel.Id);
            lbxProfileGroups.ClearSelected();
            foreach (var item in groups.Where(x => _user.ProfileGroupIds.Contains(x.Id)))
            {
                lbxProfileGroups.SelectedItems.Add(item);
            }
        }

        private async void UserDetailsForm_Load(object sender, EventArgs e)
        {
            await LoadUserDetails();
            await LoadProfileGroups();
        }
    }
}
