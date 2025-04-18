using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace SchoolManagement
{
    public partial class Class : Form
    {

        public Class()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from class";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Enabled = false;
        }

        private void sbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cID.Text) ||
                    string.IsNullOrWhiteSpace(cName.Text))

                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO class (classID, className) VALUES(@id, @name)", con);
                        cmd.Parameters.AddWithValue("@id", cID.Text);
                        cmd.Parameters.AddWithValue("@name", cName.Text);

                        cmd.ExecuteNonQuery();
                        RefreshData();
                        MessageBox.Show("class added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from class";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void sbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cID.Text))

                {
                    MessageBox.Show("Fill up ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete class WHERE classID=@id", con);
                        cmd.Parameters.AddWithValue("@id", cID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshData();
                        MessageBox.Show("Class deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }

        private void Class_Load(object sender, EventArgs e)
        {

        }

        private void sbutton5_Click(object sender, EventArgs e)
        {
            cID.Text = "";
            cName.Text = "";
            ssearchbox.Text = "";
            RefreshData();
        }

        private void sbutton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from class WHERE classID=@id", con);
                cmd.Parameters.AddWithValue("@id", ssearchbox.Text);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    cID.Text = reader["classID"].ToString();
                    cName.Text = reader["className"].ToString();


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
