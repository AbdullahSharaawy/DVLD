namespace DVLD
{
    partial class VisionTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionTest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNoRecords = new System.Windows.Forms.Label();
            this.drivingLicenseApplicationInfo1 = new DVLD.DrivingLicenseApplicationInfo();
            this.applicationBasicInfo1 = new DVLD.ApplicationBasicInfo();
            this.btnAddAppoinment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(332, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vision Test Appoinments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appoinmetns :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 612);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(985, 126);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 757);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "# Records";
            // 
            // lbNoRecords
            // 
            this.lbNoRecords.AutoSize = true;
            this.lbNoRecords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoRecords.Location = new System.Drawing.Point(112, 757);
            this.lbNoRecords.Name = "lbNoRecords";
            this.lbNoRecords.Size = new System.Drawing.Size(35, 18);
            this.lbNoRecords.TabIndex = 8;
            this.lbNoRecords.Text = "???";
            // 
            // drivingLicenseApplicationInfo1
            // 
            this.drivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 177);
            this.drivingLicenseApplicationInfo1.Name = "drivingLicenseApplicationInfo1";
            this.drivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1015, 150);
            this.drivingLicenseApplicationInfo1.TabIndex = 10;
            // 
            // applicationBasicInfo1
            // 
            this.applicationBasicInfo1.Location = new System.Drawing.Point(3, 333);
            this.applicationBasicInfo1.Name = "applicationBasicInfo1";
            this.applicationBasicInfo1.Size = new System.Drawing.Size(1012, 229);
            this.applicationBasicInfo1.TabIndex = 9;
            // 
            // btnAddAppoinment
            // 
            this.btnAddAppoinment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAppoinment.BackgroundImage")));
            this.btnAddAppoinment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppoinment.Location = new System.Drawing.Point(939, 568);
            this.btnAddAppoinment.Name = "btnAddAppoinment";
            this.btnAddAppoinment.Size = new System.Drawing.Size(61, 38);
            this.btnAddAppoinment.TabIndex = 5;
            this.btnAddAppoinment.UseVisualStyleBackColor = true;
            this.btnAddAppoinment.Click += new System.EventHandler(this.btnAddAppoinment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // VisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drivingLicenseApplicationInfo1);
            this.Controls.Add(this.applicationBasicInfo1);
            this.Controls.Add(this.lbNoRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddAppoinment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VisionTest";
            this.Size = new System.Drawing.Size(1030, 794);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppoinment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNoRecords;
        private ApplicationBasicInfo applicationBasicInfo1;
        private DrivingLicenseApplicationInfo drivingLicenseApplicationInfo1;
    }
}
