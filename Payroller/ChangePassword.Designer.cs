namespace Payroller
{
    partial class ChangePassword
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
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtOldPassword = new TextBox();
            label2 = new Label();
            txtEnterUsername = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(146, 92);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(150, 27);
            txtNewPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "New Password:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(146, 52);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(150, 27);
            txtOldPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 5;
            label2.Text = "Old Password:";
            // 
            // txtEnterUsername
            // 
            txtEnterUsername.Location = new Point(146, 12);
            txtEnterUsername.Name = "txtEnterUsername";
            txtEnterUsername.Size = new Size(150, 27);
            txtEnterUsername.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 9;
            label1.Text = "Enter Name:";
            // 
            // button1
            // 
            button1.Location = new Point(18, 141);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 141);
            button2.Name = "button2";
            button2.Size = new Size(110, 30);
            button2.TabIndex = 12;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 183);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEnterUsername);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(txtOldPassword);
            Controls.Add(label2);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtOldPassword;
        private Label label2;
        private TextBox txtEnterUsername;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}