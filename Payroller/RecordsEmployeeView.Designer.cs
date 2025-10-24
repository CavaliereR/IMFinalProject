using System.Windows.Forms;

namespace Payroller
{
    partial class RecordsEmployeeView
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblNumber;
        private Label lblRating;
        private Label lblSalaryIncrease;
        private TextBox txtName;
        private TextBox txtNumber;
        private TextBox txtRating;
        private TextBox txtSalaryIncrease;
        private Button btnClose;

        public RecordsEmployeeView(Button btnClose)
        {
            this.btnClose = btnClose;
        }

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

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblSalaryIncrease = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtSalaryIncrease = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 58);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(64, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(140, 55);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(300, 27);
            this.txtNumber.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(18, 98);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(55, 20);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating:";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(140, 95);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(300, 27);
            this.txtRating.TabIndex = 5;
            // 
            // lblSalaryIncrease
            // 
            this.lblSalaryIncrease.AutoSize = true;
            this.lblSalaryIncrease.Location = new System.Drawing.Point(18, 138);
            this.lblSalaryIncrease.Name = "lblSalaryIncrease";
            this.lblSalaryIncrease.Size = new System.Drawing.Size(113, 20);
            this.lblSalaryIncrease.TabIndex = 6;
            this.lblSalaryIncrease.Text = "Salary Increase:";
            // 
            // txtSalaryIncrease
            // 
            this.txtSalaryIncrease.Location = new System.Drawing.Point(140, 135);
            this.txtSalaryIncrease.Name = "txtSalaryIncrease";
            this.txtSalaryIncrease.ReadOnly = true;
            this.txtSalaryIncrease.Size = new System.Drawing.Size(300, 27);
            this.txtSalaryIncrease.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RecordsEmployeeView
            // 
            this.ClientSize = new System.Drawing.Size(468, 234);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSalaryIncrease);
            this.Controls.Add(this.lblSalaryIncrease);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RecordsEmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Record";
            this.Load += new System.EventHandler(this.RecordsEmployeeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}