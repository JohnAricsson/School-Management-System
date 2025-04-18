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
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;

namespace SchoolManagement
{
    public partial class Teacher : Form
    {
        string tgender;
        public Teacher()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Teacher";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }

           
        }
        
        
        private void Teacher_Load(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from teacher";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void tbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text) ||
                    string.IsNullOrWhiteSpace(tname.Text) ||
                    string.IsNullOrWhiteSpace(tDoB.Text) ||
                    (tmale.Checked == false && tfemale.Checked == false) ||
                    string.IsNullOrWhiteSpace(tdepartment.Text) ||
                    string.IsNullOrWhiteSpace(tposition.Text) ||
                    string.IsNullOrWhiteSpace(tjoinDate.Text) ||
                    string.IsNullOrWhiteSpace(taddress.Text) ||
                    string.IsNullOrWhiteSpace(tphone.Text) ||
                    string.IsNullOrWhiteSpace(tEphone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                     tgender = tmale.Checked ? "Male" : "Female";
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into teacher values(@id,@name,@department,@position,@address,@gender,@Dob,@joindate,@phone,@Ephone)", con);
                        cmd.Parameters.AddWithValue("@id", tID.Text);
                        cmd.Parameters.AddWithValue("@name", tname.Text);
                        cmd.Parameters.AddWithValue("@department", tdepartment.Text);
                        cmd.Parameters.AddWithValue("@position", tposition.Text);
                        cmd.Parameters.AddWithValue("@address", taddress.Text);
                        cmd.Parameters.AddWithValue("@gender", tgender);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(tDoB.Text));
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(tjoinDate.Text));
                        cmd.Parameters.AddWithValue("@phone", tphone.Text);
                        cmd.Parameters.AddWithValue("@Ephone", tEphone.Text);

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

        private void tbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text))

                {
                    MessageBox.Show("Fill up ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete teacher WHERE EmployeeId=@id", con);
                        cmd.Parameters.AddWithValue("@id", tID.Text);
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

        private void tbutton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text) ||
                    string.IsNullOrWhiteSpace(tname.Text) ||
                    string.IsNullOrWhiteSpace(tDoB.Text) ||
                    (tmale.Checked == false && tfemale.Checked == false) ||
                    string.IsNullOrEmpty(tdepartment.Text) ||
                    string.IsNullOrWhiteSpace(tposition.Text) ||
                    string.IsNullOrWhiteSpace(tjoinDate.Text) ||
                    string.IsNullOrWhiteSpace(taddress.Text) ||
                    string.IsNullOrWhiteSpace(tphone.Text) ||
                    string.IsNullOrWhiteSpace(tEphone.Text))
                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {
                    tgender = tmale.Checked ? "Male" : "Female";
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Teacher SET FullName=@name, DateofBirth=@Dob,JoiningDate=@joindate, Gender=@gender, Address=@address, Department=@department, Position=@position, PhoneNo=@phone, EmgPhone=@Ephone WHERE EmployeeId=@id", con);
                        cmd.Parameters.AddWithValue("@id", tID.Text);
                        cmd.Parameters.AddWithValue("@name", tname.Text);
                        cmd.Parameters.AddWithValue("@Dob", DateTime.Parse(tDoB.Text));
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(tjoinDate.Text));
                        cmd.Parameters.AddWithValue("@gender", tgender);
                        cmd.Parameters.AddWithValue("@address", taddress.Text);
                        cmd.Parameters.AddWithValue("@position", tposition.Text);
                        cmd.Parameters.AddWithValue("@department", tdepartment.Text);
                        cmd.Parameters.AddWithValue("@phone", tphone.Text);
                        cmd.Parameters.AddWithValue("@Ephone", tEphone.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    RefreshData();
                    MessageBox.Show("Data added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid information");
            }

        }

        private void tbutton5_Click(object sender, EventArgs e)
        {
            tID.Text = "";
            tname.Text = "";
            tposition.Text = "";
            tdepartment.Text = "";
            taddress.Text = "";
            tphone.Text = "";
            tDoB.Value = DateTime.Now;
            tjoinDate.Value = DateTime.Now;
            tEphone.Text = "";
            tsearchbox.Text = "";
            tmale.Checked = false;
            tfemale.Checked = false;

            RefreshData();
        }

        private void tbutton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from teacher WHERE EmployeeId=@id", con);
                cmd.Parameters.AddWithValue("@id", tsearchbox.Text);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {

                    tID.Text = reader["EmployeeID"].ToString();
                    tname.Text = reader["FullName"].ToString();
                    tdepartment.Text = reader["Department"].ToString();
                    tposition.Text = reader["Position"].ToString();
                    taddress.Text = reader["Address"].ToString();
                    tphone.Text = reader["PhoneNO"].ToString();
                    tDoB.Text = reader["DateofBirth"].ToString();
                    tjoinDate.Text= reader["JoiningDate"].ToString();
                    tEphone.Text = reader["EmgPhone"].ToString();
                    tgender = reader["Gender"].ToString();
                    if (tgender == "Male") tmale.Checked = true;
                    else tfemale.Checked = true;

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
