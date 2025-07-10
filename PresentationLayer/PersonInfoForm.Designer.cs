namespace DVLD
{
    partial class PersonInfoForm
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
            this.personInfo1 = new DVLD.PersonInfo();
            this.SuspendLayout();
            // 
            // personInfo1
            // 
            this.personInfo1.Location = new System.Drawing.Point(1, 0);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(844, 332);
            this.personInfo1.TabIndex = 0;
            // 
            // PersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 328);
            this.Controls.Add(this.personInfo1);
            this.Name = "PersonInfoForm";
            this.Text = "PersonInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
    }
}