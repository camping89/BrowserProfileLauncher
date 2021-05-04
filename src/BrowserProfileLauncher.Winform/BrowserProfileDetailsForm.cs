using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Services.ProfileGroups;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class BrowserProfileDetailsForm : Form
    {
        private readonly BrowserProfileModel _browserProfile;
        private readonly IProfileGroupService _profileGroupService;
        public BrowserProfileDetailsForm(IProfileGroupService profileGroupService, BrowserProfileModel browserProfile = null)
        {
            InitializeComponent();
            _browserProfile = browserProfile ?? new BrowserProfileModel { UserId = Global.CurrentUser.Id };
            _profileGroupService = profileGroupService;
        }

        private void LoadProfileDetails()
        {
            txtProfileName.Text = _browserProfile.ProfileName;
            txtProxyProtocol.Text = _browserProfile.ProxyProtocol;
            txtProxyIp.Text = _browserProfile.ProxyIp;
            txtProxyUsername.Text = _browserProfile.ProxyUsername;
            txtPassword.Text = _browserProfile.ProxyPassword;
            txtProxyPort.Text = _browserProfile.ProxyPort.ToString();
        }

        private async Task LoadProfileGroups()
        {
            var groups = await _profileGroupService.GetAll();
            cbProfileGroup.DataSource = groups;
            cbProfileGroup.DisplayMember = nameof(ProfileGroupModel.GroupName);
            cbProfileGroup.ValueMember = nameof(ProfileGroupModel.Id);
            cbProfileGroup.SelectedItem = groups.FirstOrDefault(x => x.Id == _browserProfile.GroupId); ;
        }

        private void TxtProxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void BrowserProfileDetailsForm_Load(object sender, System.EventArgs e)
        {
            LoadProfileDetails();
            await LoadProfileGroups();
        }
    }
}
