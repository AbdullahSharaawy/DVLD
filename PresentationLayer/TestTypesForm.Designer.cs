namespace DVLD
{
    partial class TestTypesForm
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
            this.manageTestType1 = new DVLD.ManageTestType();
            this.SuspendLayout();
            // 
            // manageTestType1
            // 
            this.manageTestType1.Location = new System.Drawing.Point(0, 1);
            this.manageTestType1.Name = "manageTestType1";
            this.manageTestType1.Size = new System.Drawing.Size(593, 476);
            this.manageTestType1.TabIndex = 0;
            this.manageTestType1.Load += new System.EventHandler(this.manageTestType1_Load);
            // 
            // TestTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 479);
            this.Controls.Add(this.manageTestType1);
            this.Name = "TestTypesForm";
            this.Text = "TestTypesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ManageTestType manageTestType1;
    }
}