namespace DVLD
{
    partial class UpdatePeopleForm
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
            this.updatePeople1 = new DVLD.UpdatePeople();
            this.SuspendLayout();
            // 
            // updatePeople1
            // 
            this.updatePeople1.Location = new System.Drawing.Point(3, 11);
            this.updatePeople1.Name = "updatePeople1";
            this.updatePeople1.Size = new System.Drawing.Size(912, 594);
            this.updatePeople1.TabIndex = 0;
           
            // 
            // UpdatePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 660);
           
            this.Name = "UpdatePeopleForm";
            this.Text = "UpdatePeopleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UpdatePeople updatePeople1;
    }
}