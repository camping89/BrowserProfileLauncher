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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.browserProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PingProxy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.browserProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.browserProfileDataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProfileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ping = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createProfilePanel = new System.Windows.Forms.Panel();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.userPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAccount_Logout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView2)).BeginInit();
            this.createProfilePanel.SuspendLayout();
            this.userTabPage.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserProfileDataGridView
            // 
            this.browserProfileDataGridView.AllowUserToAddRows = false;
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
            this.Id,
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
            this.browserProfileDataGridView.Location = new System.Drawing.Point(0, 52);
            this.browserProfileDataGridView.MultiSelect = false;
            this.browserProfileDataGridView.Name = "browserProfileDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.browserProfileDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.browserProfileDataGridView.RowTemplate.Height = 25;
            this.browserProfileDataGridView.Size = new System.Drawing.Size(1220, 519);
            this.browserProfileDataGridView.TabIndex = 0;
            this.browserProfileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.browserProfileDataGridView_CellContentClick);
            this.browserProfileDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.browserProfileDataGridView_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ProfileName
            // 
            this.ProfileName.DataPropertyName = "ProfileName";
            this.ProfileName.HeaderText = "Name";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Width = 118;
            // 
            // ProxyProtocol
            // 
            this.ProxyProtocol.DataPropertyName = "ProxyProtocol";
            this.ProxyProtocol.HeaderText = "Protocol";
            this.ProxyProtocol.Name = "ProxyProtocol";
            this.ProxyProtocol.ToolTipText = "Proxy protocol";
            this.ProxyProtocol.Width = 118;
            // 
            // ProxyIp
            // 
            this.ProxyIp.DataPropertyName = "ProxyIp";
            this.ProxyIp.HeaderText = "IP";
            this.ProxyIp.Name = "ProxyIp";
            this.ProxyIp.ToolTipText = "Proxy IP";
            this.ProxyIp.Width = 118;
            // 
            // ProxyPort
            // 
            this.ProxyPort.DataPropertyName = "ProxyPort";
            this.ProxyPort.HeaderText = "Port";
            this.ProxyPort.Name = "ProxyPort";
            this.ProxyPort.Width = 117;
            // 
            // ProxyUsername
            // 
            this.ProxyUsername.DataPropertyName = "ProxyUserName";
            this.ProxyUsername.HeaderText = "Username";
            this.ProxyUsername.Name = "ProxyUsername";
            this.ProxyUsername.ToolTipText = "Proxy username";
            this.ProxyUsername.Width = 118;
            // 
            // ProxyPassword
            // 
            this.ProxyPassword.DataPropertyName = "ProxyPassword";
            this.ProxyPassword.HeaderText = "Password";
            this.ProxyPassword.Name = "ProxyPassword";
            this.ProxyPassword.Width = 118;
            // 
            // EditProfile
            // 
            this.EditProfile.HeaderText = "";
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Text = "Edit";
            this.EditProfile.ToolTipText = "Edit profile";
            this.EditProfile.UseColumnTextForButtonValue = true;
            this.EditProfile.Width = 118;
            // 
            // DeleteProfile
            // 
            this.DeleteProfile.HeaderText = "";
            this.DeleteProfile.Name = "DeleteProfile";
            this.DeleteProfile.Text = "Delete";
            this.DeleteProfile.ToolTipText = "Delete Profile";
            this.DeleteProfile.UseColumnTextForButtonValue = true;
            this.DeleteProfile.Width = 117;
            // 
            // PingProxy
            // 
            this.PingProxy.HeaderText = "";
            this.PingProxy.Name = "PingProxy";
            this.PingProxy.Text = "Ping";
            this.PingProxy.ToolTipText = "Ping profile proxy";
            this.PingProxy.UseColumnTextForButtonValue = true;
            this.PingProxy.Width = 118;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Controls.Add(this.userTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 29);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1234, 605);
            this.mainTabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profilePanel);
            this.profileTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1226, 577);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profiles";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.browserProfileDataGridView2);
            this.profilePanel.Controls.Add(this.createProfilePanel);
            this.profilePanel.Controls.Add(this.browserProfileDataGridView);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(3, 3);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1220, 571);
            this.profilePanel.TabIndex = 0;
            // 
            // browserProfileDataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.browserProfileDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.browserProfileDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browserProfileDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileId,
            this.GroupName,
            this.dataGridViewTextBoxColumn1,
            this.Protocol,
            this.IP,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Edit,
            this.Delete,
            this.Ping});
            this.browserProfileDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browserProfileDataGridView2.Location = new System.Drawing.Point(0, 421);
            this.browserProfileDataGridView2.MultiSelect = false;
            this.browserProfileDataGridView2.Name = "browserProfileDataGridView2";
            this.browserProfileDataGridView2.RowTemplate.Height = 25;
            this.browserProfileDataGridView2.Size = new System.Drawing.Size(1220, 150);
            this.browserProfileDataGridView2.TabIndex = 2;
            this.browserProfileDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.browserProfileDataGridView2_CellContentClick);
            this.browserProfileDataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.browserProfileDataGridView2_UserDeletingRow);
            // 
            // ProfileId
            // 
            this.ProfileId.HeaderText = "Id";
            this.ProfileId.Name = "ProfileId";
            this.ProfileId.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group";
            this.GroupName.Name = "GroupName";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProfileName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Profile Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "ProxyProtocol";
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.Name = "Protocol";
            // 
            // IP
            // 
            this.IP.DataPropertyName = "ProxyIP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProxyPort";
            this.dataGridViewTextBoxColumn2.HeaderText = "Port";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProxyUserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Ping
            // 
            this.Ping.HeaderText = "";
            this.Ping.Name = "Ping";
            this.Ping.Text = "Ping";
            this.Ping.UseColumnTextForButtonValue = true;
            // 
            // createProfilePanel
            // 
            this.createProfilePanel.Controls.Add(this.btnCreateProfile);
            this.createProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.createProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.createProfilePanel.Name = "createProfilePanel";
            this.createProfilePanel.Size = new System.Drawing.Size(1220, 51);
            this.createProfilePanel.TabIndex = 1;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProfile.Location = new System.Drawing.Point(1062, 6);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(125, 40);
            this.btnCreateProfile.TabIndex = 0;
            this.btnCreateProfile.Text = "Create New";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // userTabPage
            // 
            this.userTabPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userTabPage.Controls.Add(this.userPanel);
            this.userTabPage.Location = new System.Drawing.Point(4, 24);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(1226, 577);
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
            this.userPanel.Size = new System.Drawing.Size(1220, 571);
            this.userPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1220, 571);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAccount});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1234, 29);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 634);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Browser Profile Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView2)).EndInit();
            this.createProfilePanel.ResumeLayout(false);
            this.userTabPage.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource browserProfileBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.DataGridView browserProfileDataGridView;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount_Logout;
        private System.Windows.Forms.Panel createProfilePanel;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyPassword;
        private System.Windows.Forms.DataGridViewButtonColumn EditProfile;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProfile;
        private System.Windows.Forms.DataGridViewButtonColumn PingProxy;
        private System.Windows.Forms.DataGridView browserProfileDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileId;
        private System.Windows.Forms.DataGridViewButtonColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Ping;
    }
}
