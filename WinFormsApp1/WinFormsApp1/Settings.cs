using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Settings : Form
    {
        string str;
        public Settings(string name)
        {
            str = name;
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
        
        private void Settings_Load(object sender, EventArgs e)
        {

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
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill all information");
                }
                else if (IDExists(textBox1.Text))
                {
                    MessageBox.Show("User already exists, please try a different username");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        string query = "insert into users values(@Username,@Password)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();


                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User registered successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to register user, please try again.");
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured :" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill all information");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))

                {
                    MessageBox.Show("Enter username");
                }
                else
                {
                    if(str == textBox1.Text)
                    {
                        MessageBox.Show("User is currenly using the app");
                    }
                    else {
                        using (SqlConnection con = new SqlConnection(Connection.con))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("delete users WHERE Username=@user", con);
                            cmd.Parameters.AddWithValue("@user", textBox1.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User deleted successfully!");


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");

            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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
    }
}
