namespace Payroller
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            button1 = new Button();
            label1 = new Label();
            version1 = new Button();
            label2 = new Label();
            btnlogout = new Button();
            salary_manager = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 170);
            button1.Name = "button1";
            button1.Size = new Size(80, 84);
            button1.TabIndex = 0;
            button1.Text = "👤";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 147);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee Records";
            // 
            // version1
            // 
            version1.Location = new Point(12, 14);
            version1.Name = "version1";
            version1.Size = new Size(129, 27);
            version1.TabIndex = 2;
            version1.Text = "Version 1.0 Build";
            version1.UseVisualStyleBackColor = true;
            version1.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 147);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(141, 20);
            label2.TabIndex = 3;
            label2.Text = "Salary Management";
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(487, 12);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Log-out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // salary_manager
            // 
            salary_manager.Location = new Point(383, 170);
            salary_manager.Name = "salary_manager";
            salary_manager.Size = new Size(80, 84);
            salary_manager.TabIndex = 5;
            salary_manager.Text = "💰";
            salary_manager.UseVisualStyleBackColor = true;
            salary_manager.Click += salary_manager_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(244, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 80);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 402);
            Controls.Add(pictureBox1);
            Controls.Add(salary_manager);
            Controls.Add(btnlogout);
            Controls.Add(label2);
            Controls.Add(version1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button version1;
        private Label label2;
        private Button btnlogout;
        private Button salary_manager;
        private PictureBox pictureBox1;
    }
}