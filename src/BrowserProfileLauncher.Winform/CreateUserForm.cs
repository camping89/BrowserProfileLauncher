using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.ProfileGroups;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class CreateUserForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IProfileGroupService _profileGroupService;
        private UserModel _user;
        public CreateUserForm(IAccountService accountService, IProfileGroupService profileGroupService)
        {
            InitializeComponent();
            _accountService = accountService;
            _profileGroupService = profileGroupService;
        }

        private async Task LoadProfileGroups()
        {
            var groups = await _profileGroupService.GetAll();
            lbxProfileGroups.DataSource = groups;
            lbxProfileGroups.DisplayMember = nameof(ProfileGroupModel.GroupName);
            lbxProfileGroups.ValueMember = nameof(ProfileGroupModel.Id);
            lbxProfileGroups.ClearSelected();
            if (_user != null)
            {
                foreach (var item in groups.Where(x => _user.ProfileGroupIds.Contains(x.Id)))
                {
                    lbxProfileGroups.SelectedItems.Add(item);
                }
            }
        }

        private async void UserDetailsForm_Load(object sender, EventArgs e)
        {
            await LoadProfileGroups();
        }
    }
}
