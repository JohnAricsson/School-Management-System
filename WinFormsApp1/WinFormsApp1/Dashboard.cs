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
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {

            InitializeComponent();
            using (SqlConnection con = new SqlConnection(Connection.con))
            {
                con.Open();
                string q1 = "Select Count(*) as total_rows from student";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                object r1 = (int)cmd1.ExecuteScalar();
                int tr1 = Convert.ToInt32(r1);

                StudentNo.Text = tr1.ToString();

                string q2 = "Select Count(*) as total_rows from teacher";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                object r2 = (int)cmd2.ExecuteScalar();
                int tr2 = Convert.ToInt32(r2);

                TeacherNo.Text = tr2.ToString();

                string q3 = "Select Count(*) as total_rows from staff";
                SqlCommand cmd3 = new SqlCommand(q3, con);
                object r3 = (int)cmd3.ExecuteScalar();
                int tr3 = Convert.ToInt32(r3);

                StaffNo.Text = tr3.ToString();
               
                date.Text = DateTime.Now.ToLongDateString();
                time.Text = DateTime.Now.ToLongTimeString();

            }

        }
        public void setName(string name){
            LABEL.Text = name;
        }
        

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
