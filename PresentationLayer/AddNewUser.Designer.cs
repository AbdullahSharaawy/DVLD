namespace DVLD
{
    partial class AddNewUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.lbAddNewUser = new System.Windows.Forms.Label();
            this.tcAddNewUser = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btAddNewPerson = new System.Windows.Forms.PictureBox();
            this.btNext = new System.Windows.Forms.Button();
            this.filterPeople1 = new DVLD.AddNewUser_Filter();
            this.personInfo1 = new DVLD.PersonInfo();
            this.tpLogInInfo = new System.Windows.Forms.TabPage();
            this.cbItemsClasses = new System.Windows.Forms.ComboBox();
            this.lbAppID = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbFeesPaid = new System.Windows.Forms.Label();
            this.lbWhoCreated = new System.Windows.Forms.Label();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.pbAppID = new System.Windows.Forms.PictureBox();
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.lbCreated = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbLicenseClass = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.pbUserID = new System.Windows.Forms.PictureBox();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbConfirmPass = new System.Windows.Forms.PictureBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.epAddNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcAddNewUser.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btAddNewPerson)).BeginInit();
            this.tpLogInInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddNewUser
            // 
            this.lbAddNewUser.AutoSize = true;
            this.lbAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewUser.ForeColor = System.Drawing.Color.Red;
            this.lbAddNewUser.Location = new System.Drawing.Point(289, 29);
            this.lbAddNewUser.Name = "lbAddNewUser";
            this.lbAddNewUser.Size = new System.Drawing.Size(201, 31);
            this.lbAddNewUser.TabIndex = 0;
            this.lbAddNewUser.Text = "Add New User";
            // 
            // tcAddNewUser
            // 
            this.tcAddNewUser.Controls.Add(this.tpPersonInfo);
            this.tcAddNewUser.Controls.Add(this.tpLogInInfo);
            this.tcAddNewUser.Location = new System.Drawing.Point(10, 85);
            this.tcAddNewUser.Name = "tcAddNewUser";
            this.tcAddNewUser.SelectedIndex = 0;
            this.tcAddNewUser.Size = new System.Drawing.Size(855, 501);
            this.tcAddNewUser.TabIndex = 2;
            this.tcAddNewUser.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAddNewUser_Selecting);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btAddNewPerson);
            this.tpPersonInfo.Controls.Add(this.btNext);
            this.tpPersonInfo.Controls.Add(this.filterPeople1);
            this.tpPersonInfo.Controls.Add(this.personInfo1);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(847, 475);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btAddNewPerson
            // 
            this.btAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btAddNewPerson.Image")));
            this.btAddNewPerson.Location = new System.Drawing.Point(783, 38);
            this.btAddNewPerson.Name = "btAddNewPerson";
            this.btAddNewPerson.Size = new System.Drawing.Size(36, 37);
            this.btAddNewPerson.TabIndex = 3;
            this.btAddNewPerson.TabStop = false;
            this.btAddNewPerson.Click += new System.EventHandler(this.btAddNewPerson_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNext.Location = new System.Drawing.Point(734, 419);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(85, 35);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // filterPeople1
            // 
            this.filterPeople1.Location = new System.Drawing.Point(6, 38);
            this.filterPeople1.Name = "filterPeople1";
            this.filterPeople1.Size = new System.Drawing.Size(375, 37);
            this.filterPeople1.TabIndex = 1;
            // 
            // personInfo1
            // 
            this.personInfo1.Location = new System.Drawing.Point(0, 81);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(844, 332);
            this.personInfo1.TabIndex = 0;
            // 
            // tpLogInInfo
            // 
            this.tpLogInInfo.Controls.Add(this.cbItemsClasses);
            this.tpLogInInfo.Controls.Add(this.lbAppID);
            this.tpLogInInfo.Controls.Add(this.lbDate);
            this.tpLogInInfo.Controls.Add(this.lbFeesPaid);
            this.tpLogInInfo.Controls.Add(this.lbWhoCreated);
            this.tpLogInInfo.Controls.Add(this.pbCreatedBy);
            this.tpLogInInfo.Controls.Add(this.pbAppID);
            this.tpLogInInfo.Controls.Add(this.pbDate);
            this.tpLogInInfo.Controls.Add(this.pbLicenseClass);
            this.tpLogInInfo.Controls.Add(this.pbFees);
            this.tpLogInInfo.Controls.Add(this.lbCreated);
            this.tpLogInInfo.Controls.Add(this.lbApplicationFees);
            this.tpLogInInfo.Controls.Add(this.lbLicenseClass);
            this.tpLogInInfo.Controls.Add(this.lbApplicationDate);
            this.tpLogInInfo.Controls.Add(this.lbApplicationID);
            this.tpLogInInfo.Controls.Add(this.btSave);
            this.tpLogInInfo.Controls.Add(this.cbIsActive);
            this.tpLogInInfo.Controls.Add(this.tbConfirmPass);
            this.tpLogInInfo.Controls.Add(this.tbPass);
            this.tpLogInInfo.Controls.Add(this.tbUserName);
            this.tpLogInInfo.Controls.Add(this.lbUserID);
            this.tpLogInInfo.Controls.Add(this.pbUserID);
            this.tpLogInInfo.Controls.Add(this.pbUserName);
            this.tpLogInInfo.Controls.Add(this.pbPass);
            this.tpLogInInfo.Controls.Add(this.pbConfirmPass);
            this.tpLogInInfo.Controls.Add(this.lbConfirmPass);
            this.tpLogInInfo.Controls.Add(this.lbPass);
            this.tpLogInInfo.Controls.Add(this.lbName);
            this.tpLogInInfo.Controls.Add(this.lbID);
            this.tpLogInInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLogInInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLogInInfo.Name = "tpLogInInfo";
            this.tpLogInInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogInInfo.Size = new System.Drawing.Size(847, 475);
            this.tpLogInInfo.TabIndex = 1;
            this.tpLogInInfo.Text = "LogIn Info";
            this.tpLogInInfo.UseVisualStyleBackColor = true;
            // 
            // cbItemsClasses
            // 
            this.cbItemsClasses.FormattingEnabled = true;
            this.cbItemsClasses.Location = new System.Drawing.Point(350, 193);
            this.cbItemsClasses.Name = "cbItemsClasses";
            this.cbItemsClasses.Size = new System.Drawing.Size(210, 24);
            this.cbItemsClasses.TabIndex = 27;
            this.cbItemsClasses.SelectedIndexChanged += new System.EventHandler(this.cbItemsClasses_SelectedIndexChanged);
            // 
            // lbAppID
            // 
            this.lbAppID.AutoSize = true;
            this.lbAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppID.Location = new System.Drawing.Point(345, 88);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(51, 25);
            this.lbAppID.TabIndex = 26;
            this.lbAppID.Text = "???";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(345, 142);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(51, 25);
            this.lbDate.TabIndex = 25;
            this.lbDate.Text = "???";
            // 
            // lbFeesPaid
            // 
            this.lbFeesPaid.AutoSize = true;
            this.lbFeesPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesPaid.Location = new System.Drawing.Point(345, 245);
            this.lbFeesPaid.Name = "lbFeesPaid";
            this.lbFeesPaid.Size = new System.Drawing.Size(51, 25);
            this.lbFeesPaid.TabIndex = 24;
            this.lbFeesPaid.Text = "???";
            // 
            // lbWhoCreated
            // 
            this.lbWhoCreated.AutoSize = true;
            this.lbWhoCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhoCreated.Location = new System.Drawing.Point(345, 296);
            this.lbWhoCreated.Name = "lbWhoCreated";
            this.lbWhoCreated.Size = new System.Drawing.Size(51, 25);
            this.lbWhoCreated.TabIndex = 23;
            this.lbWhoCreated.Text = "???";
            // 
            // pbCreatedBy
            // 
            this.pbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("pbCreatedBy.Image")));
            this.pbCreatedBy.Location = new System.Drawing.Point(269, 290);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(43, 31);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedBy.TabIndex = 22;
            this.pbCreatedBy.TabStop = false;
            // 
            // pbAppID
            // 
            this.pbAppID.Image = ((System.Drawing.Image)(resources.GetObject("pbAppID.Image")));
            this.pbAppID.Location = new System.Drawing.Point(272, 79);
            this.pbAppID.Name = "pbAppID";
            this.pbAppID.Size = new System.Drawing.Size(40, 34);
            this.pbAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppID.TabIndex = 21;
            this.pbAppID.TabStop = false;
            // 
            // pbDate
            // 
            this.pbDate.Image = ((System.Drawing.Image)(resources.GetObject("pbDate.Image")));
            this.pbDate.Location = new System.Drawing.Point(272, 142);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(40, 24);
            this.pbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDate.TabIndex = 20;
            this.pbDate.TabStop = false;
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("pbLicenseClass.Image")));
            this.pbLicenseClass.Location = new System.Drawing.Point(269, 186);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(43, 32);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 19;
            this.pbLicenseClass.TabStop = false;
            // 
            // pbFees
            // 
            this.pbFees.Image = ((System.Drawing.Image)(resources.GetObject("pbFees.Image")));
            this.pbFees.Location = new System.Drawing.Point(269, 239);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(43, 31);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 18;
            this.pbFees.TabStop = false;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.Location = new System.Drawing.Point(48, 296);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(136, 25);
            this.lbCreated.TabIndex = 17;
            this.lbCreated.Text = "Created By:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(48, 244);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(195, 25);
            this.lbApplicationFees.TabIndex = 16;
            this.lbApplicationFees.Text = "Application Fees:";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.AutoSize = true;
            this.lbLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClass.Location = new System.Drawing.Point(48, 192);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(167, 25);
            this.lbLicenseClass.TabIndex = 15;
            this.lbLicenseClass.Text = "License Class:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(48, 141);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(192, 25);
            this.lbApplicationDate.TabIndex = 14;
            this.lbApplicationDate.Text = "Application Date:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(48, 88);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(208, 25);
            this.lbApplicationID.TabIndex = 13;
            this.lbApplicationID.Text = "D.L.Application ID:";
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(726, 417);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(97, 36);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(243, 315);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(85, 20);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(339, 248);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(168, 22);
            this.tbConfirmPass.TabIndex = 11;
            this.tbConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConfirmPass_KeyPress);
            this.tbConfirmPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPass_Validating);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(339, 196);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(168, 22);
            this.tbPass.TabIndex = 10;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            this.tbPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass_Validating);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(339, 142);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(168, 22);
            this.tbUserName.TabIndex = 9;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(334, 88);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(51, 25);
            this.lbUserID.TabIndex = 8;
            this.lbUserID.Text = "???";
            // 
            // pbUserID
            // 
            this.pbUserID.Image = ((System.Drawing.Image)(resources.GetObject("pbUserID.Image")));
            this.pbUserID.Location = new System.Drawing.Point(246, 79);
            this.pbUserID.Name = "pbUserID";
            this.pbUserID.Size = new System.Drawing.Size(40, 34);
            this.pbUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserID.TabIndex = 7;
            this.pbUserID.TabStop = false;
            // 
            // pbUserName
            // 
            this.pbUserName.Image = ((System.Drawing.Image)(resources.GetObject("pbUserName.Image")));
            this.pbUserName.Location = new System.Drawing.Point(246, 142);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(40, 24);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserName.TabIndex = 6;
            this.pbUserName.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.Image = ((System.Drawing.Image)(resources.GetObject("pbPass.Image")));
            this.pbPass.Location = new System.Drawing.Point(243, 186);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(51, 42);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPass.TabIndex = 5;
            this.pbPass.TabStop = false;
            // 
            // pbConfirmPass
            // 
            this.pbConfirmPass.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmPass.Image")));
            this.pbConfirmPass.Location = new System.Drawing.Point(243, 239);
            this.pbConfirmPass.Name = "pbConfirmPass";
            this.pbConfirmPass.Size = new System.Drawing.Size(51, 42);
            this.pbConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmPass.TabIndex = 4;
            this.pbConfirmPass.TabStop = false;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.Location = new System.Drawing.Point(23, 245);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(202, 25);
            this.lbConfirmPass.TabIndex = 3;
            this.lbConfirmPass.Text = "Confirm Password";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(111, 192);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(114, 25);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(97, 142);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(128, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "User Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(135, 88);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(90, 25);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "User ID";
            // 
            // epAddNewUser
            // 
            this.epAddNewUser.ContainerControl = this;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcAddNewUser);
            this.Controls.Add(this.lbAddNewUser);
            this.Name = "AddNewUser";
            this.Size = new System.Drawing.Size(866, 649);
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.tcAddNewUser.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btAddNewPerson)).EndInit();
            this.tpLogInInfo.ResumeLayout(false);
            this.tpLogInInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddNewUser;
        private System.Windows.Forms.TabControl tcAddNewUser;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpLogInInfo;
        private PersonInfo personInfo1;
        private AddNewUser_Filter filterPeople1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox pbUserID;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbConfirmPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.ErrorProvider epAddNewUser;
        private System.Windows.Forms.PictureBox btAddNewPerson;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbLicenseClass;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbFeesPaid;
        private System.Windows.Forms.Label lbWhoCreated;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private System.Windows.Forms.PictureBox pbAppID;
        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.ComboBox cbItemsClasses;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label lbDate;
    }
}
