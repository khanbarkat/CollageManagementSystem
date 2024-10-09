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
using DBAccessLayer;

namespace PresentationLayer
{
    public partial class AttendanceRecord : Form
    {
        string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
        DataSet ds = null;
        SqlDataAdapter sda;
        string q = "select * from StudentAttendance";
        public AttendanceRecord()
        {
            InitializeComponent();
            this.cmbFilter.SelectedIndex = 0;
        }

        private void Filter()
        {
            if (this.cmbFilter.Text == "(None)")
            {
                this.txtSearch.Enabled = false;
            }
            else
            {
                this.txtSearch.Enabled = true;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void AttendanceRecord_Load(object sender, EventArgs e)
        {
            Filter();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "AttendanceRecord");
            con.Close();
            dgvattendancerecord.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView table_view = ds.Tables[0].DefaultView;
            table_view.RowFilter = "StudentName like '%" + txtSearch.Text + "%'";
            dgvattendancerecord.DataSource = table_view;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sur you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dgvattendancerecord.Rows.Remove(dgvattendancerecord.SelectedRows[0]);
               /* SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder command_builder = new SqlCommandBuilder(sda);
                sda.Update(ds.Tables[0]);
                ds.AcceptChanges();*/
            }
        }
    }
}
