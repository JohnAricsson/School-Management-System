namespace SchoolManagement
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            dataGridView1 = new DataGridView();
            cID = new TextBox();
            label3 = new Label();
            cName = new TextBox();
            label1 = new Label();
            sbutton2 = new Button();
            sbutton1 = new Button();
            label10 = new Label();
            ssearchbox = new TextBox();
            sbutton4 = new Button();
            sbutton5 = new Button();
            label12 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(375, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 431);
            dataGridView1.TabIndex = 58;
            // 
            // cID
            // 
            cID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cID.Location = new Point(161, 159);
            cID.Name = "cID";
            cID.Size = new Size(172, 26);
            cID.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 162);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 88;
            label3.Text = "Class ID :";
            // 
            // cName
            // 
            cName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cName.Location = new Point(161, 208);
            cName.Name = "cName";
            cName.Size = new Size(172, 26);
            cName.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(52, 211);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 90;
            label1.Text = "Class name :";
            // 
            // sbutton2
            // 
            sbutton2.BackColor = Color.MediumAquamarine;
            sbutton2.FlatAppearance.BorderSize = 0;
            sbutton2.FlatStyle = FlatStyle.Flat;
            sbutton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton2.ForeColor = Color.White;
            sbutton2.Location = new Point(196, 263);
            sbutton2.Name = "sbutton2";
            sbutton2.Size = new Size(87, 34);
            sbutton2.TabIndex = 93;
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
            sbutton1.Location = new Point(99, 263);
            sbutton1.Name = "sbutton1";
            sbutton1.Size = new Size(91, 34);
            sbutton1.TabIndex = 92;
            sbutton1.TabStop = false;
            sbutton1.Text = "Add";
            sbutton1.UseVisualStyleBackColor = false;
            sbutton1.Click += sbutton1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientActiveCaption;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(83, 368);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 95;
            label10.Text = "Search ID";
            // 
            // ssearchbox
            // 
            ssearchbox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ssearchbox.ForeColor = SystemColors.InactiveCaption;
            ssearchbox.Location = new Point(60, 391);
            ssearchbox.Name = "ssearchbox";
            ssearchbox.Size = new Size(123, 29);
            ssearchbox.TabIndex = 96;
            // 
            // sbutton4
            // 
            sbutton4.BackColor = Color.MediumAquamarine;
            sbutton4.FlatAppearance.BorderSize = 0;
            sbutton4.FlatStyle = FlatStyle.Flat;
            sbutton4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton4.ForeColor = Color.White;
            sbutton4.Image = (Image)resources.GetObject("sbutton4.Image");
            sbutton4.Location = new Point(179, 391);
            sbutton4.Name = "sbutton4";
            sbutton4.Size = new Size(30, 29);
            sbutton4.TabIndex = 94;
            sbutton4.TabStop = false;
            sbutton4.UseVisualStyleBackColor = false;
            sbutton4.Click += sbutton4_Click;
            // 
            // sbutton5
            // 
            sbutton5.BackColor = Color.MediumAquamarine;
            sbutton5.FlatAppearance.BorderSize = 0;
            sbutton5.FlatStyle = FlatStyle.Flat;
            sbutton5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton5.ForeColor = Color.White;
            sbutton5.Location = new Point(230, 391);
            sbutton5.Name = "sbutton5";
            sbutton5.Size = new Size(88, 29);
            sbutton5.TabIndex = 97;
            sbutton5.TabStop = false;
            sbutton5.Text = "Refresh";
            sbutton5.UseVisualStyleBackColor = false;
            sbutton5.Click += sbutton5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientActiveCaption;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(99, 113);
            label12.Name = "label12";
            label12.Size = new Size(170, 27);
            label12.TabIndex = 98;
            label12.Text = "Class information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(14, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 392);
            panel1.TabIndex = 99;
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 561);
            Controls.Add(label12);
            Controls.Add(sbutton5);
            Controls.Add(label10);
            Controls.Add(ssearchbox);
            Controls.Add(sbutton4);
            Controls.Add(sbutton2);
            Controls.Add(sbutton1);
            Controls.Add(cName);
            Controls.Add(label1);
            Controls.Add(cID);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Class";
            Text = "Class";
            Load += Class_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox cID;
        private Label label3;
        private TextBox cName;
        private Label label1;
        private Button sbutton2;
        private Button sbutton1;
        private Label label10;
        private TextBox ssearchbox;
        private Button sbutton4;
        private Button sbutton5;
        private Label label12;
        private Panel panel1;
    }
}