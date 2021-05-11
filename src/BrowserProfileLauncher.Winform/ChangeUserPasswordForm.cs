using BrowserProfileLauncher.Services.Accounts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class ChangeUserPasswordForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly Guid? _userId;
        public ChangeUserPasswordForm(IAccountService accountService, Guid? userId = null)
        {
            InitializeComponent();
            _accountService = accountService;
            _userId = userId;
        }

        private async Task LoadUserDetails()
        {
            var user = await _accountService.GetById(_userId.GetValueOrDefault());
            if (user != null)
            {
                this.txtUsername.Text = user.Username;
            }
        }
    }
}
