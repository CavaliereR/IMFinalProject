namespace Payroller
{
    partial class DeleteForm
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
            searchName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 94);
            label1.Name = "label1";
            label1.Size = new Size(291, 60);
            label1.TabIndex = 0;
            label1.Text = "Search Name:";
            // 
            // searchName
            // 
            searchName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchName.Location = new Point(379, 89);
            searchName.Name = "searchName";
            searchName.Size = new Size(308, 65);
            searchName.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(305, 248);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 3;
            button1.Text = "Delete Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(searchName);
            Controls.Add(label1);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchName;
        private Button button1;
    }
}