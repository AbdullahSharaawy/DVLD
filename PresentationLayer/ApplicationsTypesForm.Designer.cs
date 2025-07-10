namespace DVLD
{
    partial class ApplicationsTypesForm
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
            this.manageApplicationTypes1 = new DVLD.ManageApplicationType();
            this.SuspendLayout();
            // 
            // manageApplicationTypes1
            // 
            this.manageApplicationTypes1.BackColor = System.Drawing.Color.White;
            this.manageApplicationTypes1.Location = new System.Drawing.Point(0, 0);
            this.manageApplicationTypes1.Name = "manageApplicationTypes1";
            this.manageApplicationTypes1.Size = new System.Drawing.Size(498, 526);
            this.manageApplicationTypes1.TabIndex = 0;
            // 
            // ApplicationsTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 530);
            this.Controls.Add(this.manageApplicationTypes1);
            this.Name = "ApplicationsTypesForm";
            this.Text = "ApplicationsTypesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ManageApplicationType manageApplicationTypes1;
    }
}