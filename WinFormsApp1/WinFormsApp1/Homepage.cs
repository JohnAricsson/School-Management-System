using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Homepage : Form
    {
        Dashboard dashboard;
        Student sdt;
        Teacher teacher;
        Staff staff;
        Class clas;
        Section sec;
        Enroll enroll;
        Assign ass;
        Settings set;
        string str;
        private bool MenuExpand;
        
        public Homepage(string name)
        {
            str = name;
            InitializeComponent();            
            dashboard = new Dashboard();
            dashboard.setName(str);
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(dashboard);
            FormPanel.Tag = dashboard;
            dashboard.BringToFront();
            dashboard.Show();

        }


        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard = new Dashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(dashboard);
            FormPanel.Tag = dashboard;
            dashboard.BringToFront();
            dashboard.setName(str);
            dashboard.Show();


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sdt == null)
            {
                sdt = new Student();
                sdt.TopLevel = false;
                sdt.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(sdt);
                FormPanel.Tag = sdt;
                sdt.BringToFront();
                sdt.Show();
            }
            else
            {
                sdt.BringToFront();
                sdt.Show();
            }
        }

        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (teacher == null)
            {
                teacher = new Teacher();
                teacher.TopLevel = false;
                teacher.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(teacher);
                FormPanel.Tag = teacher;
                teacher.BringToFront();
                teacher.Show();
            }
            else
            {
                teacher.BringToFront();
                teacher.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (staff == null)
            {
                staff = new Staff();
                staff.TopLevel = false;
                staff.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(staff);
                FormPanel.Tag = staff;
                staff.BringToFront();
                staff.Show();
            }
            else
            {
                staff.BringToFront();
                staff.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!MenuExpand)
            {
                Dropdown.Height += 10;
                if (Dropdown.Height >= 218)
                {
                    timer1.Stop();
                    MenuExpand = true;
                }
            }
            else
            {
                Dropdown.Height -= 10;
                if (Dropdown.Height <= 46)
                {
                    timer1.Stop();
                    MenuExpand = false;
                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)//class
        {
            if (clas == null)
            {
                clas = new Class();
                clas.TopLevel = false;
                clas.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(clas);
                FormPanel.Tag = clas;
                clas.BringToFront();
                clas.Show();
            }
            else
            {
                clas.BringToFront();
                clas.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)//section
        {
            if (sec == null)
            {
                sec = new Section();
                sec.TopLevel = false;
                sec.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(sec);
                FormPanel.Tag = sec;
                sec.BringToFront();
                sec.Show();
            }
            else
            {
                sec.BringToFront();
                sec.Show();
            }

        }

        private void button7_Click(object sender, EventArgs e)//enroll
        {
            if (enroll == null)
            {
                enroll = new Enroll();
                enroll.TopLevel = false;
                enroll.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(enroll);
                FormPanel.Tag = enroll;
                enroll.BringToFront();
                enroll.Show();
            }
            else
            {
                enroll.BringToFront();
                enroll.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)//assign teacher

        {
            if (ass == null)
            {
                ass = new Assign();
                ass.TopLevel = false;
                ass.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(ass);
                FormPanel.Tag = ass;
                ass.BringToFront();
                ass.Show();
            }
            else
            {
                ass.BringToFront();
                ass.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (set == null)
            {
                set = new Settings(str);
                set.TopLevel = false;
                set.Dock = DockStyle.Fill;
                FormPanel.Controls.Add(set);
                FormPanel.Tag = set;
                set.BringToFront();
                set.Show();
            }
            else
            {
                set.BringToFront();
                set.Show();
            }

        }
    }
}
