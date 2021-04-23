using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IBrowserProfileService _browserProfileService;
        public LoginForm(IAccountService accountService, IBrowserProfileService browserProfileService)
        {
            InitializeComponent();
            _accountService = accountService;
            _browserProfileService = browserProfileService;
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            await Login();
        }

        private async void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await Login();
            }
        }

        private async Task Login()
        {
            var user = await _accountService.LoginAsync(txtUsername.Text, txtPassword.Text);
            btnLogin.Enabled = false;
            if (user != null)
            {
                Global.CurrentUser = user;
                var mainForm = new MainForm(_browserProfileService, _accountService);
                mainForm.Closed += (s, args) => Close();
                lblError.Visible = false;
                Hide();
                mainForm.Show();
            }

            lblError.Visible = true;
            btnLogin.Enabled = true;
        }
    }
}
