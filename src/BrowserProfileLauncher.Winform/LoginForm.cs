﻿using BrowserProfileLauncher.Services.Accounts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Exception = System.Exception;

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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            await Login();
        }

        private async void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter) 
            {
                await Login();
            }
        }

        private async Task Login()
        {
            try
            {
                var user = await _accountService.LoginAsync(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    Global.CurrentUser = user;
                    var mainForm = new MainForm(_serviceProvider);
                    mainForm.Closed += (s, args) => Close();
                    Hide();
                    try
                    {
                        mainForm.Show();
                    }
                    catch (Exception)
                    {
                        mainForm.Close();
                    }
                }
                else
                {
                    btnLogin.Enabled = true;
                    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Can't connect to database! Please contact to Admin for reporting the Error!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
