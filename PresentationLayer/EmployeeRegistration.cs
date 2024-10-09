using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }
        void ClearField()
        {
            txtemployeename.Text = "";
            txtemplusername.Text = "";
            txtemployeepassword.Text = "";
            txtcnfrmpassword.Text = "";
            txtemail.Text = "";
            txtempphone.Text = "";


        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            Employee er = new Employee();
            er.Fullname = txtemployeename.Text;
            er.username = txtemplusername.Text;
            er.password = txtemployeepassword.Text;
            er.cnfirmpassword = txtcnfrmpassword.Text;
            er.email = txtemail.Text;
            er.phone = txtempphone.Text;
            er.Registration();
            MessageBox.Show("Registered Success!");
            ClearField();

            Form1 f = new Form1();
            f.Show();
            this.Hide();


        }

        private void alreadylable_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
