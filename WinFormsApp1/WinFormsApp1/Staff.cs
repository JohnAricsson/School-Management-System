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
using System.Net;
using System.Security.Cryptography;

namespace SchoolManagement
{
    public partial class Staff : Form
    {
        string sgender;
        public Staff()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Staff";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }

           
        }       
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from staff";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void sbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sID.Text) ||
                    string.IsNullOrWhiteSpace(sname.Text) ||
                    string.IsNullOrWhiteSpace(sDoB.Text) ||
                    (smale.Checked == false && sfemale.Checked == false) ||

                    string.IsNullOrWhiteSpace(Job.Text) ||
                    string.IsNullOrWhiteSpace(sjoinDate.Text) ||
                    string.IsNullOrWhiteSpace(saddress.Text) ||
                    string.IsNullOrWhiteSpace(sphone.Text) ||
                    string.IsNullOrWhiteSpace(sEphone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                    sgender = smale.Checked ? "Male" : "Female";
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into staff values(@id,@name,@Job,@DoB,@joindate,@gender,@address,@phone,@Ephone)", con);
                        cmd.Parameters.AddWithValue("@id", sID.Text);
                        cmd.Parameters.AddWithValue("@name", sname.Text);
                        cmd.Parameters.AddWithValue("@Job", Job.Text);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(sDoB.Text));
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(sjoinDate.Text));
                        cmd.Parameters.AddWithValue("@gender", sgender);
                        cmd.Parameters.AddWithValue("@address", saddress.Text);                                               
                        cmd.Parameters.AddWithValue("@phone", sphone.Text);
                        cmd.Parameters.AddWithValue("@Ephone", sEphone.Text);

                        cmd.ExecuteNonQuery();

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

        private void sbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sID.Text))

                {
                    MessageBox.Show("Fill up ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete staff WHERE StaffID=@id", con);
                        cmd.Parameters.AddWithValue("@id", sID.Text);
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

        private void sbutton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sname.Text) ||
                    string.IsNullOrWhiteSpace(sDoB.Text) ||
                    (smale.Checked == false && sfemale.Checked == false) ||

                    string.IsNullOrWhiteSpace(Job.Text) ||
                    string.IsNullOrWhiteSpace(sjoinDate.Text) ||
                    string.IsNullOrWhiteSpace(saddress.Text) ||
                    string.IsNullOrWhiteSpace(sphone.Text) ||
                    string.IsNullOrWhiteSpace(sEphone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                    sgender = smale.Checked ? "Male" : "Female";
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Staff SET FullName=@name, DateofBirth=@Dob,JoiningDate=@joindate, Gender=@gender, Address=@address, Job=@job, PhoneNo=@phone, EmgPhone=@Ephone WHERE StaffID=@id", con);
                        cmd.Parameters.AddWithValue("@id", sID.Text);
                        cmd.Parameters.AddWithValue("@name", sname.Text);
                        cmd.Parameters.AddWithValue("@Job", Job.Text);
                        cmd.Parameters.AddWithValue("@address", saddress.Text);
                        cmd.Parameters.AddWithValue("@gender", sgender);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(sDoB.Text));
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(sjoinDate.Text));
                        cmd.Parameters.AddWithValue("@phone", sphone.Text);
                        cmd.Parameters.AddWithValue("@Ephone", sEphone.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    RefreshData();
                    MessageBox.Show("Data updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid information");
            }
        }

        private void sbutton5_Click(object sender, EventArgs e)
        {
            sID.Text = "";
            sname.Text = "";
            Job.Text = "";
            saddress.Text = "";
            sphone.Text = "";
            sDoB.Value = DateTime.Now;
            sjoinDate.Value = DateTime.Now;
            sEphone.Text = "";
            ssearchbox.Text = "";
            smale.Checked = false;
            sfemale.Checked = false;

            RefreshData();
        }

        private void sbutton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from staff WHERE StaffID=@id", con);
                cmd.Parameters.AddWithValue("@id", ssearchbox.Text);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    sID.Text = reader["StaffID"].ToString();
                    sname.Text = reader["FullName"].ToString();                    
                    Job.Text = reader["Job"].ToString();
                    saddress.Text = reader["Address"].ToString();
                    sphone.Text = reader["PhoneNO"].ToString();
                    sDoB.Text = reader["DateofBirth"].ToString();
                    sjoinDate.Text = reader["JoiningDate"].ToString();
                    sEphone.Text = reader["EmgPhone"].ToString();
                    sgender = reader["Gender"].ToString();
                    if (sgender == "Male") smale.Checked = true;
                    else sfemale.Checked = true;

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
