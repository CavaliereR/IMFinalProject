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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            salary_manager.Location = new Point(380, 170);
            salary_manager.Name = "salary_manager";
            salary_manager.Size = new Size(83, 84);
            salary_manager.TabIndex = 5;
            salary_manager.Text = "💰";
            salary_manager.UseVisualStyleBackColor = true;
            salary_manager.Click += salary_manager_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(233, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 83);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(387, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 68);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(90, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 77);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(221, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 116);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 402);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}