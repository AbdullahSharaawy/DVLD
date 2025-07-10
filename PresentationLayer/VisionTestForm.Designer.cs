namespace DVLD
{
    partial class VisionTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionTestForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.visionTest1 = new DVLD.VisionTest();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(727, 746);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // visionTest1
            // 
            this.visionTest1.Location = new System.Drawing.Point(2, 3);
            this.visionTest1.Name = "visionTest1";
            this.visionTest1.Size = new System.Drawing.Size(1030, 794);
            this.visionTest1.TabIndex = 11;
            this.visionTest1.Load += new System.EventHandler(this.visionTest1_Load);
            // 
            // VisionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 812);
            this.Controls.Add(this.visionTest1);
            this.Controls.Add(this.btnCancel);
            this.Name = "VisionTestForm";
            this.Text = "VisionTestForm";
            this.Load += new System.EventHandler(this.VisionTestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private VisionTest visionTest1;
    }
}