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
    public partial class Teacher_Details : Form
    {
        string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
        DataSet ds = null;
        SqlDataAdapter sda;
        string q = "select * from TeacherInfo";
        public Teacher_Details()
        {
            InitializeComponent();
        }
        
        private void btnaddteacher_Click(object sender, EventArgs e)
        {
            Add_Teachers adt = new Add_Teachers();
            adt.Show();
        }

        private void txtsearchteacher_TextChanged(object sender, EventArgs e)
        {
            DataView table_view = ds.Tables[0].DefaultView;
            table_view.RowFilter = "TeacherName like '%" + txtsearchteacher.Text + "%'";
            dgvteacher.DataSource = table_view;
        }

        private void Teacher_Details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "tblTeacher");
            con.Close();
            dgvteacher.DataSource = ds.Tables[0];
        }

        private void btnteacherdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sur you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dgvteacher.Rows.Remove(dgvteacher.SelectedRows[0]);
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder command_builder = new SqlCommandBuilder(sda);
                sda.Update(ds.Tables[0]);
                ds.AcceptChanges();
            }
        }

        private void dgvteacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add_Teachers adt = new Add_Teachers();
            adt.btnreset.Visible = false;
            adt.btnsave.Visible = false;
            adt.btnupdate.Visible = true;
            adt.txtid.Visible = true;
            adt.lbid.Visible = true;
            adt.txtid.Text = dgvteacher.CurrentRow.Cells[0].Value.ToString();
            adt.txttname.Text = dgvteacher.CurrentRow.Cells[1].Value.ToString();
            adt.txtteachercnic.Text = dgvteacher.CurrentRow.Cells[2].Value.ToString();
            adt.txtmobile.Text = dgvteacher.CurrentRow.Cells[5].Value.ToString();
            adt.txtemail.Text = dgvteacher.CurrentRow.Cells[6].Value.ToString();
            adt.txtexp.Text = dgvteacher.CurrentRow.Cells[8].Value.ToString();
            adt.txtqualification.Text = dgvteacher.CurrentRow.Cells[10].Value.ToString();
            adt.txttaddress.Text = dgvteacher.CurrentRow.Cells[11].Value.ToString();
            adt.cmbxsubject.Text = dgvteacher.CurrentRow.Cells[7].Value.ToString();
            adt.cmbxyear.Text = dgvteacher.CurrentRow.Cells[9].Value.ToString();
            adt.dtpdob.Text = dgvteacher.CurrentRow.Cells[3].Value.ToString();
            adt.Show();
        }
    }
}
