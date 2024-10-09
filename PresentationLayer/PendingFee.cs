using BussinessLayer;
using DBAccessLayer;
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

namespace PresentationLayer
{
    public partial class PendingFee : Form
    {
        public PendingFee()
        {
            InitializeComponent();
        }

        private string FeeId;
       
        public void StudentFee()
        {
            string q = "Select sname from StudentAdmission";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            while (sdr.Read())
            {
                cmbStudentName.Items.Add(sdr["sname"]);

            }
            sdr.Close();
        }
        public void Catagory()
        {
            string q = "Select Catagory from FeeAmount";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            while (sdr.Read())
            {
                cmbCategory.Items.Add(sdr["Catagory"]);

            }
            sdr.Close();
        }
        private void AutoNumber()
        {
            FeeId =Fee.AutoNumber("Select max(FeeId) From AddFee", 1).ToString();
        }
        private void ClearAllA()
        {
            cmbStudentName.Text = "";
            txtRollNo.Clear();
            txtstandard.Clear();
            txtstdid.Clear();
          
        }
        private void ClearAllB()
        {
            this.cmbCategory.Text = "";
            this.cmbxmonth.Text = "";
            this.txtAmount.Clear();
          
            this.txtPaidAmount.Text = "0";
            this.txtDueAmount.Text = "0";
        }


        Fee f = new Fee();
        private void _FeeDetails()
        {
            for (int i = 0; i < dgvpendingfee.Rows.Count; i++)
            {
                f.feeid = Convert.ToInt32(FeeId);
                f.catagory = dgvpendingfee.Rows[i].Cells["catagry"].Value.ToString();
                f.month = dgvpendingfee.Rows[i].Cells["month"].Value.ToString();
                f.totalamount = Convert.ToInt32(dgvpendingfee.Rows[i].Cells["TotalAmount"].Value.ToString());
                f.paiddate = dgvpendingfee.Rows[i].Cells["paiddate"].Value.ToString();
                f.paidamount = Convert.ToInt32(dgvpendingfee.Rows[i].Cells["paidamt"].Value.ToString());
                f.pendingamt = Convert.ToInt32(dgvpendingfee.Rows[i].Cells["Pendingamt"].Value.ToString());
                f.FeeDetails();
            }
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = cmbCategory.SelectedItem.ToString();
            string q = "Select Amount from FeeAmount where Catagory='" + cmbCategory.Text + "'";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            while (sdr.Read())
            {
                this.txtAmount.Text = sdr["Amount"].ToString();

            }
            sdr.Close();
        }
        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sname = cmbStudentName.SelectedItem.ToString();
            string q = "Select Std_id,sname,RollNo,Standard from StudentAdmission where sname='" + sname + "'";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            while (sdr.Read())
            {

                this.txtstdid.Text = sdr["Std_id"].ToString();
                this.txtstandard.Text = sdr["Standard"].ToString();
                this.txtRollNo.Text =sdr["RollNo"].ToString();
                
            }
            sdr.Close();
        }

        private void PendingFee_Load(object sender, EventArgs e)
        {
            StudentFee();
            Catagory();
            AutoNumber();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d1 = DateTime.Now.ToShortDateString();
            dgvpendingfee.Rows.Add();
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["id"].Value = FeeId;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["catagry"].Value = cmbCategory.Text;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["month"].Value = cmbxmonth.Text;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["TotalAmount"].Value = txtAmount.Text;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["paiddate"].Value = d1;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["paidamt"].Value = txtPaidAmount.Text;
            dgvpendingfee.Rows[dgvpendingfee.Rows.Count - 1].Cells["Pendingamt"].Value = txtDueAmount.Text;
          

        }
        Student s = new Student();
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                f.feeid = int.Parse(FeeId);
                f.stdname = cmbStudentName.Text;
                f.RollNo = int.Parse(txtRollNo.Text);
                f.standard = txtstandard.Text;
                f.stud_id = int.Parse(txtstdid.Text);
                f.AddFee();
               _FeeDetails();
                    MessageBox.Show("Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllA();
                dgvpendingfee.Rows.Clear();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDueAmount.Text = f.CalculateFee(Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtPaidAmount.Text)).ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void txtfid_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
