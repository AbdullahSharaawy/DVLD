namespace DVLD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btApplications = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.btAccountSettings = new System.Windows.Forms.Button();
            this.btManagePeople = new System.Windows.Forms.Button();
            this.cmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgPeople = new System.Windows.Forms.DataGridView();
            this.cmsGridData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFilter = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.cbFilterItems = new System.Windows.Forms.ComboBox();
            this.tbSelectorItem = new System.Windows.Forms.TextBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cmsAccountSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).BeginInit();
            this.cmsGridData.SuspendLayout();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btApplications);
            this.panel1.Controls.Add(this.btUsers);
            this.panel1.Controls.Add(this.btAccountSettings);
            this.panel1.Controls.Add(this.btManagePeople);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 87);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // btApplications
            // 
            this.btApplications.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btApplications.BackgroundImage")));
            this.btApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btApplications.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btApplications.Location = new System.Drawing.Point(10, 0);
            this.btApplications.Name = "btApplications";
            this.btApplications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btApplications.Size = new System.Drawing.Size(200, 87);
            this.btApplications.TabIndex = 3;
            this.btApplications.Text = "Applications";
            this.btApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btApplications.UseVisualStyleBackColor = true;
            this.btApplications.Click += new System.EventHandler(this.btApplications_Click);
            // 
            // btUsers
            // 
            this.btUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUsers.BackgroundImage")));
            this.btUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.Location = new System.Drawing.Point(529, 0);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(105, 87);
            this.btUsers.TabIndex = 2;
            this.btUsers.Text = "Users";
            this.btUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btAccountSettings
            // 
            this.btAccountSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAccountSettings.BackgroundImage")));
            this.btAccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAccountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccountSettings.Location = new System.Drawing.Point(651, 0);
            this.btAccountSettings.Name = "btAccountSettings";
            this.btAccountSettings.Size = new System.Drawing.Size(186, 87);
            this.btAccountSettings.TabIndex = 1;
            this.btAccountSettings.Text = "Account Settings";
            this.btAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAccountSettings.UseVisualStyleBackColor = true;
            this.btAccountSettings.Click += new System.EventHandler(this.btAccountSettings_Click);
            // 
            // btManagePeople
            // 
            this.btManagePeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btManagePeople.BackgroundImage")));
            this.btManagePeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManagePeople.Location = new System.Drawing.Point(324, 0);
            this.btManagePeople.Name = "btManagePeople";
            this.btManagePeople.Size = new System.Drawing.Size(163, 87);
            this.btManagePeople.TabIndex = 0;
            this.btManagePeople.Text = "People";
            this.btManagePeople.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btManagePeople.UseVisualStyleBackColor = true;
            this.btManagePeople.Click += new System.EventHandler(this.btManagePeople_Click);
            this.btManagePeople.MouseHover += new System.EventHandler(this.btManagePeople_MouseHover);
            // 
            // cmsAccountSettings
            // 
            this.cmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator3,
            this.signOutToolStripMenuItem});
            this.cmsAccountSettings.Name = "cmsAccountSettings";
            this.cmsAccountSettings.Size = new System.Drawing.Size(200, 82);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userInfoToolStripMenuItem.Image")));
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // dgPeople
            // 
            this.dgPeople.AllowUserToAddRows = false;
            this.dgPeople.AllowUserToDeleteRows = false;
            this.dgPeople.AllowUserToOrderColumns = true;
            this.dgPeople.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeople.ContextMenuStrip = this.cmsGridData;
            this.dgPeople.Location = new System.Drawing.Point(2, 143);
            this.dgPeople.Name = "dgPeople";
            this.dgPeople.ReadOnly = true;
            this.dgPeople.Size = new System.Drawing.Size(1406, 318);
            this.dgPeople.TabIndex = 1;
            this.dgPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeople_CellContentClick);
            // 
            // cmsGridData
            // 
            this.cmsGridData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.tsmiEdit,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsGridData.Name = "cmsGridData";
            this.cmsGridData.Size = new System.Drawing.Size(163, 148);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "ShowDetails";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(162, 22);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.BackColor = System.Drawing.Color.White;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(12, 120);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(73, 20);
            this.lbFilter.TabIndex = 2;
            this.lbFilter.Text = "Filter by";
            this.lbFilter.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(1265, 477);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 31);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Visible = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbFilterItems
            // 
            this.cbFilterItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbFilterItems.FormattingEnabled = true;
            this.cbFilterItems.Items.AddRange(new object[] {
            "None",
            "All People",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilterItems.Location = new System.Drawing.Point(91, 120);
            this.cbFilterItems.Name = "cbFilterItems";
            this.cbFilterItems.Size = new System.Drawing.Size(121, 21);
            this.cbFilterItems.TabIndex = 0;
            this.cbFilterItems.Visible = false;
            this.cbFilterItems.SelectedIndexChanged += new System.EventHandler(this.cbFilterItems_SelectedIndexChanged);
            // 
            // tbSelectorItem
            // 
            this.tbSelectorItem.Location = new System.Drawing.Point(232, 120);
            this.tbSelectorItem.Name = "tbSelectorItem";
            this.tbSelectorItem.ReadOnly = true;
            this.tbSelectorItem.Size = new System.Drawing.Size(139, 20);
            this.tbSelectorItem.TabIndex = 5;
            this.tbSelectorItem.Visible = false;
            this.tbSelectorItem.TextChanged += new System.EventHandler(this.tbSelectorItem_TextChanged);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(12, 477);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(0, 20);
            this.lbRecords.TabIndex = 6;
            this.lbRecords.Visible = false;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.toolStripSeparator4,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripSeparator5,
            this.detainLicenceToolStripMenuItem,
            this.toolStripSeparator6,
            this.manageApplicationTypesToolStripMenuItem,
            this.toolStripSeparator7,
            this.manageTestTypesToolStripMenuItem});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(261, 170);
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewDrivingLicense,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.drivingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingToolStripMenuItem.Image")));
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.drivingToolStripMenuItem.Text = "Driving Licences Services";
            this.drivingToolStripMenuItem.Click += new System.EventHandler(this.drivingToolStripMenuItem_Click);
            // 
            // tsmiNewDrivingLicense
            // 
            this.tsmiNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalLicense,
            this.tsmiInternationalLicense});
            this.tsmiNewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewDrivingLicense.Image")));
            this.tsmiNewDrivingLicense.Name = "tsmiNewDrivingLicense";
            this.tsmiNewDrivingLicense.Size = new System.Drawing.Size(221, 24);
            this.tsmiNewDrivingLicense.Text = "New Driving License";
            // 
            // tsmiLocalLicense
            // 
            this.tsmiLocalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLocalLicense.Image")));
            this.tsmiLocalLicense.Name = "tsmiLocalLicense";
            this.tsmiLocalLicense.Size = new System.Drawing.Size(224, 24);
            this.tsmiLocalLicense.Text = "Local License";
            this.tsmiLocalLicense.Click += new System.EventHandler(this.tsNewLocalLicense_Click);
            // 
            // tsmiInternationalLicense
            // 
            this.tsmiInternationalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInternationalLicense.Image")));
            this.tsmiInternationalLicense.Name = "tsmiInternationalLicense";
            this.tsmiInternationalLicense.Size = new System.Drawing.Size(224, 24);
            this.tsmiInternationalLicense.Text = "International License";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 24);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(221, 24);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localDrivingLicenseApplicationsToolStripMenuItem.Image")));
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseApplicationsToolStripMenuItem.Image")));
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(257, 6);
            // 
            // detainLicenceToolStripMenuItem
            // 
            this.detainLicenceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainLicenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicenceToolStripMenuItem.Image")));
            this.detainLicenceToolStripMenuItem.Name = "detainLicenceToolStripMenuItem";
            this.detainLicenceToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.detainLicenceToolStripMenuItem.Text = "Detain Licence";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(257, 6);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem.Image")));
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(257, 6);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdd.BackgroundImage")));
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(1282, 93);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(92, 44);
            this.btAdd.TabIndex = 7;
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseHover += new System.EventHandler(this.btAdd_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1407, 543);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.tbSelectorItem);
            this.Controls.Add(this.cbFilterItems);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dgPeople);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.cmsAccountSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).EndInit();
            this.cmsGridData.ResumeLayout(false);
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btManagePeople;
        private System.Windows.Forms.DataGridView dgPeople;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cbFilterItems;
        private System.Windows.Forms.TextBox tbSelectorItem;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ContextMenuStrip cmsGridData;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btAccountSettings;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btApplications;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem detainLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

