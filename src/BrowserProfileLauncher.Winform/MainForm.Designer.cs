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
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
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
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChangeUserPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.profileTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).BeginInit();
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
            this.btnCreateProfile.Click += new System.EventHandler(this.BtnCreateProfile_Click);
            // 
            // browserProfileDataGridView
            // 
            this.browserProfileDataGridView.AllowUserToAddRows = false;
            this.browserProfileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserProfileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.userTabPage.Controls.Add(this.userTableLayoutPanel);
            this.userTabPage.Location = new System.Drawing.Point(4, 24);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(1220, 327);
            this.userTabPage.TabIndex = 1;
            this.userTabPage.Text = "Users";
            this.userTabPage.UseVisualStyleBackColor = true;
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 1;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userTableLayoutPanel.Controls.Add(this.userDataGridView, 0, 1);
            this.userTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 3;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(1214, 321);
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
            this.userDataGridView.Location = new System.Drawing.Point(3, 35);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(1208, 250);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            this.userDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.UserDataGridView_UserDeletingRow);
            // 
            // profileGroupTabPage
            // 
            this.profileGroupTabPage.Controls.Add(this.profileGroupTableLayoutPanel);
            this.profileGroupTabPage.Location = new System.Drawing.Point(4, 24);
            this.profileGroupTabPage.Name = "profileGroupTabPage";
            this.profileGroupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileGroupTabPage.Size = new System.Drawing.Size(1220, 327);
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
            this.profileGroupTableLayoutPanel.Size = new System.Drawing.Size(1214, 321);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserProfileDataGridView)).EndInit();
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
        private System.Windows.Forms.Button btnCreateProfile;
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
    }
}
