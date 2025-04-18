using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Form3 : Form
    {
        public Form3()
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
        public bool IDExists(string user)
        {

            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query1 = "SELECT COUNT(*) FROM users WHERE Username = @userName";

                SqlCommand cmd1 = new SqlCommand(query1, con);

                cmd1.Parameters.AddWithValue("@userName", user);



                int count = (int)cmd1.ExecuteScalar();
                if (count > 0) { return true; }
                else { return false; }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else {
                if (textBox3.Text == "Reset")
                {
                    try
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("Please fill username and password");
                        }
                        else if (!IDExists(textBox1.Text))
                        {
                            MessageBox.Show("User does not exist!");
                        }

                        else
                        {

                            using (SqlConnection con = new SqlConnection(Connection.con))
                            {
                                con.Open();
                                string query = "Update users set Password = @pass where Username=@user";

                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {

                                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Password updated successfully!");
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured :" + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Wrong security key, please enter valid information");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
