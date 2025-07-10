namespace DVLD
{
    partial class EditApplicationTypeForm
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
            this.editApplicationTypes1 = new DVLD.EditApplicationType();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editApplicationTypes1
            // 
            this.editApplicationTypes1.Location = new System.Drawing.Point(3, 1);
            this.editApplicationTypes1.Name = "editApplicationTypes1";
            this.editApplicationTypes1.Size = new System.Drawing.Size(414, 226);
            this.editApplicationTypes1.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(243, 189);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // EditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 234);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.editApplicationTypes1);
            this.Name = "EditApplicationType";
            this.Text = "EditApplicationType";
            this.ResumeLayout(false);

        }

        #endregion

        private EditApplicationType editApplicationTypes1;
        private System.Windows.Forms.Button btClose;
    }
}