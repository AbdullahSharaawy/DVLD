namespace DVLD
{
    partial class AddNewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserForm));
            this.btClose = new System.Windows.Forms.Button();
            this.addNewUser1 = new DVLD.AddNewUser();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(634, 537);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(97, 36);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // addNewUser1
            // 
            this.addNewUser1.Location = new System.Drawing.Point(8, 12);
            this.addNewUser1.Name = "addNewUser1";
            this.addNewUser1.Size = new System.Drawing.Size(866, 649);
            this.addNewUser1.TabIndex = 0;
            this.addNewUser1.Load += new System.EventHandler(this.addNewUser1_Load);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 684);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.addNewUser1);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private AddNewUser addNewUser1;
    }
}