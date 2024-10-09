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
    public partial class PendingFeeRecord : Form
    {
        string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
        DataSet ds = null;
        SqlDataAdapter sda;
        string q = "select a.Stud_id,a.StudentName,a.Standard,f.PaidDate,f.PendingAmount from AddFee a join FeeDetails f on a.FeeId=f.FeeId where f.PendingAmount>0";
        public PendingFeeRecord()
        {
            InitializeComponent();
            this.cmbFilter.SelectedIndex = 0;
        }
        private void Filter()
        {
            if (this.cmbFilter.Text == "(None)")
            {
                this.Datetimpikr.Enabled = false;
                this.btnsearch.Enabled = false;
            }
            else
            {
                this.Datetimpikr.Enabled = true;
                this.btnsearch.Enabled = true;
            }
        }
        private void PendingFeeRecord_Load(object sender, EventArgs e)
        {
            Filter();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "FeeRecord");
            con.Close();
            dgvattendancerecord.DataSource = ds.Tables[0];
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

       


        private DataTable GetData(string q)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            return ds.Tables[0];
       
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            string date = Datetimpikr.Value.ToShortDateString();
            DataTable tblfee = GetData("select * from addfee");
            DataTable tbldetail = GetData("select * from feedetails");

            var list = tblfee.AsEnumerable().Join(tbldetail.AsEnumerable(), a=>a["feeid"], b=>b["feeid"],(x,y)=>new { sid = x["stud_id"], sname = x["StudentName"], standard = x["Standard"], paiddate = y["PaidDate"], pendingamount = y["PendingAmount"] }).Where(z=>z.paiddate.ToString()==date).ToList();
            dgvattendancerecord.DataSource = list;
        }
    }
}
