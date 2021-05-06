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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.browserProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.profileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.LaunchBrowser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.profleTableLayoutHeaderPanel = new System.Windows.Forms.Panel();
            this.btnSearchProfile = new System.Windows.Forms.Button();
            this.txtSearchProfileName = new System.Windows.Forms.TextBox();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.profilePaginationPanel = new System.Windows.Forms.Panel();
            this.txtCurrentProfilePage = new System.Windows.Forms.NumericUpDown();
            this.btnFirstProfilePage = new System.Windows.Forms.Button();
            this.btnPreviousProfilePage = new System.Windows.Forms.Button();
            this.btnLastProfilePage = new System.Windows.Forms.Button();
            this.btnNextProfilePage = new System.Windows.Forms.Button();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChangeUserPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.profileGroupTabPage = new System.Windows.Forms.TabPage();
            this.profileGroupTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.profileGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.profileGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilesCounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditProfileGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProfileGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreateProfileGroup = new System.Windows.Forms.Button();
            this.ProfieGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.profileGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAccount_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.profileTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).BeginInit();
            this.profleTableLayoutHeaderPanel.SuspendLayout();
            this.profilePaginationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentProfilePage)).BeginInit();
            this.userTabPage.SuspendLayout();
            this.userTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.profileGroupTabPage.SuspendLayout();
            this.profileGroupTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGroupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGroupBindingSource)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.mainFormTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.profileTabPage);
            this.mainTabControl.Controls.Add(this.userTabPage);
            this.mainTabControl.Controls.Add(this.profileGroupTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(3, 32);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1228, 576);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.profileTableLayoutPanel);
            this.profileTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1220, 548);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profiles";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // profileTableLayoutPanel
            // 
            this.profileTableLayoutPanel.ColumnCount = 1;
            this.profileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profileTableLayoutPanel.Controls.Add(this.browserProfileDataGridView, 0, 1);
            this.profileTableLayoutPanel.Controls.Add(this.profleTableLayoutHeaderPanel, 0, 0);
            this.profileTableLayoutPanel.Controls.Add(this.profilePaginationPanel, 0, 2);
            this.profileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.profileTableLayoutPanel.Name = "profileTableLayoutPanel";
            this.profileTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileTableLayoutPanel.RowCount = 3;
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileTableLayoutPanel.Size = new System.Drawing.Size(1214, 542);
            this.profileTableLayoutPanel.TabIndex = 1;
            // 
            // browserProfileDataGridView
            // 
            this.browserProfileDataGridView.AllowUserToAddRows = false;
            this.browserProfileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.browserProfileDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.PingProxy,
            this.LaunchBrowser});
            this.browserProfileDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.browserProfileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserProfileDataGridView.Location = new System.Drawing.Point(3, 43);
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
            this.browserProfileDataGridView.Size = new System.Drawing.Size(1208, 400);
            this.browserProfileDataGridView.TabIndex = 0;
            this.browserProfileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BrowserProfileDataGridView_CellContentClick);
            this.browserProfileDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.BrowserProfileDataGridView_UserDeletingRow);
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
            this.ProfileName.HeaderText = "Profile Name";
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
            // LaunchBrowser
            // 
            this.LaunchBrowser.HeaderText = "";
            this.LaunchBrowser.Name = "LaunchBrowser";
            this.LaunchBrowser.ReadOnly = true;
            this.LaunchBrowser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LaunchBrowser.Text = "Launch Browser";
            this.LaunchBrowser.ToolTipText = "Launch Browser With This Proxy Profile";
            this.LaunchBrowser.UseColumnTextForButtonValue = true;
            // 
            // profleTableLayoutHeaderPanel
            // 
            this.profleTableLayoutHeaderPanel.Controls.Add(this.btnSearchProfile);
            this.profleTableLayoutHeaderPanel.Controls.Add(this.txtSearchProfileName);
            this.profleTableLayoutHeaderPanel.Controls.Add(this.btnCreateProfile);
            this.profleTableLayoutHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profleTableLayoutHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.profleTableLayoutHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.profleTableLayoutHeaderPanel.Name = "profleTableLayoutHeaderPanel";
            this.profleTableLayoutHeaderPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profleTableLayoutHeaderPanel.Size = new System.Drawing.Size(1214, 40);
            this.profleTableLayoutHeaderPanel.TabIndex = 1;
            // 
            // btnSearchProfile
            // 
            this.btnSearchProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProfile.Location = new System.Drawing.Point(278, 1);
            this.btnSearchProfile.Name = "btnSearchProfile";
            this.btnSearchProfile.Size = new System.Drawing.Size(105, 40);
            this.btnSearchProfile.TabIndex = 2;
            this.btnSearchProfile.Text = "Search";
            this.btnSearchProfile.UseVisualStyleBackColor = true;
            this.btnSearchProfile.Click += new System.EventHandler(this.BtnSearchProfile_Click);
            // 
            // txtSearchProfileName
            // 
            this.txtSearchProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchProfileName.Location = new System.Drawing.Point(4, 2);
            this.txtSearchProfileName.MinimumSize = new System.Drawing.Size(274, 38);
            this.txtSearchProfileName.Multiline = true;
            this.txtSearchProfileName.Name = "txtSearchProfileName";
            this.txtSearchProfileName.PlaceholderText = "search";
            this.txtSearchProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchProfileName.Size = new System.Drawing.Size(274, 38);
            this.txtSearchProfileName.TabIndex = 1;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProfile.Location = new System.Drawing.Point(1085, 1);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(125, 40);
            this.btnCreateProfile.TabIndex = 0;
            this.btnCreateProfile.Text = "Create New";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.BtnCreateProfile_Click);
            // 
            // profilePaginationPanel
            // 
            this.profilePaginationPanel.Controls.Add(this.txtCurrentProfilePage);
            this.profilePaginationPanel.Controls.Add(this.btnFirstProfilePage);
            this.profilePaginationPanel.Controls.Add(this.btnPreviousProfilePage);
            this.profilePaginationPanel.Controls.Add(this.btnLastProfilePage);
            this.profilePaginationPanel.Controls.Add(this.btnNextProfilePage);
            this.profilePaginationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePaginationPanel.Location = new System.Drawing.Point(3, 449);
            this.profilePaginationPanel.Name = "profilePaginationPanel";
            this.profilePaginationPanel.Size = new System.Drawing.Size(1208, 90);
            this.profilePaginationPanel.TabIndex = 2;
            // 
            // txtCurrentProfilePage
            // 
            this.txtCurrentProfilePage.AutoSize = true;
            this.txtCurrentProfilePage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentProfilePage.Location = new System.Drawing.Point(888, 13);
            this.txtCurrentProfilePage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCurrentProfilePage.MaximumSize = new System.Drawing.Size(91, 0);
            this.txtCurrentProfilePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCurrentProfilePage.MinimumSize = new System.Drawing.Size(91, 0);
            this.txtCurrentProfilePage.Name = "txtCurrentProfilePage";
            this.txtCurrentProfilePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrentProfilePage.Size = new System.Drawing.Size(91, 34);
            this.txtCurrentProfilePage.TabIndex = 4;
            this.txtCurrentProfilePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentProfilePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCurrentProfilePage.ValueChanged += new System.EventHandler(this.TxtCurrentProfilePage_ValueChanged);
            // 
            // btnFirstProfilePage
            // 
            this.btnFirstProfilePage.Location = new System.Drawing.Point(660, 13);
            this.btnFirstProfilePage.Name = "btnFirstProfilePage";
            this.btnFirstProfilePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFirstProfilePage.Size = new System.Drawing.Size(108, 35);
            this.btnFirstProfilePage.TabIndex = 3;
            this.btnFirstProfilePage.Text = "|<<";
            this.btnFirstProfilePage.UseVisualStyleBackColor = true;
            this.btnFirstProfilePage.Click += new System.EventHandler(this.BtnFirstProfilePage_Click);
            // 
            // btnPreviousProfilePage
            // 
            this.btnPreviousProfilePage.Location = new System.Drawing.Point(774, 13);
            this.btnPreviousProfilePage.Name = "btnPreviousProfilePage";
            this.btnPreviousProfilePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreviousProfilePage.Size = new System.Drawing.Size(108, 35);
            this.btnPreviousProfilePage.TabIndex = 2;
            this.btnPreviousProfilePage.Text = "<";
            this.btnPreviousProfilePage.UseVisualStyleBackColor = true;
            this.btnPreviousProfilePage.Click += new System.EventHandler(this.BtnPreviousProfilePage_Click);
            // 
            // btnLastProfilePage
            // 
            this.btnLastProfilePage.Location = new System.Drawing.Point(1099, 13);
            this.btnLastProfilePage.Name = "btnLastProfilePage";
            this.btnLastProfilePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLastProfilePage.Size = new System.Drawing.Size(108, 35);
            this.btnLastProfilePage.TabIndex = 1;
            this.btnLastProfilePage.Text = ">>|";
            this.btnLastProfilePage.UseVisualStyleBackColor = true;
            this.btnLastProfilePage.Click += new System.EventHandler(this.BtnLastProfilePage_Click);
            // 
            // btnNextProfilePage
            // 
            this.btnNextProfilePage.Location = new System.Drawing.Point(985, 13);
            this.btnNextProfilePage.Name = "btnNextProfilePage";
            this.btnNextProfilePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNextProfilePage.Size = new System.Drawing.Size(108, 35);
            this.btnNextProfilePage.TabIndex = 0;
            this.btnNextProfilePage.Text = ">";
            this.btnNextProfilePage.UseVisualStyleBackColor = true;
            this.btnNextProfilePage.Click += new System.EventHandler(this.BtnNextProfilePage_Click);
            // 
            // userTabPage
            // 
            this.userTabPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userTabPage.Controls.Add(this.userTableLayoutPanel);
            this.userTabPage.Location = new System.Drawing.Point(4, 24);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(1220, 548);
            this.userTabPage.TabIndex = 1;
            this.userTabPage.Text = "Users";
            this.userTabPage.UseVisualStyleBackColor = true;
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 1;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userTableLayoutPanel.Controls.Add(this.userDataGridView, 0, 1);
            this.userTableLayoutPanel.Controls.Add(this.btnCreateUser, 0, 0);
            this.userTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTableLayoutPanel.RowCount = 3;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userTableLayoutPanel.Size = new System.Drawing.Size(1214, 542);
            this.userTableLayoutPanel.TabIndex = 0;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Username,
            this.EditUser,
            this.DeleteUser,
            this.ChangeUserPassword});
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(3, 50);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(1208, 250);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            this.userDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.UserDataGridView_UserDeletingRow);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // EditUser
            // 
            this.EditUser.HeaderText = "";
            this.EditUser.Name = "EditUser";
            this.EditUser.ReadOnly = true;
            this.EditUser.Text = "Edit User";
            this.EditUser.ToolTipText = "Edit User";
            this.EditUser.UseColumnTextForButtonValue = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.HeaderText = "";
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.ReadOnly = true;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseColumnTextForButtonValue = true;
            // 
            // ChangeUserPassword
            // 
            this.ChangeUserPassword.HeaderText = "";
            this.ChangeUserPassword.Name = "ChangeUserPassword";
            this.ChangeUserPassword.ReadOnly = true;
            this.ChangeUserPassword.Text = "Change Password";
            this.ChangeUserPassword.ToolTipText = "Change User Password";
            this.ChangeUserPassword.UseColumnTextForButtonValue = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateUser.Location = new System.Drawing.Point(1086, 3);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.btnCreateUser.Size = new System.Drawing.Size(125, 41);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Create New";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // profileGroupTabPage
            // 
            this.profileGroupTabPage.Controls.Add(this.profileGroupTableLayoutPanel);
            this.profileGroupTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileGroupTabPage.Name = "profileGroupTabPage";
            this.profileGroupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileGroupTabPage.Size = new System.Drawing.Size(1220, 548);
            this.profileGroupTabPage.TabIndex = 2;
            this.profileGroupTabPage.Text = "Profile Groups";
            this.profileGroupTabPage.UseVisualStyleBackColor = true;
            // 
            // profileGroupTableLayoutPanel
            // 
            this.profileGroupTableLayoutPanel.ColumnCount = 1;
            this.profileGroupTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profileGroupTableLayoutPanel.Controls.Add(this.profileGroupDataGridView, 0, 1);
            this.profileGroupTableLayoutPanel.Controls.Add(this.btnCreateProfileGroup, 0, 0);
            this.profileGroupTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileGroupTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.profileGroupTableLayoutPanel.Name = "profileGroupTableLayoutPanel";
            this.profileGroupTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileGroupTableLayoutPanel.RowCount = 3;
            this.profileGroupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileGroupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileGroupTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profileGroupTableLayoutPanel.Size = new System.Drawing.Size(1214, 542);
            this.profileGroupTableLayoutPanel.TabIndex = 0;
            // 
            // profileGroupDataGridView
            // 
            this.profileGroupDataGridView.AllowUserToAddRows = false;
            this.profileGroupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileGroupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.profileGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileGroupId,
            this.ProfileGroupName,
            this.ProfilesCounts,
            this.EditProfileGroup,
            this.DeleteProfileGroup});
            this.profileGroupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileGroupDataGridView.Location = new System.Drawing.Point(3, 50);
            this.profileGroupDataGridView.Name = "profileGroupDataGridView";
            this.profileGroupDataGridView.ReadOnly = true;
            this.profileGroupDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileGroupDataGridView.RowTemplate.Height = 25;
            this.profileGroupDataGridView.Size = new System.Drawing.Size(1208, 250);
            this.profileGroupDataGridView.TabIndex = 0;
            this.profileGroupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfileGroupDataGridView_CellContentClick);
            this.profileGroupDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ProfileGroupDataGridView_UserDeletingRow);
            // 
            // profileGroupId
            // 
            this.profileGroupId.DataPropertyName = "Id";
            this.profileGroupId.HeaderText = "Id";
            this.profileGroupId.Name = "profileGroupId";
            this.profileGroupId.ReadOnly = true;
            this.profileGroupId.Visible = false;
            // 
            // ProfileGroupName
            // 
            this.ProfileGroupName.DataPropertyName = "GroupName";
            this.ProfileGroupName.HeaderText = "Group Name";
            this.ProfileGroupName.Name = "ProfileGroupName";
            this.ProfileGroupName.ReadOnly = true;
            // 
            // ProfilesCounts
            // 
            this.ProfilesCounts.DataPropertyName = "ProfilesCount";
            this.ProfilesCounts.HeaderText = "Profiles Count";
            this.ProfilesCounts.Name = "ProfilesCounts";
            this.ProfilesCounts.ReadOnly = true;
            // 
            // EditProfileGroup
            // 
            this.EditProfileGroup.HeaderText = "";
            this.EditProfileGroup.Name = "EditProfileGroup";
            this.EditProfileGroup.ReadOnly = true;
            this.EditProfileGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditProfileGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditProfileGroup.Text = "Edit";
            this.EditProfileGroup.UseColumnTextForButtonValue = true;
            // 
            // DeleteProfileGroup
            // 
            this.DeleteProfileGroup.HeaderText = "";
            this.DeleteProfileGroup.Name = "DeleteProfileGroup";
            this.DeleteProfileGroup.ReadOnly = true;
            this.DeleteProfileGroup.Text = "Delete";
            this.DeleteProfileGroup.UseColumnTextForButtonValue = true;
            // 
            // btnCreateProfileGroup
            // 
            this.btnCreateProfileGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProfileGroup.Location = new System.Drawing.Point(1086, 3);
            this.btnCreateProfileGroup.Name = "btnCreateProfileGroup";
            this.btnCreateProfileGroup.Padding = new System.Windows.Forms.Padding(5);
            this.btnCreateProfileGroup.Size = new System.Drawing.Size(125, 41);
            this.btnCreateProfileGroup.TabIndex = 1;
            this.btnCreateProfileGroup.Text = "Create New";
            this.btnCreateProfileGroup.UseVisualStyleBackColor = true;
            this.btnCreateProfileGroup.Click += new System.EventHandler(this.BtnCreateProfileGroup_Click);
            // 
            // ProfieGroupId
            // 
            this.ProfieGroupId.DataPropertyName = "Id";
            this.ProfieGroupId.HeaderText = "Id";
            this.ProfieGroupId.Name = "ProfieGroupId";
            this.ProfieGroupId.ReadOnly = true;
            this.ProfieGroupId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GroupName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Group Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProfilesCount
            // 
            this.ProfilesCount.HeaderText = "Profiles Count";
            this.ProfilesCount.Name = "ProfilesCount";
            this.ProfilesCount.ReadOnly = true;
            // 
            // EditGroup
            // 
            this.EditGroup.HeaderText = "";
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.ReadOnly = true;
            this.EditGroup.Text = "Edit";
            this.EditGroup.ToolTipText = "Edit Group";
            this.EditGroup.UseColumnTextForButtonValue = true;
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.HeaderText = "";
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.ReadOnly = true;
            this.DeleteGroup.Text = "Delete";
            this.DeleteGroup.ToolTipText = "Delete Group";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).EndInit();
            this.profleTableLayoutHeaderPanel.ResumeLayout(false);
            this.profleTableLayoutHeaderPanel.PerformLayout();
            this.profilePaginationPanel.ResumeLayout(false);
            this.profilePaginationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentProfilePage)).EndInit();
            this.userTabPage.ResumeLayout(false);
            this.userTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.profileGroupTabPage.ResumeLayout(false);
            this.profileGroupTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileGroupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGroupBindingSource)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainFormTableLayoutPanel.ResumeLayout(false);
            this.mainFormTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource browserProfileBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount_Logout;
        private System.Windows.Forms.TableLayoutPanel profileTableLayoutPanel;
        private System.Windows.Forms.DataGridView browserProfileDataGridView;
        private System.Windows.Forms.TableLayoutPanel mainFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.TabPage profileGroupTabPage;
        private System.Windows.Forms.TableLayoutPanel profileGroupTableLayoutPanel;
        private System.Windows.Forms.BindingSource profileGroupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfieGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilesCount;
        private System.Windows.Forms.DataGridViewButtonColumn EditGroup;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGroup;
        private System.Windows.Forms.DataGridView profileGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilesCounts;
        private System.Windows.Forms.DataGridViewButtonColumn EditProfileGroup;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProfileGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateProfileGroup;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewButtonColumn EditUser;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteUser;
        private System.Windows.Forms.DataGridViewButtonColumn ChangeUserPassword;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DataGridViewButtonColumn PingProxy;
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
        private System.Windows.Forms.DataGridViewButtonColumn LaunchBrowser;
        private System.Windows.Forms.Panel profleTableLayoutHeaderPanel;
        private System.Windows.Forms.Button btnSearchProfile;
        private System.Windows.Forms.TextBox txtSearchProfileName;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Panel profilePaginationPanel;
        private System.Windows.Forms.Button btnNextProfilePage;
        private System.Windows.Forms.NumericUpDown txtCurrentProfilePage;
        private System.Windows.Forms.Button btnFirstProfilePage;
        private System.Windows.Forms.Button btnPreviousProfilePage;
        private System.Windows.Forms.Button btnLastProfilePage;
    }
}
