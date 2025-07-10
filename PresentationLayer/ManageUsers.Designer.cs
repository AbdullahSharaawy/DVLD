namespace DVLD
{
     partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.cmsManageUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbRecordsNo = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddNewUser = new System.Windows.Forms.Button();
            this.filterUsers1 = new DVLD.FilterUsers();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.cmsManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(400, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AllowUserToOrderColumns = true;
            this.dgUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.ContextMenuStrip = this.cmsManageUsers;
            this.dgUsers.Location = new System.Drawing.Point(32, 260);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.Size = new System.Drawing.Size(975, 204);
            this.dgUsers.TabIndex = 2;
            // 
            // cmsManageUsers
            // 
            this.cmsManageUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.changePToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.cmsManageUsers.Name = "contextMenuStrip1";
            this.cmsManageUsers.Size = new System.Drawing.Size(169, 170);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserToolStripMenuItem.Image")));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // changePToolStripMenuItem
            // 
            this.changePToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePToolStripMenuItem.Image")));
            this.changePToolStripMenuItem.Name = "changePToolStripMenuItem";
            this.changePToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePToolStripMenuItem.Text = "Change Password";
            this.changePToolStripMenuItem.Click += new System.EventHandler(this.changePToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callPhoneToolStripMenuItem.Image")));
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbRecordsNo
            // 
            this.lbRecordsNo.AutoSize = true;
            this.lbRecordsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsNo.Location = new System.Drawing.Point(29, 495);
            this.lbRecordsNo.Name = "lbRecordsNo";
            this.lbRecordsNo.Size = new System.Drawing.Size(94, 16);
            this.lbRecordsNo.TabIndex = 5;
            this.lbRecordsNo.Text = "Records No ";
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(920, 470);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(87, 38);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(406, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btAddNewUser.Image")));
            this.btAddNewUser.Location = new System.Drawing.Point(932, 182);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(75, 72);
            this.btAddNewUser.TabIndex = 6;
            this.btAddNewUser.UseVisualStyleBackColor = true;
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewUser_Click);
            // 
            // filterUsers1
            // 
            this.filterUsers1.Location = new System.Drawing.Point(32, 210);
            this.filterUsers1.Name = "filterUsers1";
            this.filterUsers1.Size = new System.Drawing.Size(352, 40);
            this.filterUsers1.TabIndex = 3;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.btAddNewUser);
            this.Controls.Add(this.lbRecordsNo);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.filterUsers1);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.cmsManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FilterUsers filterUsers1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbRecordsNo;
        private System.Windows.Forms.Button btAddNewUser;
        private System.Windows.Forms.ContextMenuStrip cmsManageUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changePToolStripMenuItem;
    }
}