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
using BussinessLayer;

namespace PresentationLayer
{
    public partial class Fee_Form : Form
    {
        public Fee_Form()
        {
            InitializeComponent();
        }
        Fee f = new Fee();
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                f.sid =int.Parse(txtreg.Text);
                f.Date = dtpkrfee.Value.ToShortDateString();
                f.fee = int.Parse(txtfee.Text);
                f.StudentFee();
                MessageBox.Show("Your Fees Submitted..");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtreg_TextChanged(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
            if (txtreg.Text == "")
            {
                lblname.Text = "";
                lblstandard.Text = "";

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(constr);
                    con.Open();
                    string q = "Select sname,standard from StudentAdmission where std_id='" + txtreg.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        lblname.Text = dr.GetValue(0).ToString();
                        lblstandard.Text = dr.GetValue(1).ToString();
                    }
                    /*else
                    {
                        MessageBox.Show("Sorry '" + txtreg.Text + "' This Registration Id is Invalid, Please Insert Correct Id");

                    }*/
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
