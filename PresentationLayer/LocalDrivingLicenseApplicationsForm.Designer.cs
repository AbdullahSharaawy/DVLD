namespace DVLD
{
    partial class LocalDrivingLicenseApplicationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationsForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsLocalDrivingLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSechduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.secheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewLocalDrivingLicense = new System.Windows.Forms.Button();
            this.localDrivingLicenseApplications_Filter1 = new DVLD.Filter();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalDrivingLicenseApplications)).BeginInit();
            this.cmsLocalDrivingLicenseApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(675, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(295, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgLocalDrivingLicenseApplications
            // 
            this.dgLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dgLocalDrivingLicenseApplications.AllowUserToOrderColumns = true;
            this.dgLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsLocalDrivingLicenseApplications;
            this.dgLocalDrivingLicenseApplications.Location = new System.Drawing.Point(2, 362);
            this.dgLocalDrivingLicenseApplications.Name = "dgLocalDrivingLicenseApplications";
            this.dgLocalDrivingLicenseApplications.ReadOnly = true;
            this.dgLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1275, 299);
            this.dgLocalDrivingLicenseApplications.TabIndex = 3;
            this.dgLocalDrivingLicenseApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgLocalDrivingLicenseApplications_MouseDown);
            // 
            // cmsLocalDrivingLicenseApplications
            // 
            this.cmsLocalDrivingLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowApplicationDetails,
            this.toolStripSeparator1,
            this.tsmiEditApplication,
            this.tsmiDeleteApplication,
            this.toolStripSeparator2,
            this.tsmiCancelApplication,
            this.toolStripSeparator3,
            this.tsmiSechduleTest,
            this.toolStripSeparator4,
            this.tsmiIssueDrivingLicense,
            this.toolStripSeparator5,
            this.tsmiShowLicense,
            this.toolStripSeparator6,
            this.tsmiShowPersonLicenseHistory});
            this.cmsLocalDrivingLicenseApplications.Name = "contextMenuStrip1";
            this.cmsLocalDrivingLicenseApplications.Size = new System.Drawing.Size(243, 238);
            // 
            // tsmiShowApplicationDetails
            // 
            this.tsmiShowApplicationDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowApplicationDetails.Image")));
            this.tsmiShowApplicationDetails.Name = "tsmiShowApplicationDetails";
            this.tsmiShowApplicationDetails.Size = new System.Drawing.Size(242, 22);
            this.tsmiShowApplicationDetails.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiEditApplication
            // 
            this.tsmiEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditApplication.Image")));
            this.tsmiEditApplication.Name = "tsmiEditApplication";
            this.tsmiEditApplication.Size = new System.Drawing.Size(242, 22);
            this.tsmiEditApplication.Text = "Edit Application";
            // 
            // tsmiDeleteApplication
            // 
            this.tsmiDeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteApplication.Image")));
            this.tsmiDeleteApplication.Name = "tsmiDeleteApplication";
            this.tsmiDeleteApplication.Size = new System.Drawing.Size(242, 22);
            this.tsmiDeleteApplication.Text = "Delete Application";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiCancelApplication
            // 
            this.tsmiCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancelApplication.Image")));
            this.tsmiCancelApplication.Name = "tsmiCancelApplication";
            this.tsmiCancelApplication.Size = new System.Drawing.Size(242, 22);
            this.tsmiCancelApplication.Text = "Cancel Application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiSechduleTest
            // 
            this.tsmiSechduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secheduleVisionTestToolStripMenuItem,
            this.sechduleToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.tsmiSechduleTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSechduleTest.Image")));
            this.tsmiSechduleTest.Name = "tsmiSechduleTest";
            this.tsmiSechduleTest.Size = new System.Drawing.Size(242, 22);
            this.tsmiSechduleTest.Text = "Sechdule Test";
            // 
            // secheduleVisionTestToolStripMenuItem
            // 
            this.secheduleVisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("secheduleVisionTestToolStripMenuItem.Image")));
            this.secheduleVisionTestToolStripMenuItem.Name = "secheduleVisionTestToolStripMenuItem";
            this.secheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.secheduleVisionTestToolStripMenuItem.Text = "Sechedule Vision Test";
            this.secheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.secheduleVisionTestToolStripMenuItem_Click);
            // 
            // sechduleToolStripMenuItem
            // 
            this.sechduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleToolStripMenuItem.Image")));
            this.sechduleToolStripMenuItem.Name = "sechduleToolStripMenuItem";
            this.sechduleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sechduleToolStripMenuItem.Text = "Sechdule Written Test";
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleStreetTestToolStripMenuItem.Image")));
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiIssueDrivingLicense
            // 
            this.tsmiIssueDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiIssueDrivingLicense.Image")));
            this.tsmiIssueDrivingLicense.Name = "tsmiIssueDrivingLicense";
            this.tsmiIssueDrivingLicense.Size = new System.Drawing.Size(242, 22);
            this.tsmiIssueDrivingLicense.Text = "Issue Driving License(First Time)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLicense.Image")));
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(242, 22);
            this.tsmiShowLicense.Text = "Show License";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiShowPersonLicenseHistory
            // 
            this.tsmiShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowPersonLicenseHistory.Image")));
            this.tsmiShowPersonLicenseHistory.Name = "tsmiShowPersonLicenseHistory";
            this.tsmiShowPersonLicenseHistory.Size = new System.Drawing.Size(242, 22);
            this.tsmiShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // btNewLocalDrivingLicense
            // 
            this.btNewLocalDrivingLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNewLocalDrivingLicense.BackgroundImage")));
            this.btNewLocalDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNewLocalDrivingLicense.Location = new System.Drawing.Point(1160, 278);
            this.btNewLocalDrivingLicense.Name = "btNewLocalDrivingLicense";
            this.btNewLocalDrivingLicense.Size = new System.Drawing.Size(103, 78);
            this.btNewLocalDrivingLicense.TabIndex = 4;
            this.btNewLocalDrivingLicense.UseVisualStyleBackColor = true;
            this.btNewLocalDrivingLicense.Click += new System.EventHandler(this.btNewLocalDrivingLicense_Click);
            // 
            // localDrivingLicenseApplications_Filter1
            // 
            this.localDrivingLicenseApplications_Filter1.Location = new System.Drawing.Point(12, 319);
            this.localDrivingLicenseApplications_Filter1.Name = "localDrivingLicenseApplications_Filter1";
            this.localDrivingLicenseApplications_Filter1.Size = new System.Drawing.Size(375, 37);
            this.localDrivingLicenseApplications_Filter1.TabIndex = 5;
            this.localDrivingLicenseApplications_Filter1.evFilterResult += new System.EventHandler<System.Data.DataTable>(this.localDrivingLicenseApplications_Filter1_evFilterResult);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // LocalDrivingLicenseApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 661);
            this.Controls.Add(this.localDrivingLicenseApplications_Filter1);
            this.Controls.Add(this.btNewLocalDrivingLicense);
            this.Controls.Add(this.dgLocalDrivingLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LocalDrivingLicenseApplicationsForm";
            this.Text = "LocalDrivingLicenseApplicationsForm";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalDrivingLicenseApplications)).EndInit();
            this.cmsLocalDrivingLicenseApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLocalDrivingLicenseApplications;
        private System.Windows.Forms.Button btNewLocalDrivingLicense;
        private Filter localDrivingLicenseApplications_Filter1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem secheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
    }
}