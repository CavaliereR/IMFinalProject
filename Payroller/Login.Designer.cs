﻿namespace Payroller
{
    partial class LogIn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 126);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Enter username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(9, 159);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Enter password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(197, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(197, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 42);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 266);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LogIn";
            Text = "Login Sccreen";
            TopMost = true;
            Load += Passwordscreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
