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
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace SchoolManagement
{
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Section";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            };
        }

        private void Section_Load(object sender, EventArgs e)
        {

        }

        private void cName_TextChanged(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Section";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public bool ClassIDExists(int classID)
        {

            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM class WHERE classID = @classID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void sbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(secID.Text) ||
                    string.IsNullOrWhiteSpace(cID.Text) ||
                    string.IsNullOrWhiteSpace(secName.Text))

                {
                    MessageBox.Show("Please fill all information");
                }
                else if (!ClassIDExists(int.Parse(cID.Text)))
                {
                    MessageBox.Show("Class does not exist");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO section (sectionID, classID, sectionName) VALUES(@id, @cid,@name)", con);


                        cmd.Parameters.AddWithValue("@id", secID.Text);

                        cmd.Parameters.AddWithValue("@cid", cID.Text);
                        cmd.Parameters.AddWithValue("@name", secName.Text);

                        cmd.ExecuteNonQuery();
                        RefreshData();
                        MessageBox.Show("Section added successfully!");



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }

        private void sbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(secID.Text))

                {
                    MessageBox.Show("Fill up section ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete section WHERE sectionID=@id", con);
                        cmd.Parameters.AddWithValue("@id", secID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshData();
                        MessageBox.Show("Section deleted successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }

        private void sbutton5_Click(object sender, EventArgs e)
        {
            cID.Text = "";
            secID.Text = "";
            secName.Text = "";
            ssearchbox.Text = "";
            RefreshData();
        }

        private void sbutton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from section WHERE sectionID=@id", con);
                cmd.Parameters.AddWithValue("@id", ssearchbox.Text);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    secID.Text = reader["sectionID"].ToString();
                    cID.Text = reader["classID"].ToString();
                    secName.Text = reader["sectionName"].ToString();


                }
                else
                {
                    MessageBox.Show("ID not found.");

                }

                reader.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
