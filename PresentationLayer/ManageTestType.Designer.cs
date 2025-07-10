namespace DVLD
{
    partial class ManageTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTestType));
            this.lbRecordsNo = new System.Windows.Forms.Label();
            this.dgManageTestTypes = new System.Windows.Forms.DataGridView();
            this.cmsEditTestType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgManageTestTypes)).BeginInit();
            this.cmsEditTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordsNo
            // 
            this.lbRecordsNo.AutoSize = true;
            this.lbRecordsNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsNo.Location = new System.Drawing.Point(44, 448);
            this.lbRecordsNo.Name = "lbRecordsNo";
            this.lbRecordsNo.Size = new System.Drawing.Size(110, 18);
            this.lbRecordsNo.TabIndex = 7;
            this.lbRecordsNo.Text = "# Records No";
            // 
            // dgManageTestTypes
            // 
            this.dgManageTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgManageTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManageTestTypes.ContextMenuStrip = this.cmsEditTestType;
            this.dgManageTestTypes.Location = new System.Drawing.Point(3, 201);
            this.dgManageTestTypes.Name = "dgManageTestTypes";
            this.dgManageTestTypes.Size = new System.Drawing.Size(587, 225);
            this.dgManageTestTypes.TabIndex = 6;
            // 
            // cmsEditTestType
            // 
            this.cmsEditTestType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditTestType.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsEditTestType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.cmsEditTestType.Name = "cmsEditApplicationType";
            this.cmsEditTestType.Size = new System.Drawing.Size(172, 36);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationTypeToolStripMenuItem.Image")));
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(170, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 133);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbRecordsNo);
            this.Controls.Add(this.dgManageTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageTestType";
            this.Size = new System.Drawing.Size(593, 476);
            this.Load += new System.EventHandler(this.ManageTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManageTestTypes)).EndInit();
            this.cmsEditTestType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsNo;
        private System.Windows.Forms.DataGridView dgManageTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsEditTestType;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}
