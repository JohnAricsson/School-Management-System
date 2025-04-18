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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{
    public partial class Assign : Form
    {
        public Assign()
        {
            InitializeComponent();
            
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Assign order by teacherID,Time";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            };

        }
        private void RefreshData()
        {
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query = "Select * from Assign order by teacherID, Time";
                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public bool IDExists(int secID, int tID)
        {

            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string query1 = "SELECT COUNT(*) FROM section WHERE sectionID = @secID";
                string query2 = "SELECT COUNT(*) FROM teacher WHERE EmployeeID = @tcID";

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd1.Parameters.AddWithValue("@secID", secID);
                cmd2.Parameters.AddWithValue("@tcID", tID);


                int count = (int)cmd1.ExecuteScalar() + (int)cmd2.ExecuteScalar();
                if (count > 1) { return true; }
                else { return false; }


            }
        }
        private void sbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text) ||
                    string.IsNullOrWhiteSpace(sID.Text) ||
                    string.IsNullOrWhiteSpace(days.Text) ||
                    string.IsNullOrWhiteSpace(time.Text) )
                    
                {
                    MessageBox.Show("Please fill all information");
                    return;
                }

                else if (!IDExists(int.Parse(sID.Text), int.Parse(tID.Text)))
                {
                    MessageBox.Show("ID does not exist, make sure to enter existing ID");
                    return;
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();


                        SqlCommand upcmd1 = new SqlCommand("SELECT sectionName FROM section WHERE sectionID = @secID", con);
                        upcmd1.Parameters.AddWithValue("@secID", sID.Text);
                        string sectionName = upcmd1.ExecuteScalar()?.ToString();


                        SqlCommand upcmd2 = new SqlCommand("SELECT FullName FROM teacher WHERE employeeID = @tID", con);
                        upcmd2.Parameters.AddWithValue("@tID", tID.Text);
                        string teacherName = upcmd2.ExecuteScalar()?.ToString();


                        SqlCommand cmd = new SqlCommand("INSERT INTO Assign (TeacherID, TeacherName, SectionID, SectionName, Weekdays, Time, Salary) VALUES (@tid, @tname, @sid, @sname, @days, @time, @sal)", con);
                        cmd.Parameters.AddWithValue("@tid", tID.Text);
                        cmd.Parameters.AddWithValue("@tname", teacherName);
                        cmd.Parameters.AddWithValue("@sid", sID.Text);
                        cmd.Parameters.AddWithValue("@sname", sectionName);
                        cmd.Parameters.AddWithValue("@days", days.Text);
                        cmd.Parameters.AddWithValue("@time", time.Text);
                        cmd.Parameters.AddWithValue("@sal", salary.Text);

                        cmd.ExecuteNonQuery();

                        RefreshData();
                        MessageBox.Show("Assigned successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again: " + ex.Message);
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                tID.Text = selectedRow.Cells["TeacherID"].Value.ToString();
                sID.Text = selectedRow.Cells["SectionID"].Value.ToString();
                days.Text = selectedRow.Cells["Weekdays"].Value.ToString();              

                time.Text = selectedRow.Cells["Time"].Value.ToString();
                salary.Text = selectedRow.Cells["Salary"].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text) ||
                    string.IsNullOrWhiteSpace(sID.Text) ||
                    string.IsNullOrWhiteSpace(days.Text) ||
                    string.IsNullOrWhiteSpace(time.Text) ||
                    string.IsNullOrWhiteSpace(salary.Text))

                {
                    MessageBox.Show("Please fill all information");
                }
                else
                {


                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();

                        SqlCommand upcmd1 = new SqlCommand("Select sectionName from section where sectionID=@secID", con);
                        upcmd1.Parameters.AddWithValue("@secID", sID.Text);
                        string str1 = upcmd1.ExecuteScalar()?.ToString();

                        SqlCommand cmd = new SqlCommand("UPDATE Assign SET sectionName=@sname, Weekdays=@days,Time=@time, salary=@sal   WHERE teacherID=@tid and SectionID=@sid", con);
                        cmd.Parameters.AddWithValue("@tid", tID.Text);

                        cmd.Parameters.AddWithValue("@sid", sID.Text);
                        cmd.Parameters.AddWithValue("@sname", str1);
                        cmd.Parameters.AddWithValue("@days", days.Text);
                        cmd.Parameters.AddWithValue("@time", time.Text);
                        cmd.Parameters.AddWithValue("@sal", salary.Text);



                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    RefreshData();
                    MessageBox.Show("Data updated successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tID.Text = "";
            sID.Text = "";
            days.Text = "";
            
            time.Text = "";
            salary.Text = "";

            RefreshData();
        }

        private void sbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tID.Text))

                {
                    MessageBox.Show("Fill up teacher ID or search ID");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Connection.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete Assign WHERE teacherID=@id and SectionID=@secID", con);
                        cmd.Parameters.AddWithValue("@id", tID.Text);
                        cmd.Parameters.AddWithValue("@secid", sID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        RefreshData();
                        MessageBox.Show("Data deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");

            }
        }

        private void Assign_Load(object sender, EventArgs e)
        {

        }
    }
}
