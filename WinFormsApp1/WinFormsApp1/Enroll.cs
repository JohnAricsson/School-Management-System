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
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Enrollment";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            };
        }

        private void Enroll_Load(object sender, EventArgs e)
        {

        }
        public bool IDExists(int classID, int secID, int StuID)
        {

            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query1 = "SELECT COUNT(*) FROM class WHERE classID = @classID";
                string query2 = "SELECT COUNT(*) FROM student WHERE studentID = @stuID";
                string query3 = "SELECT COUNT(*) FROM section WHERE sectionID = @secID";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd1.Parameters.AddWithValue("@classID", classID);
                cmd2.Parameters.AddWithValue("@stuID", StuID);
                cmd3.Parameters.AddWithValue("@secID", secID);

                int count = (int)cmd1.ExecuteScalar() + (int)cmd2.ExecuteScalar() + (int)cmd3.ExecuteScalar();
                if (count > 2) { return true; }
                else { return false; }


            }
        }
        public bool secNameExists(string secName,int classID)
        {

            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query1 = "SELECT COUNT(*) FROM enrollment WHERE sectionName = @secName and classID=@cName";
                

                SqlCommand cmd1 = new SqlCommand(query1, con);
                
                cmd1.Parameters.AddWithValue("@secName", secName);

                cmd1.Parameters.AddWithValue("@cName", classID);

                int count = (int)cmd1.ExecuteScalar();
                if (count > 0) { return true; }
                else { return false; }


            }
        }
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Enrollment";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void sbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sID.Text) ||
                    string.IsNullOrWhiteSpace(cID.Text) ||
                    string.IsNullOrWhiteSpace(secID.Text))

                {
                    MessageBox.Show("Please fill all information");
                }
                else if (!IDExists(int.Parse(cID.Text), int.Parse(secID.Text), int.Parse(sID.Text)))
                {
                    MessageBox.Show("ID does not exist, make sure to enter existing ID");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand upcmd = new SqlCommand("Select sectionName from section where sectionID=@secID", con);
                        upcmd.Parameters.AddWithValue("secID", secID.Text);
                        string str = upcmd.ExecuteScalar()?.ToString();


                        SqlCommand cmd = new SqlCommand("INSERT INTO Enrollment (StudentID, classID, sectionID,sectionName) VALUES(@id, @cid,@sid,@sname)", con);


                        cmd.Parameters.AddWithValue("@id", sID.Text);
                        cmd.Parameters.AddWithValue("@cid", cID.Text);
                        cmd.Parameters.AddWithValue("@sid", secID.Text);
                        cmd.Parameters.AddWithValue("@sname", str);

                        cmd.ExecuteNonQuery();
                        RefreshData();
                        MessageBox.Show("Enrolled successfully!");


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
                if (string.IsNullOrWhiteSpace(sID.Text))

                {
                    MessageBox.Show("Fill up student ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete Enrollment WHERE studentID=@id", con);
                        cmd.Parameters.AddWithValue("@id", sID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshData();
                        MessageBox.Show("Enrollment deleted successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Enrollment WHERE studentID=@id", con);
                cmd.Parameters.AddWithValue("@id", ssearchbox.Text);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                sdt.Fill(dtt);
                dataGridView1.DataSource = dtt;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    sID.Text = reader["studentID"].ToString();
                    cID.Text = reader["classID"].ToString();
                    secID.Text = reader["sectionID"].ToString();


                }
                else
                {
                    MessageBox.Show("ID not found.");

                }

                reader.Close();
            }
        }

        private void sbutton5_Click(object sender, EventArgs e)
        {
            cID.Text = "";
            sID.Text = "";
            secID.Text = "";
            ssearchbox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            count.Text = "0";
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)||
                    (string.IsNullOrWhiteSpace(textBox1.Text) ))                
                {
                    MessageBox.Show("Please enter section name and class ID");
                }
                else if (!secNameExists(textBox1.Text,int.Parse(textBox2.Text)))
                {
                    MessageBox.Show("Section or class does not exist");
                }
                else
                {

                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();

                        
                        SqlCommand cmd1 = new SqlCommand("Select Count(*) as total_rows from Enrollment where sectionName=@sectionName and classID=@cID", con);
                        cmd1.Parameters.AddWithValue("@sectionName", textBox1.Text);
                        cmd1.Parameters.AddWithValue("@cID", int.Parse(textBox2.Text));
                        object r1 = (int)cmd1.ExecuteScalar();
                        int tr1 = Convert.ToInt32(r1);

                        count.Text = tr1.ToString();
                        


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }
    }
}
