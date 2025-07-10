namespace DVLD
{
    partial class ManageApplicationType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageApplicationType));
            this.label1 = new System.Windows.Forms.Label();
            this.dgManageApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cmsEditApplicationType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgManageApplicationTypes)).BeginInit();
            this.cmsEditApplicationType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Application Types";
            // 
            // dgManageApplicationTypes
            // 
            this.dgManageApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgManageApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManageApplicationTypes.ContextMenuStrip = this.cmsEditApplicationType;
            this.dgManageApplicationTypes.Location = new System.Drawing.Point(0, 235);
            this.dgManageApplicationTypes.Name = "dgManageApplicationTypes";
            this.dgManageApplicationTypes.Size = new System.Drawing.Size(498, 225);
            this.dgManageApplicationTypes.TabIndex = 2;
            // 
            // cmsEditApplicationType
            // 
            this.cmsEditApplicationType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditApplicationType.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsEditApplicationType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.cmsEditApplicationType.Name = "cmsEditApplicationType";
            this.cmsEditApplicationType.Size = new System.Drawing.Size(218, 36);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationTypeToolStripMenuItem.Image")));
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(217, 32);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // lbRecordsNo
            // 
            this.lbRecordsNo.AutoSize = true;
            this.lbRecordsNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsNo.Location = new System.Drawing.Point(3, 482);
            this.lbRecordsNo.Name = "lbRecordsNo";
            this.lbRecordsNo.Size = new System.Drawing.Size(110, 18);
            this.lbRecordsNo.TabIndex = 3;
            this.lbRecordsNo.Text = "# Records No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(129, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManageApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRecordsNo);
            this.Controls.Add(this.dgManageApplicationTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageApplicationType";
            this.Size = new System.Drawing.Size(498, 526);
            this.Load += new System.EventHandler(this.ManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManageApplicationTypes)).EndInit();
            this.cmsEditApplicationType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgManageApplicationTypes;
        private System.Windows.Forms.Label lbRecordsNo;
        private System.Windows.Forms.ContextMenuStrip cmsEditApplicationType;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}
