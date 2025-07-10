namespace DVLD
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label2 = new System.Windows.Forms.Label();
            this.epLogIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.btLogIn = new System.Windows.Forms.Button();
            this.pLogIn = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbRemeberMe = new System.Windows.Forms.CheckBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epLogIn)).BeginInit();
            this.pLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "LogIn to your account";
            // 
            // epLogIn
            // 
            this.epLogIn.ContainerControl = this;
            // 
            // btLogIn
            // 
            this.btLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(318, 325);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 26);
            this.btLogIn.TabIndex = 11;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // pLogIn
            // 
            this.pLogIn.Controls.Add(this.pictureBox2);
            this.pLogIn.Controls.Add(this.pictureBox1);
            this.pLogIn.Controls.Add(this.cbRemeberMe);
            this.pLogIn.Controls.Add(this.cbShowPass);
            this.pLogIn.Controls.Add(this.lbPassword);
            this.pLogIn.Controls.Add(this.tbPass);
            this.pLogIn.Controls.Add(this.lbUserName);
            this.pLogIn.Controls.Add(this.tbUserName);
            this.pLogIn.Location = new System.Drawing.Point(12, 78);
            this.pLogIn.Name = "pLogIn";
            this.pLogIn.Size = new System.Drawing.Size(429, 214);
            this.pLogIn.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(150, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(150, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cbRemeberMe
            // 
            this.cbRemeberMe.AutoSize = true;
            this.cbRemeberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRemeberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemeberMe.Location = new System.Drawing.Point(152, 149);
            this.cbRemeberMe.Name = "cbRemeberMe";
            this.cbRemeberMe.Size = new System.Drawing.Size(115, 20);
            this.cbRemeberMe.TabIndex = 19;
            this.cbRemeberMe.Text = "Remeber Me";
            this.cbRemeberMe.UseVisualStyleBackColor = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPass.Location = new System.Drawing.Point(152, 175);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(149, 22);
            this.cbShowPass.TabIndex = 20;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(23, 78);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 24);
            this.lbPassword.TabIndex = 18;
            this.lbPassword.Text = "Password";
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(189, 78);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(216, 22);
            this.tbPass.TabIndex = 17;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(24, 18);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(114, 24);
            this.lbUserName.TabIndex = 16;
            this.lbUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(189, 18);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(216, 22);
            this.tbUserName.TabIndex = 15;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(476, 381);
            this.Controls.Add(this.pLogIn);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.label2);
            this.Name = "LogIn";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epLogIn)).EndInit();
            this.pLogIn.ResumeLayout(false);
            this.pLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epLogIn;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Panel pLogIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbRemeberMe;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
    }
}