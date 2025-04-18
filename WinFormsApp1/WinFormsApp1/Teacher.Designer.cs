namespace SchoolManagement
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            dataGridView1 = new DataGridView();
            tname = new TextBox();
            label1 = new Label();
            tposition = new TextBox();
            label4 = new Label();
            tbutton5 = new Button();
            label10 = new Label();
            tsearchbox = new TextBox();
            tbutton4 = new Button();
            tbutton3 = new Button();
            tbutton2 = new Button();
            tbutton1 = new Button();
            tDoB = new DateTimePicker();
            label5 = new Label();
            tjoinDate = new DateTimePicker();
            label2 = new Label();
            tID = new TextBox();
            label3 = new Label();
            tdepartment = new TextBox();
            label6 = new Label();
            tEphone = new TextBox();
            label7 = new Label();
            tphone = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Gender = new GroupBox();
            tmale = new RadioButton();
            tfemale = new RadioButton();
            taddress = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Gender.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(-4, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 308);
            dataGridView1.TabIndex = 20;
            // 
            // tname
            // 
            tname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tname.Location = new Point(144, 40);
            tname.Name = "tname";
            tname.Size = new Size(224, 26);
            tname.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(10, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 31;
            label1.Text = "Full Name :";
            // 
            // tposition
            // 
            tposition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tposition.Location = new Point(144, 144);
            tposition.Name = "tposition";
            tposition.Size = new Size(224, 26);
            tposition.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(10, 147);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 33;
            label4.Text = "Position :";
            // 
            // tbutton5
            // 
            tbutton5.BackColor = Color.MediumAquamarine;
            tbutton5.FlatAppearance.BorderSize = 0;
            tbutton5.FlatStyle = FlatStyle.Flat;
            tbutton5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbutton5.ForeColor = Color.White;
            tbutton5.Location = new Point(329, 213);
            tbutton5.Name = "tbutton5";
            tbutton5.Size = new Size(103, 34);
            tbutton5.TabIndex = 41;
            tbutton5.TabStop = false;
            tbutton5.Text = "Clear";
            tbutton5.UseVisualStyleBackColor = false;
            tbutton5.Click += tbutton5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.MediumAquamarine;
            label10.Location = new Point(437, 213);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 40;
            label10.Text = "Search ID :";
            // 
            // tsearchbox
            // 
            tsearchbox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsearchbox.ForeColor = SystemColors.InactiveCaption;
            tsearchbox.Location = new Point(543, 211);
            tsearchbox.Name = "tsearchbox";
            tsearchbox.Size = new Size(123, 29);
            tsearchbox.TabIndex = 55;
            // 
            // tbutton4
            // 
            tbutton4.BackColor = Color.MediumAquamarine;
            tbutton4.FlatAppearance.BorderSize = 0;
            tbutton4.FlatStyle = FlatStyle.Flat;
            tbutton4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbutton4.ForeColor = Color.White;
            tbutton4.Image = (Image)resources.GetObject("tbutton4.Image");
            tbutton4.Location = new Point(662, 211);
            tbutton4.Name = "tbutton4";
            tbutton4.Size = new Size(35, 29);
            tbutton4.TabIndex = 38;
            tbutton4.TabStop = false;
            tbutton4.UseVisualStyleBackColor = false;
            tbutton4.Click += tbutton4_Click;
            // 
            // tbutton3
            // 
            tbutton3.BackColor = Color.MediumAquamarine;
            tbutton3.FlatAppearance.BorderSize = 0;
            tbutton3.FlatStyle = FlatStyle.Flat;
            tbutton3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbutton3.ForeColor = Color.White;
            tbutton3.Location = new Point(221, 213);
            tbutton3.Name = "tbutton3";
            tbutton3.Size = new Size(103, 34);
            tbutton3.TabIndex = 37;
            tbutton3.TabStop = false;
            tbutton3.Text = "Update";
            tbutton3.UseVisualStyleBackColor = false;
            tbutton3.Click += tbutton3_Click;
            // 
            // tbutton2
            // 
            tbutton2.BackColor = Color.MediumAquamarine;
            tbutton2.FlatAppearance.BorderSize = 0;
            tbutton2.FlatStyle = FlatStyle.Flat;
            tbutton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbutton2.ForeColor = Color.White;
            tbutton2.Location = new Point(112, 213);
            tbutton2.Name = "tbutton2";
            tbutton2.Size = new Size(103, 34);
            tbutton2.TabIndex = 36;
            tbutton2.TabStop = false;
            tbutton2.Text = "Delete";
            tbutton2.UseVisualStyleBackColor = false;
            tbutton2.Click += tbutton2_Click;
            // 
            // tbutton1
            // 
            tbutton1.BackColor = Color.MediumAquamarine;
            tbutton1.FlatAppearance.BorderSize = 0;
            tbutton1.FlatStyle = FlatStyle.Flat;
            tbutton1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbutton1.ForeColor = Color.White;
            tbutton1.Location = new Point(5, 213);
            tbutton1.Name = "tbutton1";
            tbutton1.Size = new Size(103, 34);
            tbutton1.TabIndex = 35;
            tbutton1.TabStop = false;
            tbutton1.Text = "Add";
            tbutton1.UseVisualStyleBackColor = false;
            tbutton1.Click += tbutton1_Click;
            // 
            // tDoB
            // 
            tDoB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tDoB.Location = new Point(507, 45);
            tDoB.Name = "tDoB";
            tDoB.Size = new Size(198, 26);
            tDoB.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MediumAquamarine;
            label5.Location = new Point(374, 46);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 42;
            label5.Text = "Date of Birth :";
            // 
            // tjoinDate
            // 
            tjoinDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tjoinDate.Location = new Point(507, 77);
            tjoinDate.Name = "tjoinDate";
            tjoinDate.Size = new Size(198, 26);
            tjoinDate.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(374, 78);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 44;
            label2.Text = "Joining Date :";
            // 
            // tID
            // 
            tID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tID.Location = new Point(144, 75);
            tID.Name = "tID";
            tID.Size = new Size(224, 26);
            tID.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(10, 78);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 46;
            label3.Text = "Employee ID* :";
            // 
            // tdepartment
            // 
            tdepartment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tdepartment.Location = new Point(144, 112);
            tdepartment.Name = "tdepartment";
            tdepartment.Size = new Size(224, 26);
            tdepartment.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(10, 115);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 48;
            label6.Text = "Department";
            // 
            // tEphone
            // 
            tEphone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEphone.Location = new Point(507, 142);
            tEphone.Name = "tEphone";
            tEphone.Size = new Size(198, 26);
            tEphone.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.MediumAquamarine;
            label7.Location = new Point(374, 145);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 52;
            label7.Text = "EmergencyNo :";
            // 
            // tphone
            // 
            tphone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tphone.Location = new Point(507, 109);
            tphone.Name = "tphone";
            tphone.Size = new Size(198, 26);
            tphone.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.MediumAquamarine;
            label8.Location = new Point(374, 114);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 50;
            label8.Text = "Phone :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.MediumAquamarine;
            label9.Location = new Point(374, 174);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 54;
            label9.Text = "Gender :";
            // 
            // Gender
            // 
            Gender.BackColor = Color.Transparent;
            Gender.Controls.Add(tmale);
            Gender.Controls.Add(tfemale);
            Gender.FlatStyle = FlatStyle.Flat;
            Gender.Location = new Point(507, 172);
            Gender.Name = "Gender";
            Gender.Size = new Size(172, 26);
            Gender.TabIndex = 41;
            Gender.TabStop = false;
            // 
            // tmale
            // 
            tmale.AutoSize = true;
            tmale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tmale.ForeColor = Color.MediumAquamarine;
            tmale.Location = new Point(6, 5);
            tmale.Name = "tmale";
            tmale.Size = new Size(65, 24);
            tmale.TabIndex = 17;
            tmale.Text = "Male";
            tmale.UseVisualStyleBackColor = true;
            // 
            // tfemale
            // 
            tfemale.AutoSize = true;
            tfemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tfemale.ForeColor = Color.MediumAquamarine;
            tfemale.Location = new Point(88, 4);
            tfemale.Name = "tfemale";
            tfemale.Size = new Size(86, 24);
            tfemale.TabIndex = 18;
            tfemale.Text = "Female";
            tfemale.UseVisualStyleBackColor = true;
            // 
            // taddress
            // 
            taddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taddress.Location = new Point(144, 175);
            taddress.Name = "taddress";
            taddress.Size = new Size(224, 26);
            taddress.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.ForeColor = Color.MediumAquamarine;
            label11.Location = new Point(10, 178);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 56;
            label11.Text = "Address :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MediumAquamarine;
            label12.Location = new Point(10, 6);
            label12.Name = "label12";
            label12.Size = new Size(159, 27);
            label12.TabIndex = 57;
            label12.Text = "Personal Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MediumAquamarine;
            label13.Location = new Point(3, 98);
            label13.Name = "label13";
            label13.Size = new Size(124, 16);
            label13.TabIndex = 58;
            label13.Text = "(Note: id is fixed)";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 561);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(taddress);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(Gender);
            Controls.Add(tEphone);
            Controls.Add(label7);
            Controls.Add(tphone);
            Controls.Add(label8);
            Controls.Add(tdepartment);
            Controls.Add(label6);
            Controls.Add(tID);
            Controls.Add(label3);
            Controls.Add(tjoinDate);
            Controls.Add(label2);
            Controls.Add(tDoB);
            Controls.Add(label5);
            Controls.Add(tbutton5);
            Controls.Add(label10);
            Controls.Add(tsearchbox);
            Controls.Add(tbutton4);
            Controls.Add(tbutton3);
            Controls.Add(tbutton2);
            Controls.Add(tbutton1);
            Controls.Add(tposition);
            Controls.Add(label4);
            Controls.Add(tname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Gender.ResumeLayout(false);
            Gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tname;
        private Label label1;
        private TextBox tposition;
        private Label label4;
        private Button tbutton5;
        private Label label10;
        private TextBox tsearchbox;
        private Button tbutton4;
        private Button tbutton3;
        private Button tbutton2;
        private Button tbutton1;
        private DateTimePicker tDoB;
        private Label label5;
        private DateTimePicker tjoinDate;
        private Label label2;
        private TextBox tID;
        private Label label3;
        private TextBox tdepartment;
        private Label label6;
        private TextBox tEphone;
        private Label label7;
        private TextBox tphone;
        private Label label8;
        private Label label9;
        private GroupBox Gender;
        private RadioButton tmale;
        private RadioButton tfemale;
        private TextBox taddress;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}