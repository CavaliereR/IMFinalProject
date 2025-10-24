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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnAddRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 105);
            label1.Name = "label1";
            label1.Size = new Size(97, 38);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 158);
            label2.Name = "label2";
            label2.Size = new Size(89, 38);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 206);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(416, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 43);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(416, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 43);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(416, 207);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(270, 43);
            txtPhoneNumber.TabIndex = 6;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRecord.Location = new Point(297, 278);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(180, 59);
            btnAddRecord.TabIndex = 8;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // AddRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRecord);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRecords";
            Text = "AddRecords";
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
    }
}