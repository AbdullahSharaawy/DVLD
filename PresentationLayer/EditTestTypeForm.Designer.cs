namespace DVLD
{
    partial class EditTestTypeForm
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
            this.editTestType1 = new DVLD.EditTestType();
            this.SuspendLayout();
            // 
            // editTestType1
            // 
            this.editTestType1.Location = new System.Drawing.Point(0, 6);
            this.editTestType1.Name = "editTestType1";
            this.editTestType1.Size = new System.Drawing.Size(451, 269);
            this.editTestType1.TabIndex = 0;
            // 
            // EditTestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 279);
            this.Controls.Add(this.editTestType1);
            this.Name = "EditTestTypeForm";
            this.Text = "EditTestType";
            this.ResumeLayout(false);

        }

        #endregion

        private EditTestType editTestType1;
    }
}