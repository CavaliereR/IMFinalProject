using System.Windows.Forms;

namespace Payroller
{
    partial class EmployeeViewer
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewReadOnly;
        private Button btnClose;

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
            this.dataGridViewReadOnly = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadOnly)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReadOnly
            // 
            this.dataGridViewReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                              | System.Windows.Forms.AnchorStyles.Left) 
                                              | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReadOnly.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReadOnly.Name = "dataGridViewReadOnly";
            this.dataGridViewReadOnly.Size = new System.Drawing.Size(560, 337);
            this.dataGridViewReadOnly.TabIndex = 0;
            this.dataGridViewReadOnly.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(249, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EmployeeViewer
            // 
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewReadOnly);
            this.Name = "EmployeeViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Record";
            this.Load += new System.EventHandler(this.EmployeeViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadOnly)).EndInit();
            this.ResumeLayout(false);
        }
    }
}