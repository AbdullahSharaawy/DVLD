﻿namespace DVLD
{
    partial class NewLocalDrivingLicenseApplicationForm
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
            this.addNewUser1 = new DVLD.AddNewUser();
            this.SuspendLayout();
            // 
            // addNewUser1
            // 
            this.addNewUser1.Location = new System.Drawing.Point(-1, 3);
            this.addNewUser1.Name = "addNewUser1";
            this.addNewUser1.Size = new System.Drawing.Size(866, 649);
            this.addNewUser1.TabIndex = 0;
            // 
            // NewLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 656);
            this.Controls.Add(this.addNewUser1);
            this.Name = "NewLocalDrivingLicenseApplicationForm";
            this.Text = "NewLocalDrivingLicenseApplicationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AddNewUser addNewUser1;
    }
}