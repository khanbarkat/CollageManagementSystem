using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class Add_Teachers : Form
    {
        public Add_Teachers()
        {
            InitializeComponent();
           
        }
        Patterns p = new Patterns();
        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher t = new Teacher();

                if (!Regex.IsMatch(t.cnic = txtteachercnic.Text, Patterns.cnicpattern))
                {
                    MessageBox.Show("Enter Valid CNIC");
                }
                else if (!Regex.IsMatch(t.contact = txtmobile.Text, Patterns.contactpattern))
                {
                    MessageBox.Show("Enter Valid Mobile Number");
                }
                else
                {
                    t.tname = txttname.Text;
             
                    t.dob = dtpdob.Value.ToShortDateString();
                    t.gender = "Male";
                    if (rdbtnfemale.Checked)
                    {
                        t.gender = "Female";
                    }
                    t.qualification = txtqualification.Text;
                    t.experience = int.Parse(txtexp.Text);
                    t.email = txtemail.Text;
                    t.subject = cmbxsubject.SelectedItem.ToString();
                    t.year = cmbxyear.SelectedItem.ToString();
                    t.address = txttaddress.Text;
                    t.AddTeacher();

                    MessageBox.Show(" Data Inserted Successfully.. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txttname.Text = "";
            txtemail.Text = "";
            txtexp.Text = "";
            dtpdob.Text = "";
            rdbtnmale.Checked = false;
            txtqualification.Text = "";
            txtteachercnic.Text = "";
            txtmobile.Text = "";
            txttaddress.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher t = new Teacher();

                if (!Regex.IsMatch(t.cnic = txtteachercnic.Text, Patterns.cnicpattern))
                {
                    MessageBox.Show("Enter Valid CNIC");
                }
                else if (!Regex.IsMatch(t.contact = txtmobile.Text, Patterns.contactpattern))
                {
                    MessageBox.Show("Enter Valid Mobile Number");
                }
                else
                {
                    t.tid =int.Parse(txtid.Text);
                    t.tname = txttname.Text;

                    t.dob = dtpdob.Value.ToShortDateString();
                    t.gender = "Male";
                    if (rdbtnfemale.Checked)
                    {
                        t.gender = "Female";
                    }
                    t.qualification = txtqualification.Text;
                    t.experience = int.Parse(txtexp.Text);
                    t.email = txtemail.Text;
                    t.subject = cmbxsubject.SelectedItem.ToString();
                    t.year = cmbxyear.SelectedItem.ToString();
                    t.address = txttaddress.Text;
                    t.UpdateTeacher();

                    DialogResult dr=MessageBox.Show(" Updated Successfully.. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
