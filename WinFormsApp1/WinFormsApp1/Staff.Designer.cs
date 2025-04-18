namespace SchoolManagement
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            saddress = new TextBox();
            label11 = new Label();
            label9 = new Label();
            Gender = new GroupBox();
            smale = new RadioButton();
            sfemale = new RadioButton();
            sEphone = new TextBox();
            label7 = new Label();
            sphone = new TextBox();
            label8 = new Label();
            Job = new TextBox();
            label6 = new Label();
            sID = new TextBox();
            label3 = new Label();
            sjoinDate = new DateTimePicker();
            label2 = new Label();
            sDoB = new DateTimePicker();
            label5 = new Label();
            sbutton5 = new Button();
            label10 = new Label();
            ssearchbox = new TextBox();
            sbutton4 = new Button();
            sbutton3 = new Button();
            sbutton2 = new Button();
            sbutton1 = new Button();
            sname = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // saddress
            // 
            saddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saddress.Location = new Point(146, 149);
            saddress.Name = "saddress";
            saddress.Size = new Size(224, 26);
            saddress.TabIndex = 66;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.ForeColor = Color.MediumAquamarine;
            label11.Location = new Point(12, 148);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 84;
            label11.Text = "Address :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.MediumAquamarine;
            label9.Location = new Point(12, 180);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 82;
            label9.Text = "Gender :";
            // 
            // Gender
            // 
            Gender.BackColor = Color.Transparent;
            Gender.Controls.Add(smale);
            Gender.Controls.Add(sfemale);
            Gender.FlatStyle = FlatStyle.Flat;
            Gender.Location = new Point(147, 174);
            Gender.Name = "Gender";
            Gender.Size = new Size(172, 26);
            Gender.TabIndex = 75;
            Gender.TabStop = false;
            // 
            // smale
            // 
            smale.AutoSize = true;
            smale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            smale.ForeColor = Color.MediumAquamarine;
            smale.Location = new Point(6, 5);
            smale.Name = "smale";
            smale.Size = new Size(65, 24);
            smale.TabIndex = 17;
            smale.Text = "Male";
            smale.UseVisualStyleBackColor = true;
            // 
            // sfemale
            // 
            sfemale.AutoSize = true;
            sfemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            sfemale.ForeColor = Color.MediumAquamarine;
            sfemale.Location = new Point(88, 4);
            sfemale.Name = "sfemale";
            sfemale.Size = new Size(86, 24);
            sfemale.TabIndex = 18;
            sfemale.Text = "Female";
            sfemale.UseVisualStyleBackColor = true;
            // 
            // sEphone
            // 
            sEphone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sEphone.Location = new Point(505, 144);
            sEphone.Name = "sEphone";
            sEphone.Size = new Size(198, 26);
            sEphone.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.MediumAquamarine;
            label7.Location = new Point(377, 147);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 81;
            label7.Text = "EmergencyNo :";
            // 
            // sphone
            // 
            sphone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sphone.Location = new Point(505, 113);
            sphone.Name = "sphone";
            sphone.Size = new Size(198, 26);
            sphone.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.MediumAquamarine;
            label8.Location = new Point(377, 116);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 80;
            label8.Text = "Phone :";
            // 
            // Job
            // 
            Job.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Job.Location = new Point(146, 117);
            Job.Name = "Job";
            Job.Size = new Size(224, 26);
            Job.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(13, 119);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 79;
            label6.Text = "Job";
            // 
            // sID
            // 
            sID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sID.Location = new Point(147, 77);
            sID.Name = "sID";
            sID.Size = new Size(224, 26);
            sID.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(13, 80);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 78;
            label3.Text = "Staff ID* :";
            // 
            // sjoinDate
            // 
            sjoinDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sjoinDate.Location = new Point(505, 80);
            sjoinDate.Name = "sjoinDate";
            sjoinDate.Size = new Size(198, 26);
            sjoinDate.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(377, 80);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 77;
            label2.Text = "Joining Date :";
            // 
            // sDoB
            // 
            sDoB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sDoB.Location = new Point(505, 48);
            sDoB.Name = "sDoB";
            sDoB.Size = new Size(198, 26);
            sDoB.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MediumAquamarine;
            label5.Location = new Point(377, 48);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 76;
            label5.Text = "Date of Birth :";
            // 
            // sbutton5
            // 
            sbutton5.BackColor = Color.MediumAquamarine;
            sbutton5.FlatAppearance.BorderSize = 0;
            sbutton5.FlatStyle = FlatStyle.Flat;
            sbutton5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton5.ForeColor = Color.White;
            sbutton5.Location = new Point(331, 215);
            sbutton5.Name = "sbutton5";
            sbutton5.Size = new Size(103, 34);
            sbutton5.TabIndex = 74;
            sbutton5.TabStop = false;
            sbutton5.Text = "Clear";
            sbutton5.UseVisualStyleBackColor = false;
            sbutton5.Click += sbutton5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.MediumAquamarine;
            label10.Location = new Point(440, 215);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 72;
            label10.Text = "Search ID :";
            // 
            // ssearchbox
            // 
            ssearchbox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ssearchbox.ForeColor = SystemColors.InactiveCaption;
            ssearchbox.Location = new Point(546, 213);
            ssearchbox.Name = "ssearchbox";
            ssearchbox.Size = new Size(123, 29);
            ssearchbox.TabIndex = 83;
            // 
            // sbutton4
            // 
            sbutton4.BackColor = Color.MediumAquamarine;
            sbutton4.FlatAppearance.BorderSize = 0;
            sbutton4.FlatStyle = FlatStyle.Flat;
            sbutton4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton4.ForeColor = Color.White;
            sbutton4.Image = (Image)resources.GetObject("sbutton4.Image");
            sbutton4.Location = new Point(669, 213);
            sbutton4.Name = "sbutton4";
            sbutton4.Size = new Size(30, 29);
            sbutton4.TabIndex = 70;
            sbutton4.TabStop = false;
            sbutton4.UseVisualStyleBackColor = false;
            sbutton4.Click += sbutton4_Click;
            // 
            // sbutton3
            // 
            sbutton3.BackColor = Color.MediumAquamarine;
            sbutton3.FlatAppearance.BorderSize = 0;
            sbutton3.FlatStyle = FlatStyle.Flat;
            sbutton3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton3.ForeColor = Color.White;
            sbutton3.Location = new Point(222, 215);
            sbutton3.Name = "sbutton3";
            sbutton3.Size = new Size(103, 34);
            sbutton3.TabIndex = 68;
            sbutton3.TabStop = false;
            sbutton3.Text = "Update";
            sbutton3.UseVisualStyleBackColor = false;
            sbutton3.Click += sbutton3_Click;
            // 
            // sbutton2
            // 
            sbutton2.BackColor = Color.MediumAquamarine;
            sbutton2.FlatAppearance.BorderSize = 0;
            sbutton2.FlatStyle = FlatStyle.Flat;
            sbutton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton2.ForeColor = Color.White;
            sbutton2.Location = new Point(113, 215);
            sbutton2.Name = "sbutton2";
            sbutton2.Size = new Size(103, 34);
            sbutton2.TabIndex = 65;
            sbutton2.TabStop = false;
            sbutton2.Text = "Delete";
            sbutton2.UseVisualStyleBackColor = false;
            sbutton2.Click += sbutton2_Click;
            // 
            // sbutton1
            // 
            sbutton1.BackColor = Color.MediumAquamarine;
            sbutton1.FlatAppearance.BorderSize = 0;
            sbutton1.FlatStyle = FlatStyle.Flat;
            sbutton1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton1.ForeColor = Color.White;
            sbutton1.Location = new Point(4, 215);
            sbutton1.Name = "sbutton1";
            sbutton1.Size = new Size(103, 34);
            sbutton1.TabIndex = 64;
            sbutton1.TabStop = false;
            sbutton1.Text = "Add";
            sbutton1.UseVisualStyleBackColor = false;
            sbutton1.Click += sbutton1_Click;
            // 
            // sname
            // 
            sname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sname.Location = new Point(147, 42);
            sname.Name = "sname";
            sname.Size = new Size(224, 26);
            sname.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(13, 45);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 58;
            label1.Text = "Full Name :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(728, 308);
            dataGridView1.TabIndex = 57;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MediumAquamarine;
            label12.Location = new Point(13, 9);
            label12.Name = "label12";
            label12.Size = new Size(159, 27);
            label12.TabIndex = 85;
            label12.Text = "Personal Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MediumAquamarine;
            label13.Location = new Point(12, 100);
            label13.Name = "label13";
            label13.Size = new Size(124, 16);
            label13.TabIndex = 86;
            label13.Text = "(Note: id is fixed)";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 561);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(saddress);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(Gender);
            Controls.Add(sEphone);
            Controls.Add(label7);
            Controls.Add(sphone);
            Controls.Add(label8);
            Controls.Add(Job);
            Controls.Add(label6);
            Controls.Add(sID);
            Controls.Add(label3);
            Controls.Add(sjoinDate);
            Controls.Add(label2);
            Controls.Add(sDoB);
            Controls.Add(label5);
            Controls.Add(sbutton5);
            Controls.Add(label10);
            Controls.Add(ssearchbox);
            Controls.Add(sbutton4);
            Controls.Add(sbutton3);
            Controls.Add(sbutton2);
            Controls.Add(sbutton1);
            Controls.Add(sname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            Gender.ResumeLayout(false);
            Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox saddress;
        private Label label11;
        private Label label9;
        private GroupBox Gender;
        private RadioButton smale;
        private RadioButton sfemale;
        private TextBox sEphone;
        private Label label7;
        private TextBox sphone;
        private Label label8;
        private TextBox Job;
        private Label label6;
        private TextBox sID;
        private Label label3;
        private DateTimePicker sjoinDate;
        private Label label2;
        private DateTimePicker sDoB;
        private Label label5;
        private Button sbutton5;
        private Label label10;
        private TextBox ssearchbox;
        private Button sbutton4;
        private Button sbutton3;
        private Button sbutton2;
        private Button sbutton1;
        private TextBox sname;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label13;
    }
}