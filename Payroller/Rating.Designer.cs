namespace Payroller
{
    partial class Rating
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

        private string GetText()
        {
            return Text;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmployeeName = new TextBox();
            txtEmployeeNumber = new TextBox();
            cmbPerformanceRating = new ComboBox();
            btnFInish = new Button();
            lblEmployeename = new Label();
            lblEmployeenumber = new Label();
            lstEmployeeRecords = new ListBox();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(211, 68);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(193, 27);
            txtEmployeeName.TabIndex = 0;
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.Location = new Point(211, 110);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(193, 27);
            txtEmployeeNumber.TabIndex = 1;
            // 
            // cmbPerformanceRating
            // 
            cmbPerformanceRating.FormattingEnabled = true;
            cmbPerformanceRating.Location = new Point(211, 152);
            cmbPerformanceRating.Name = "cmbPerformanceRating";
            cmbPerformanceRating.Size = new Size(166, 28);
            cmbPerformanceRating.TabIndex = 2;
            // 
            // btnFInish
            // 
            btnFInish.Location = new Point(237, 204);
            btnFInish.Name = "btnFInish";
            btnFInish.Size = new Size(94, 29);
            btnFInish.TabIndex = 3;
            btnFInish.Text = "Add";
            btnFInish.UseVisualStyleBackColor = true;
            btnFInish.Click += btnFInish_Click_1;
            // 
            // lblEmployeename
            // 
            lblEmployeename.AutoSize = true;
            lblEmployeename.Location = new Point(48, 71);
            lblEmployeename.Name = "lblEmployeename";
            lblEmployeename.Size = new Size(157, 20);
            lblEmployeename.TabIndex = 4;
            lblEmployeename.Text = "Enter employee name:";
            // 
            // lblEmployeenumber
            // 
            lblEmployeenumber.AutoSize = true;
            lblEmployeenumber.Location = new Point(34, 113);
            lblEmployeenumber.Name = "lblEmployeenumber";
            lblEmployeenumber.Size = new Size(171, 20);
            lblEmployeenumber.TabIndex = 5;
            lblEmployeenumber.Text = "Enter employee number:";
            // 
            // lstEmployeeRecords
            // 
            lstEmployeeRecords.FormattingEnabled = true;
            lstEmployeeRecords.Location = new Point(20, 271);
            lstEmployeeRecords.Name = "lstEmployeeRecords";
            lstEmployeeRecords.Size = new Size(565, 124);
            lstEmployeeRecords.TabIndex = 6;
            lstEmployeeRecords.SelectedIndexChanged += lstEmployeeRecords_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 481);
            Controls.Add(lstEmployeeRecords);
            Controls.Add(lblEmployeenumber);
            Controls.Add(lblEmployeename);
            Controls.Add(btnFInish);
            Controls.Add(cmbPerformanceRating);
            Controls.Add(txtEmployeeNumber);
            Controls.Add(txtEmployeeName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtEmployeeName;
        private TextBox txtEmployeeNumber;
        private ComboBox cmbPerformanceRating;
        private Button btnFInish;
        private Label lblEmployeename;
        private Label lblEmployeenumber;
        private ListBox lstEmployeeRecords;
    }
}