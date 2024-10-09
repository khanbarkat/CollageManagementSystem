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
    public partial class Student_Details : Form
    {
        string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
        DataSet ds = null;
        SqlDataAdapter sda;
        string q = "select * from StudentAdmission";
        public Student_Details()
        {
            InitializeComponent();
        }
        private void txtsearchbyname_TextChanged(object sender, EventArgs e)
        {
            DataView table_view = ds.Tables[0].DefaultView;
            table_view.RowFilter = "sname like '%" + txtsearchbyname.Text + "%'";
            dgvstudentrecord.DataSource = table_view;
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "tblstudent");
            con.Close();
            dgvstudentrecord.DataSource = ds.Tables[0];
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sur you want to delete","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dgvstudentrecord.Rows.Remove(dgvstudentrecord.SelectedRows[0]);
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder command_builder = new SqlCommandBuilder(sda);
                sda.Update(ds.Tables[0]);
                ds.AcceptChanges();
            }
        }
    }
}
