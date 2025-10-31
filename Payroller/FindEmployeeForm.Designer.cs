namespace Payroller
{
    partial class FindEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPrompt = new Label();
            txtName = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(12, 18);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(221, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter the exact employee name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(304, 27);
            txtName.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(16, 90);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 90);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FindEmployeeForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(341, 140);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtName);
            Controls.Add(lblPrompt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

