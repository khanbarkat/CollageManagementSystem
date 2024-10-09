using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void btnadmission_Click_1(object sender, EventArgs e)
        {
            AdmissionForm adm = new AdmissionForm();
            adm.TopLevel = false;
            panel2.Controls.Add(adm);
            adm.BringToFront();
            adm.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            Student_Details sd = new Student_Details();
            sd.TopLevel = false;
            panel2.Controls.Add(sd);
            sd.BringToFront();
            sd.Show();
        }

        private void btnupgrade_Click(object sender, EventArgs e)
        {
            Upgrade_Student_Standard std = new Upgrade_Student_Standard();
            std.TopLevel = false;
            panel2.Controls.Add(std);
            std.BringToFront();
            std.Show();
        }

        private void btnfee_Click(object sender, EventArgs e)
        {
            PendingFee f = new PendingFee();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

       

        private void btnteacherseacrh_Click_1(object sender, EventArgs e)
        {
            Teacher_Details td = new Teacher_Details();
            td.TopLevel = false;
            panel2.Controls.Add(td);
            td.BringToFront();
            td.Show();
        }

       

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StudentAttendance sa = new StudentAttendance();
            sa.TopLevel = false;
            panel2.Controls.Add(sa);
            sa.BringToFront();
            sa.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void btnpenfee_Click(object sender, EventArgs e)
        {
            PendingFeeRecord sa = new PendingFeeRecord();
            sa.TopLevel = false;
            panel2.Controls.Add(sa);
            sa.BringToFront();
            sa.Show();
        }
    }
}
