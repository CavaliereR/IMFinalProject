namespace Payroller
{
    partial class EmployeePov
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
            dataGridView1 = new DataGridView();
            EmployeeRefresh = new Button();
            EmployeeBack2Menu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 303);
            dataGridView1.TabIndex = 0;
            // 
            // EmployeeRefresh
            // 
            EmployeeRefresh.Location = new Point(345, 332);
            EmployeeRefresh.Name = "EmployeeRefresh";
            EmployeeRefresh.Size = new Size(117, 37);
            EmployeeRefresh.TabIndex = 1;
            EmployeeRefresh.Text = "Load/Refresh";
            EmployeeRefresh.UseVisualStyleBackColor = true;
            EmployeeRefresh.Click += this.button1_Click;
            // 
            // EmployeeBack2Menu
            // 
            EmployeeBack2Menu.Location = new Point(345, 389);
            EmployeeBack2Menu.Name = "EmployeeBack2Menu";
            EmployeeBack2Menu.Size = new Size(117, 37);
            EmployeeBack2Menu.TabIndex = 2;
            EmployeeBack2Menu.Text = "Back to Menu";
            EmployeeBack2Menu.UseVisualStyleBackColor = true;
            EmployeeBack2Menu.Click += this.EmployeeBack2Menu_Click;
            // 
            // EmployeePov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(EmployeeBack2Menu);
            Controls.Add(EmployeeRefresh);
            Controls.Add(dataGridView1);
            Name = "EmployeePov";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button EmployeeRefresh;
        private Button EmployeeBack2Menu;
    }
}