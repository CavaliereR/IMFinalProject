namespace Payroller
{
    partial class EditSalaryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblEmployeeName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee:";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(100, 18);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(0, 20);
            lblEmployeeName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Rate Per Hour:";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(140, 55);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(150, 27);
            txtHours.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(140, 95);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(150, 27);
            txtRate.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(45, 150);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(110, 30);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(268, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(321, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditSalaryForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(443, 204);
            Controls.Add(button1);
            Controls.Add(lblEmployeeName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtRate);
            Controls.Add(label3);
            Controls.Add(txtHours);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSalaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Records";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
    }
}
