namespace SchoolManagement
{
    partial class Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section));
            sbutton2 = new Button();
            sbutton1 = new Button();
            secName = new TextBox();
            label1 = new Label();
            secID = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            cID = new TextBox();
            label4 = new Label();
            label10 = new Label();
            ssearchbox = new TextBox();
            sbutton4 = new Button();
            sbutton5 = new Button();
            label12 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sbutton2
            // 
            sbutton2.BackColor = Color.MediumAquamarine;
            sbutton2.FlatAppearance.BorderSize = 0;
            sbutton2.FlatStyle = FlatStyle.Flat;
            sbutton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton2.ForeColor = Color.White;
            sbutton2.Location = new Point(237, 274);
            sbutton2.Name = "sbutton2";
            sbutton2.Size = new Size(81, 34);
            sbutton2.TabIndex = 101;
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
            sbutton1.Location = new Point(142, 274);
            sbutton1.Name = "sbutton1";
            sbutton1.Size = new Size(83, 34);
            sbutton1.TabIndex = 100;
            sbutton1.TabStop = false;
            sbutton1.Text = "Add";
            sbutton1.UseVisualStyleBackColor = false;
            sbutton1.Click += sbutton1_Click;
            // 
            // secName
            // 
            secName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secName.Location = new Point(142, 226);
            secName.Name = "secName";
            secName.Size = new Size(176, 26);
            secName.TabIndex = 97;
            secName.TextChanged += cName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 98;
            label1.Text = "Section name :";
            // 
            // secID
            // 
            secID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secID.Location = new Point(142, 143);
            secID.Name = "secID";
            secID.Size = new Size(176, 26);
            secID.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 96;
            label3.Text = "Section ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 470);
            dataGridView1.TabIndex = 94;
            // 
            // cID
            // 
            cID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cID.Location = new Point(142, 184);
            cID.Name = "cID";
            cID.Size = new Size(176, 26);
            cID.TabIndex = 102;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 103;
            label4.Text = "Class ID :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientActiveCaption;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(79, 354);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 105;
            label10.Text = "Search ID";
            // 
            // ssearchbox
            // 
            ssearchbox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ssearchbox.ForeColor = SystemColors.InactiveCaption;
            ssearchbox.Location = new Point(56, 377);
            ssearchbox.Name = "ssearchbox";
            ssearchbox.Size = new Size(123, 29);
            ssearchbox.TabIndex = 106;
            // 
            // sbutton4
            // 
            sbutton4.BackColor = Color.MediumAquamarine;
            sbutton4.FlatAppearance.BorderSize = 0;
            sbutton4.FlatStyle = FlatStyle.Flat;
            sbutton4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbutton4.ForeColor = Color.White;
            sbutton4.Image = (Image)resources.GetObject("sbutton4.Image");
            sbutton4.Location = new Point(179, 377);
            sbutton4.Name = "sbutton4";
            sbutton4.Size = new Size(30, 29);
            sbutton4.TabIndex = 104;
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
            sbutton5.Location = new Point(215, 376);
            sbutton5.Name = "sbutton5";
            sbutton5.Size = new Size(84, 30);
            sbutton5.TabIndex = 107;
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
            label12.Location = new Point(79, 94);
            label12.Name = "label12";
            label12.Size = new Size(192, 27);
            label12.TabIndex = 108;
            label12.Text = "Section information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(9, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 431);
            panel1.TabIndex = 109;
            panel1.Paint += panel1_Paint;
            // 
            // Section
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 561);
            Controls.Add(label12);
            Controls.Add(sbutton5);
            Controls.Add(label10);
            Controls.Add(ssearchbox);
            Controls.Add(sbutton4);
            Controls.Add(cID);
            Controls.Add(label4);
            Controls.Add(sbutton2);
            Controls.Add(sbutton1);
            Controls.Add(secName);
            Controls.Add(label1);
            Controls.Add(secID);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Section";
            Text = "Section";
            Load += Section_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sbutton2;
        private Button sbutton1;
        private TextBox secName;
        private Label label1;
        private TextBox secID;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox cID;
        private Label label4;
        private Label label10;
        private TextBox ssearchbox;
        private Button sbutton4;
        private Button sbutton5;
        private Label label12;
        private Panel panel1;
    }
}