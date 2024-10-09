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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using DBAccessLayer;

namespace PresentationLayer
{
    public partial class AdmissionForm : Form
    {
        public AdmissionForm()
        {
            InitializeComponent();           
        }
        Patterns p = new Patterns(); 
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                
                if (!Regex.IsMatch(s.scnic = txtcnic.Text, Patterns.cnicpattern))
                {
                    MessageBox.Show("Enter Valid CNIC");
                }
                else if (!Regex.IsMatch(s.Mobileno = txtmobile.Text, Patterns.contactpattern))
                {
                    MessageBox.Show("Enter Valid Mobile Number");
                }
                else
                {
                    s.rollno = int.Parse(txtrollno.Text);
                    s.sname = txtsname.Text;
                    s.SFname = txtfname.Text;

                    s.sdob = dtpdob.Value.ToShortDateString();
                    s.gender = "Male";
                    if (rdbtnfemale.Checked)
                    {
                        s.gender = "Female";
                    }
                    s.scity = txtcity.Text;

                    s.email = txtemail.Text;
                    s.standard = cmbxdegree.SelectedItem.ToString();
                    s.year = cmbxyear.SelectedItem.ToString();
                    s.Address = txtaddress.Text;
                    s.course = cmbcourse.Text;
                    s.StudentsRegistration();

                    MessageBox.Show("Dear Student, Your Data Inserted Successfully.. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtrollno.Text = "";
            txtsname.Text = "";
            txtfname.Text = "";
            txtcnic.Text = "";
            dtpdob.Text = "";
            rdbtnmale.Checked = false ;
            txtcity.Text = "";
            txtemail.Text = "";
            txtmobile.Text = "";
            txtaddress.Text = "";
            cmbcourse.Text = "--Select--";
          
        }

        public void CourseList()
        {
            string q = "Select Distinct CourseName from CourseDetails";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            while (sdr.Read())
            {
                cmbcourse.Items.Add(sdr["CourseName"]);

            }
        }


        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            CourseList();
        }
    }
}
