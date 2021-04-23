namespace BrowserProfileLauncher.Winform
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.browserProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.profileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.browserProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.ProfileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PingProxy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.userPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAccount_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.profileTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).BeginInit();
            this.userTabPage.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.mainFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Controls.Add(this.userTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(3, 32);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1228, 355);
            this.mainTabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profileTableLayoutPanel);
            this.profileTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1220, 327);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profiles";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // profileTableLayoutPanel
            // 
            this.profileTableLayoutPanel.ColumnCount = 1;
            this.profileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profileTableLayoutPanel.Controls.Add(this.btnCreateProfile, 0, 0);
            this.profileTableLayoutPanel.Controls.Add(this.browserProfileDataGridView, 0, 1);
            this.profileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.profileTableLayoutPanel.Name = "profileTableLayoutPanel";
            this.profileTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileTableLayoutPanel.RowCount = 3;
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.Size = new System.Drawing.Size(1214, 321);
            this.profileTableLayoutPanel.TabIndex = 1;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProfile.Location = new System.Drawing.Point(1086, 7);
            this.btnCreateProfile.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Padding = new System.Windows.Forms.Padding(5);
            this.btnCreateProfile.Size = new System.Drawing.Size(125, 41);
            this.btnCreateProfile.TabIndex = 0;
            this.btnCreateProfile.Text = "Create New";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // browserProfileDataGridView
            // 
            this.browserProfileDataGridView.AllowUserToAddRows = false;
            this.browserProfileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserProfileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.browserProfileDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.browserProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browserProfileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileId,
            this.GroupName,
            this.ProfileName,
            this.ProxyProtocol,
            this.ProxyIp,
            this.ProxyPort,
            this.ProxyUsername,
            this.ProxyPassword,
            this.EditProfile,
            this.DeleteProfile,
            this.PingProxy});
            this.browserProfileDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.browserProfileDataGridView.Location = new System.Drawing.Point(3, 54);
            this.browserProfileDataGridView.MultiSelect = false;
            this.browserProfileDataGridView.Name = "browserProfileDataGridView";
            this.browserProfileDataGridView.ReadOnly = true;
            this.browserProfileDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.browserProfileDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.browserProfileDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.browserProfileDataGridView.RowTemplate.Height = 25;
            this.browserProfileDataGridView.Size = new System.Drawing.Size(1208, 474);
            this.browserProfileDataGridView.TabIndex = 0;
            this.browserProfileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.browserProfileDataGridView_CellContentClick);
            this.browserProfileDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.browserProfileDataGridView_UserDeletingRow);
            // 
            // ProfileId
            // 
            this.ProfileId.DataPropertyName = "Id";
            this.ProfileId.HeaderText = "Id";
            this.ProfileId.Name = "ProfileId";
            this.ProfileId.ReadOnly = true;
            this.ProfileId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfileId.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // ProfileName
            // 
            this.ProfileName.DataPropertyName = "ProfileName";
            this.ProfileName.HeaderText = "Name";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            // 
            // ProxyProtocol
            // 
            this.ProxyProtocol.DataPropertyName = "ProxyProtocol";
            this.ProxyProtocol.HeaderText = "Protocol";
            this.ProxyProtocol.Name = "ProxyProtocol";
            this.ProxyProtocol.ReadOnly = true;
            this.ProxyProtocol.ToolTipText = "Proxy protocol";
            // 
            // ProxyIp
            // 
            this.ProxyIp.DataPropertyName = "ProxyIp";
            this.ProxyIp.HeaderText = "IP";
            this.ProxyIp.Name = "ProxyIp";
            this.ProxyIp.ReadOnly = true;
            this.ProxyIp.ToolTipText = "Proxy IP";
            // 
            // ProxyPort
            // 
            this.ProxyPort.DataPropertyName = "ProxyPort";
            this.ProxyPort.HeaderText = "Port";
            this.ProxyPort.Name = "ProxyPort";
            this.ProxyPort.ReadOnly = true;
            // 
            // ProxyUsername
            // 
            this.ProxyUsername.DataPropertyName = "ProxyUserName";
            this.ProxyUsername.HeaderText = "Username";
            this.ProxyUsername.Name = "ProxyUsername";
            this.ProxyUsername.ReadOnly = true;
            this.ProxyUsername.ToolTipText = "Proxy username";
            // 
            // ProxyPassword
            // 
            this.ProxyPassword.DataPropertyName = "ProxyPassword";
            this.ProxyPassword.HeaderText = "Password";
            this.ProxyPassword.Name = "ProxyPassword";
            this.ProxyPassword.ReadOnly = true;
            this.ProxyPassword.Visible = false;
            // 
            // EditProfile
            // 
            this.EditProfile.HeaderText = "";
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.ReadOnly = true;
            this.EditProfile.Text = "Edit";
            this.EditProfile.ToolTipText = "Edit profile";
            this.EditProfile.UseColumnTextForButtonValue = true;
            // 
            // DeleteProfile
            // 
            this.DeleteProfile.HeaderText = "";
            this.DeleteProfile.Name = "DeleteProfile";
            this.DeleteProfile.ReadOnly = true;
            this.DeleteProfile.Text = "Delete";
            this.DeleteProfile.ToolTipText = "Delete Profile";
            this.DeleteProfile.UseColumnTextForButtonValue = true;
            // 
            // PingProxy
            // 
            this.PingProxy.HeaderText = "";
            this.PingProxy.Name = "PingProxy";
            this.PingProxy.ReadOnly = true;
            this.PingProxy.Text = "Ping";
            this.PingProxy.ToolTipText = "Ping profile proxy";
            this.PingProxy.UseColumnTextForButtonValue = true;
            // 
            // userTabPage
            // 
            this.userTabPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userTabPage.Controls.Add(this.userPanel);
            this.userTabPage.Location = new System.Drawing.Point(4, 24);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(1220, 327);
            this.userTabPage.TabIndex = 1;
            this.userTabPage.Text = "Users";
            this.userTabPage.UseVisualStyleBackColor = true;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.dataGridView2);
            this.userPanel.Controls.Add(this.dataGridView1);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(3, 3);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(1214, 321);
            this.userPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1214, 321);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAccount});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(87, 29);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Menu";
            // 
            // menuItemAccount
            // 
            this.menuItemAccount.BackColor = System.Drawing.Color.Black;
            this.menuItemAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAccount_Logout});
            this.menuItemAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItemAccount.ForeColor = System.Drawing.Color.Gold;
            this.menuItemAccount.Name = "menuItemAccount";
            this.menuItemAccount.Size = new System.Drawing.Size(85, 25);
            this.menuItemAccount.Text = "Account";
            // 
            // menuItemAccount_Logout
            // 
            this.menuItemAccount_Logout.BackColor = System.Drawing.Color.Black;
            this.menuItemAccount_Logout.ForeColor = System.Drawing.Color.Gold;
            this.menuItemAccount_Logout.Name = "menuItemAccount_Logout";
            this.menuItemAccount_Logout.Size = new System.Drawing.Size(134, 26);
            this.menuItemAccount_Logout.Text = "Logout";
            this.menuItemAccount_Logout.Click += new System.EventHandler(this.Logout);
            // 
            // mainFormTableLayoutPanel
            // 
            this.mainFormTableLayoutPanel.AutoSize = true;
            this.mainFormTableLayoutPanel.ColumnCount = 1;
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainFormTableLayoutPanel.Controls.Add(this.mainMenu, 0, 0);
            this.mainFormTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 1);
            this.mainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormTableLayoutPanel.Name = "mainFormTableLayoutPanel";
            this.mainFormTableLayoutPanel.RowCount = 2;
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.Size = new System.Drawing.Size(1234, 634);
            this.mainFormTableLayoutPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 634);
            this.Controls.Add(this.mainFormTableLayoutPanel);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Browser Profile Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).EndInit();
            this.userTabPage.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainFormTableLayoutPanel.ResumeLayout(false);
            this.mainFormTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource browserProfileBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount_Logout;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel profileTableLayoutPanel;
        private System.Windows.Forms.DataGridView browserProfileDataGridView;
        private System.Windows.Forms.TableLayoutPanel mainFormTableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyPassword;
        private System.Windows.Forms.DataGridViewButtonColumn EditProfile;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProfile;
        private System.Windows.Forms.DataGridViewButtonColumn PingProxy;
    }
}
