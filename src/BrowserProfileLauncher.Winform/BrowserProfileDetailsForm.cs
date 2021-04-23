using BrowserProfileLauncher.Application.Models;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class BrowserProfileDetailsForm : Form
    {
        private readonly BrowserProfileModel _browserProfile;
        public BrowserProfileDetailsForm(BrowserProfileModel browserProfile = null)
        {
            InitializeComponent();
            _browserProfile = browserProfile ?? new BrowserProfileModel { UserId = Global.CurrentUser.Id };
            LoadProfileDetails();
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

        private void txtProxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
