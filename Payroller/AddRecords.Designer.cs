namespace Payroller
{
    partial class AddRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecords));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnAddRecord = new Button();
            picEmployeePhoto = new PictureBox();
            label4 = new Label();
            btnBrowseImage = new Button();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            txtPosition = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 139);
            label1.Name = "label1";
            label1.Size = new Size(97, 38);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 192);
            label2.Name = "label2";
            label2.Size = new Size(89, 38);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 240);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(344, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 43);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(344, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 43);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(344, 241);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(270, 43);
            txtPhoneNumber.TabIndex = 6;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRecord.Location = new Point(641, 388);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(133, 50);
            btnAddRecord.TabIndex = 8;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // picEmployeePhoto
            // 
            picEmployeePhoto.BackgroundImage = (Image)resources.GetObject("picEmployeePhoto.BackgroundImage");
            picEmployeePhoto.BackgroundImageLayout = ImageLayout.Stretch;
            picEmployeePhoto.Location = new Point(344, 2);
            picEmployeePhoto.Name = "picEmployeePhoto";
            picEmployeePhoto.Size = new Size(125, 122);
            picEmployeePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmployeePhoto.TabIndex = 9;
            picEmployeePhoto.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 86);
            label4.Name = "label4";
            label4.Size = new Size(225, 38);
            label4.TabIndex = 10;
            label4.Text = "Employee Photo:";
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowseImage.Location = new Point(475, 86);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(117, 38);
            btnBrowseImage.TabIndex = 11;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 288);
            label5.Name = "label5";
            label5.Size = new Size(148, 38);
            label5.TabIndex = 12;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 339);
            label6.Name = "label6";
            label6.Size = new Size(138, 38);
            label6.TabIndex = 13;
            label6.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(344, 339);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 43);
            txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(344, 290);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 43);
            txtUsername.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 388);
            label7.Name = "label7";
            label7.Size = new Size(121, 38);
            label7.TabIndex = 16;
            label7.Text = "Position:";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(344, 388);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(270, 43);
            txtPosition.TabIndex = 17;
            // 
            // AddRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPosition);
            Controls.Add(label7);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBrowseImage);
            Controls.Add(label4);
            Controls.Add(picEmployeePhoto);
            Controls.Add(btnAddRecord);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRecords";
            Text = "AddRecords";
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnAddRecord;
        private PictureBox picEmployeePhoto;
        private Label label4;
        private Button btnBrowseImage;
        private Label label5;
        private Label label6;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private TextBox txtPosition;
    }
}