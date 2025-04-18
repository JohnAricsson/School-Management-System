namespace SchoolManagement
{
    partial class Student
    {
        private const string V = "Student";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            label1 = new Label();
            label2 = new Label();
            Fathername = new TextBox();
            Mothername = new TextBox();
            label3 = new Label();
            address = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DoB = new DateTimePicker();
            phone = new TextBox();
            label6 = new Label();
            Ephone = new TextBox();
            label7 = new Label();
            label8 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            searchbox = new TextBox();
            Gender = new GroupBox();
            label9 = new Label();
            ID = new TextBox();
            label10 = new Label();
            stdname = new TextBox();
            button5 = new Button();
            label11 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Gender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(8, 46);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Full Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 4;
            label2.Text = "Father's Name:";
            // 
            // Fathername
            // 
            Fathername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fathername.Location = new Point(142, 75);
            Fathername.Name = "Fathername";
            Fathername.Size = new Size(224, 26);
            Fathername.TabIndex = 5;
            // 
            // Mothername
            // 
            Mothername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mothername.Location = new Point(142, 108);
            Mothername.Name = "Mothername";
            Mothername.Size = new Size(224, 26);
            Mothername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(8, 111);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 6;
            label3.Text = "Mother's Name:";
            // 
            // address
            // 
            address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(142, 141);
            address.Name = "address";
            address.Size = new Size(224, 26);
            address.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(8, 144);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MediumAquamarine;
            label5.Location = new Point(373, 44);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 10;
            label5.Text = "Date of Birth :";
            // 
            // DoB
            // 
            DoB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoB.Location = new Point(506, 43);
            DoB.Name = "DoB";
            DoB.Size = new Size(198, 26);
            DoB.TabIndex = 11;
            // 
            // phone
            // 
            phone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone.Location = new Point(506, 75);
            phone.Name = "phone";
            phone.Size = new Size(198, 26);
            phone.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(373, 80);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Phone :";
            // 
            // Ephone
            // 
            Ephone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ephone.Location = new Point(506, 108);
            Ephone.Name = "Ephone";
            Ephone.Size = new Size(198, 26);
            Ephone.TabIndex = 15;
            Ephone.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.MediumAquamarine;
            label7.Location = new Point(373, 111);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 14;
            label7.Text = "EmergencyNo :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.MediumAquamarine;
            label8.Location = new Point(373, 144);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 16;
            label8.Text = "Gender :";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            male.ForeColor = Color.MediumAquamarine;
            male.Location = new Point(6, 11);
            male.Name = "male";
            male.Size = new Size(65, 24);
            male.TabIndex = 17;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            female.ForeColor = Color.MediumAquamarine;
            female.Location = new Point(100, 11);
            female.Name = "female";
            female.Size = new Size(86, 24);
            female.TabIndex = 18;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(727, 308);
            dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(11, 217);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 20;
            button1.TabStop = false;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(120, 217);
            button2.Name = "button2";
            button2.Size = new Size(103, 34);
            button2.TabIndex = 21;
            button2.TabStop = false;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumAquamarine;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(229, 217);
            button3.Name = "button3";
            button3.Size = new Size(103, 34);
            button3.TabIndex = 22;
            button3.TabStop = false;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumAquamarine;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(663, 217);
            button4.Name = "button4";
            button4.Size = new Size(29, 29);
            button4.TabIndex = 24;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // searchbox
            // 
            searchbox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbox.ForeColor = SystemColors.InactiveCaption;
            searchbox.Location = new Point(530, 217);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(133, 29);
            searchbox.TabIndex = 25;
            // 
            // Gender
            // 
            Gender.BackColor = Color.Transparent;
            Gender.Controls.Add(male);
            Gender.Controls.Add(female);
            Gender.FlatStyle = FlatStyle.Flat;
            Gender.Location = new Point(507, 130);
            Gender.Name = "Gender";
            Gender.Size = new Size(192, 37);
            Gender.TabIndex = 26;
            Gender.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.MediumAquamarine;
            label9.Location = new Point(210, 178);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 27;
            label9.Text = "Add ID :";
            // 
            // ID
            // 
            ID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.ForeColor = SystemColors.InactiveCaption;
            ID.Location = new Point(288, 173);
            ID.Name = "ID";
            ID.Size = new Size(78, 29);
            ID.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.MediumAquamarine;
            label10.Location = new Point(551, 197);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 29;
            label10.Text = "Search ID";
            // 
            // stdname
            // 
            stdname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stdname.Location = new Point(142, 43);
            stdname.Name = "stdname";
            stdname.Size = new Size(224, 26);
            stdname.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumAquamarine;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(338, 217);
            button5.Name = "button5";
            button5.Size = new Size(103, 34);
            button5.TabIndex = 31;
            button5.TabStop = false;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumAquamarine;
            label11.Location = new Point(8, 6);
            label11.Name = "label11";
            label11.Size = new Size(159, 27);
            label11.TabIndex = 32;
            label11.Text = "Personal Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MediumAquamarine;
            label13.Location = new Point(373, 181);
            label13.Name = "label13";
            label13.Size = new Size(124, 16);
            label13.TabIndex = 59;
            label13.Text = "(Note: id is fixed)";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 561);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(button5);
            Controls.Add(stdname);
            Controls.Add(label10);
            Controls.Add(ID);
            Controls.Add(label9);
            Controls.Add(searchbox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(Ephone);
            Controls.Add(label7);
            Controls.Add(phone);
            Controls.Add(label6);
            Controls.Add(DoB);
            Controls.Add(label5);
            Controls.Add(address);
            Controls.Add(label4);
            Controls.Add(Mothername);
            Controls.Add(label3);
            Controls.Add(Fathername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Gender);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Gender.ResumeLayout(false);
            Gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Fathername;
        private TextBox Mothername;
        private Label label3;
        private TextBox address;
        private Label label4;
        private Label label5;
        private DateTimePicker DoB;
        private TextBox phone;
        private Label label6;
        private TextBox Ephone;
        private Label label7;
        private Label label8;
        private RadioButton male;
        private RadioButton female;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox searchbox;
        private GroupBox Gender;
        private Label label9;
        private TextBox ID;
        private Label label10;
        private TextBox stdname;
        private Button button5;
        private Label label11;
        private Label label13;
    }
}