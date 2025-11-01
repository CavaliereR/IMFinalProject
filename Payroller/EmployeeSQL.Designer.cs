namespace Payroller
{
    partial class EmployeeSQL
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
            btnaddrecord = new Button();
            btndelrecord = new Button();
            btnmenu = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Size = new Size(800, 330);
            dataGridView1.TabIndex = 0;
            // 
            // btnaddrecord
            // 
            btnaddrecord.Location = new Point(40, 392);
            btnaddrecord.Name = "btnaddrecord";
            btnaddrecord.Size = new Size(137, 29);
            btnaddrecord.TabIndex = 1;
            btnaddrecord.Text = "Add Record";
            btnaddrecord.UseVisualStyleBackColor = true;
            btnaddrecord.Click += btnaddrecord_Click;
            // 
            // btndelrecord
            // 
            btndelrecord.Location = new Point(585, 392);
            btndelrecord.Name = "btndelrecord";
            btndelrecord.Size = new Size(161, 29);
            btndelrecord.TabIndex = 2;
            btndelrecord.Text = "Delete Record";
            btndelrecord.UseVisualStyleBackColor = true;
            btndelrecord.Click += btndelrecord_Click;
            // 
            // btnmenu
            // 
            btnmenu.Location = new Point(319, 392);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(138, 29);
            btnmenu.TabIndex = 3;
            btnmenu.Text = "Back to Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(328, 348);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Load/Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // EmployeeSQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnmenu);
            Controls.Add(btndelrecord);
            Controls.Add(btnaddrecord);
            Controls.Add(dataGridView1);
            Name = "EmployeeSQL";
            Text = "EmployeeRecords";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnaddrecord;
        private Button btndelrecord;
        private Button btnmenu;
        private Button btnRefresh;
    }
}