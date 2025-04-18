namespace SchoolManagement
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Dropdown = new FlowLayoutPanel();
            button10 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button11 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            FormPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            Dropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 565);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel2.BackColor = Color.MediumAquamarine;
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(Dropdown);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Location = new Point(-2, 76);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(259, 486);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(263, 38);
            button1.TabIndex = 4;
            button1.Text = "Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(3, 47);
            button2.Name = "button2";
            button2.Size = new Size(261, 38);
            button2.TabIndex = 5;
            button2.Text = "Students";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumAquamarine;
            button3.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(3, 91);
            button3.Name = "button3";
            button3.Size = new Size(256, 38);
            button3.TabIndex = 6;
            button3.Text = "Teachers";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumAquamarine;
            button4.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(3, 135);
            button4.Name = "button4";
            button4.Size = new Size(256, 38);
            button4.TabIndex = 7;
            button4.Text = "Staffs";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Dropdown
            // 
            Dropdown.Controls.Add(button10);
            Dropdown.Controls.Add(button8);
            Dropdown.Controls.Add(button9);
            Dropdown.Controls.Add(button7);
            Dropdown.Controls.Add(button11);
            Dropdown.Location = new Point(3, 179);
            Dropdown.Name = "Dropdown";
            Dropdown.Size = new Size(256, 46);
            Dropdown.TabIndex = 13;
            // 
            // button10
            // 
            button10.BackColor = Color.MediumAquamarine;
            button10.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(259, 38);
            button10.TabIndex = 12;
            button10.Text = "Class and Section";
            button10.TextImageRelation = TextImageRelation.TextBeforeImage;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MediumAquamarine;
            button8.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.BottomLeft;
            button8.Location = new Point(3, 47);
            button8.Name = "button8";
            button8.Size = new Size(259, 38);
            button8.TabIndex = 10;
            button8.Text = "Class";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MediumAquamarine;
            button9.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.BottomLeft;
            button9.Location = new Point(3, 91);
            button9.Name = "button9";
            button9.Size = new Size(259, 38);
            button9.TabIndex = 11;
            button9.Text = "Section";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumAquamarine;
            button7.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.BottomLeft;
            button7.Location = new Point(3, 135);
            button7.Name = "button7";
            button7.Size = new Size(259, 38);
            button7.TabIndex = 9;
            button7.Text = "Enroll";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MediumAquamarine;
            button11.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.BottomLeft;
            button11.Location = new Point(3, 179);
            button11.Name = "button11";
            button11.Size = new Size(259, 38);
            button11.TabIndex = 13;
            button11.Text = "Assign teacher";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumAquamarine;
            button5.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(3, 231);
            button5.Name = "button5";
            button5.Size = new Size(259, 38);
            button5.TabIndex = 8;
            button5.Text = "Settings";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.MediumAquamarine;
            button6.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.BottomLeft;
            button6.Location = new Point(3, 275);
            button6.Name = "button6";
            button6.Size = new Size(106, 38);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(199, 29);
            label1.TabIndex = 1;
            label1.Text = "Model Academy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPanel
            // 
            FormPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FormPanel.Location = new Point(257, 0);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(727, 561);
            FormPanel.TabIndex = 1;
            FormPanel.Paint += FormPanel_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(984, 561);
            Controls.Add(FormPanel);
            Controls.Add(panel1);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School System Management";
            Load += Homepage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            Dropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel FormPanel;
        private Button button10;
        private Button button9;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private System.Windows.Forms.Timer timer1;
        private Button button7;
        private FlowLayoutPanel Dropdown;
        private Button button11;
    }
}