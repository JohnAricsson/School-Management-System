using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            textBox1.Click += textbox1_Click;
            textBox2.Click += textbox2_Click;

        }
        public void textbox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter username")
            {
                textBox1.Text = "";
            }
        }
        public void textbox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter password")
            {
                textBox2.Text = "";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        string query = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Password", textBox2.Text);


                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                           
                            if (dt.Rows.Count > 0)
                            {

                                Homepage adm = new Homepage(textBox1.Text);
                                
                                adm.Show();
                                this.Hide();
                                

                            }
                            else
                            {
                                MessageBox.Show("Invalid login information, please try again");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login information, please try again");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }
    }
}
