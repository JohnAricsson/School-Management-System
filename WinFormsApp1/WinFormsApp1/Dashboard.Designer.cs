namespace SchoolManagement
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            StudentNo = new Label();
            label1 = new Label();
            panel2 = new Panel();
            TeacherNo = new Label();
            label4 = new Label();
            panel3 = new Panel();
            StaffNo = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            date = new Label();
            time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            LABEL = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(StudentNo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(527, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 56);
            panel1.TabIndex = 0;
            // 
            // StudentNo
            // 
            StudentNo.AutoSize = true;
            StudentNo.BackColor = Color.Transparent;
            StudentNo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNo.ForeColor = Color.White;
            StudentNo.Location = new Point(136, 11);
            StudentNo.Name = "StudentNo";
            StudentNo.Size = new Size(30, 31);
            StudentNo.TabIndex = 1;
            StudentNo.Text = "0";
            StudentNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 31);
            label1.TabIndex = 0;
            label1.Text = "Students";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(TeacherNo);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(527, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 56);
            panel2.TabIndex = 1;
            // 
            // TeacherNo
            // 
            TeacherNo.AutoSize = true;
            TeacherNo.BackColor = Color.Transparent;
            TeacherNo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherNo.ForeColor = Color.White;
            TeacherNo.Location = new Point(136, 13);
            TeacherNo.Name = "TeacherNo";
            TeacherNo.Size = new Size(30, 31);
            TeacherNo.TabIndex = 1;
            TeacherNo.Text = "0";
            TeacherNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 12);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 0;
            label4.Text = "Teachers";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(StaffNo);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(527, 435);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 56);
            panel3.TabIndex = 2;
            // 
            // StaffNo
            // 
            StaffNo.AutoSize = true;
            StaffNo.BackColor = Color.Transparent;
            StaffNo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StaffNo.ForeColor = Color.White;
            StaffNo.Location = new Point(136, 13);
            StaffNo.Name = "StaffNo";
            StaffNo.Size = new Size(30, 31);
            StaffNo.TabIndex = 1;
            StaffNo.Text = "0";
            StaffNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 13);
            label6.Name = "label6";
            label6.Size = new Size(91, 31);
            label6.TabIndex = 0;
            label6.Text = "Staffs";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(728, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Location = new Point(0, 267);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 25);
            panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 309);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumAquamarine;
            label7.Location = new Point(169, 319);
            label7.Name = "label7";
            label7.Size = new Size(127, 35);
            label7.TabIndex = 6;
            label7.Text = "Welcome,";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumAquamarine;
            label8.Location = new Point(169, 360);
            label8.Name = "label8";
            label8.Size = new Size(242, 27);
            label8.TabIndex = 7;
            label8.Text = "Manage your information";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date.ForeColor = Color.MediumAquamarine;
            date.Location = new Point(495, 514);
            date.Name = "date";
            date.Size = new Size(52, 21);
            date.TabIndex = 8;
            date.Text = "label1";
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time.ForeColor = Color.MediumAquamarine;
            time.Location = new Point(169, 391);
            time.Name = "time";
            time.Size = new Size(56, 23);
            time.TabIndex = 9;
            time.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LABEL
            // 
            LABEL.AutoSize = true;
            LABEL.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL.ForeColor = Color.MediumAquamarine;
            LABEL.Location = new Point(284, 321);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(69, 35);
            LABEL.TabIndex = 10;
            LABEL.Text = "label";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(727, 561);
            Controls.Add(LABEL);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label StudentNo;
        private Label label1;
        private Panel panel2;
        private Label TeacherNo;
        private Label label4;
        private Panel panel3;
        private Label StaffNo;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private Label date;
        private Label time;
        private System.Windows.Forms.Timer timer1;
        private Label LABEL;
    }
}