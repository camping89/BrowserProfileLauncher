using BrowserProfileLauncher.Services.Accounts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IServiceProvider _serviceProvider;
        public LoginForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _accountService = serviceProvider.GetRequiredService<IAccountService>(); ;
            _serviceProvider = serviceProvider;
        }

        private async void BtnLogin_Click(object sender, System.EventArgs e)
        {
            await Login();
        }

        private async void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
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
                var mainForm = new MainForm(_serviceProvider);
                mainForm.Closed += (s, args) => Close();
                Hide();
                mainForm.Show();
            }
            else
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
