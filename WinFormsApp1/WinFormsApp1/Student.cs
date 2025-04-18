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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;
namespace SchoolManagement
{
    public partial class Student : Form
    {
        string gender;
        public Student()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Student";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            
        }

        
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stdname.Text) ||
                    string.IsNullOrWhiteSpace(ID.Text) ||
                    string.IsNullOrWhiteSpace(DoB.Text) ||
                    (male.Checked == false && female.Checked == false) ||
                    string.IsNullOrWhiteSpace(address.Text) ||
                    string.IsNullOrWhiteSpace(Fathername.Text) ||
                    string.IsNullOrWhiteSpace(Mothername.Text) ||
                    string.IsNullOrWhiteSpace(phone.Text) ||
                    string.IsNullOrWhiteSpace(Ephone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                    string gender = male.Checked ? "Male" : "Female";
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into student values(@id,@name,@Dob,@gender,@address,@Fname,@Mname,@phone,@Pphone)", con);
                        cmd.Parameters.AddWithValue("@id", ID.Text);
                        cmd.Parameters.AddWithValue("@name", stdname.Text);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(DoB.Text));
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@Fname", Fathername.Text);
                        cmd.Parameters.AddWithValue("@Mname", Mothername.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@Pphone", Ephone.Text);

                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adt.Fill(dataTable);

                        RefreshData();
                        MessageBox.Show("Data added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid information");
            }

        }


        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Student";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stdname.Text) ||
                    
                    string.IsNullOrWhiteSpace(DoB.Text) ||
                    (male.Checked == false && female.Checked == false) ||
                    string.IsNullOrWhiteSpace(address.Text) ||
                    string.IsNullOrWhiteSpace(Fathername.Text) ||
                    string.IsNullOrWhiteSpace(Mothername.Text) ||
                    string.IsNullOrWhiteSpace(phone.Text) ||
                    string.IsNullOrWhiteSpace(Ephone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                    gender = male.Checked ? "Male" : "Female";

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET StudentName=@name, DateofBirth=@Dob, Gender=@gender, Address=@address, FathersName=@Fname, MothersName=@Mname, PhoneNo=@phone, ParentNo=@Pphone WHERE StudentID=@id", con);
                        cmd.Parameters.AddWithValue("@id",ID.Text);
                        cmd.Parameters.AddWithValue("@name", stdname.Text);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(DoB.Text));
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@Fname", Fathername.Text);
                        cmd.Parameters.AddWithValue("@Mname", Mothername.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@Pphone", Ephone.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    RefreshData();
                    MessageBox.Show("Data updated successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database....");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            stdname.Text = "";
            Fathername.Text = "";
            Mothername.Text = "";
            address.Text = "";
            phone.Text = "";
            DoB.Value = DateTime.Now;
            Ephone.Text = "";
            searchbox.Text = "";
            male.Checked = false;
            female.Checked = false;

            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID.Text))

                {
                    MessageBox.Show("Fill up ID or search ID");
                }
                else
                {
                    MessageBox.Show("Please fill all information");

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete student WHERE StudentID=@id", con);
                        cmd.Parameters.AddWithValue("@id", ID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshData();
                        MessageBox.Show("Data deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database....");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student WHERE StudentID=@id", con);
                cmd.Parameters.AddWithValue("@id", searchbox.Text);
                
                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt= new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    ID.Text = reader["StudentID"].ToString();
                    stdname.Text = reader["StudentName"].ToString();
                    Fathername.Text = reader["FathersName"].ToString();
                    Mothername.Text = reader["MothersName"].ToString();
                    address.Text = reader["Address"].ToString();
                    phone.Text = reader["PhoneNo"].ToString();
                    DoB.Text = reader["DateofBirth"].ToString();
                    Ephone.Text = reader["ParentNo"].ToString();
                    gender = reader["Gender"].ToString();
                    if (gender =="Male") male.Checked = true;
                    else female.Checked = true;

                }
                else
                {
                    MessageBox.Show("ID not found.");
                    
                }

                reader.Close();



            }
        }
    }
}
