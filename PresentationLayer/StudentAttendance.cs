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
    public partial class StudentAttendance : Form
    {
        
        private string sid;
        public StudentAttendance()
        {
            InitializeComponent();
        }
        
        public void Reset()
        {
            cmbStudentName.Text = "";
            txtrollno.Text = "";
            txtstandardst.Text = "";
            txtcoursest.Text = "";
            rdAbsent.Checked = false;
            rdPresent.Checked = false;
        }

        public void StudentAtt()
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

        private void StudentAttendance_Load(object sender, EventArgs e)
        {

            StudentAtt();
        }



        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sname= cmbStudentName.SelectedItem.ToString();
            string q = "Select Std_id,RollNo,sname,course,Standard from StudentAdmission where sname='" + sname + "'";
            DBAccess db = new DBAccess();
            SqlDataReader sdr =db.GetReader(q);
            while (sdr.Read())
            {
  
                this.sid =sdr["Std_id"].ToString();
                this.txtrollno.Text =sdr["RollNo"].ToString();
                this.txtcoursest.Text = sdr["course"].ToString();
                this.txtstandardst.Text = sdr["Standard"].ToString();

                
            }
            sdr.Close();
        }
        Student s = new Student();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            dgvstattendance.Rows.Add();
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["RollNo"].Value =txtrollno.Text;
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["StudentName"].Value = cmbStudentName.Text;
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["Course"].Value = txtcoursest.Text;
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["Semester"].Value = txtstandardst.Text;
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["AttendanceDate"].Value = datePicker.Text;
            if (this.rdPresent.Checked == true)
            {
                dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["Attendance"].Value = rdPresent.Text;
            }
            else
                if (this.rdAbsent.Checked == true)
            {
                dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["Attendance"].Value = rdAbsent.Text;
            }
            dgvstattendance.Rows[dgvstattendance.Rows.Count - 1].Cells["Stud_id"].Value = sid;
            Reset();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvstattendance.Rows.Count; i++)
                {
                    
                    s.sname = dgvstattendance.Rows[i].Cells["StudentName"].Value.ToString();
                    s.rollno = int.Parse(dgvstattendance.Rows[i].Cells["RollNo"].Value.ToString());
                    s.course = dgvstattendance.Rows[i].Cells["Course"].Value.ToString();
                    s.standard = dgvstattendance.Rows[i].Cells["Semester"].Value.ToString();
                    s.date = dgvstattendance.Rows[i].Cells["AttendanceDate"].Value.ToString();
                    s.Attendance = dgvstattendance.Rows[i].Cells["Attendance"].Value.ToString();
                    s.sid =int.Parse(dgvstattendance.Rows[i].Cells["Stud_id"].Value.ToString());
                    s.StudentAttendance();
                }
                MessageBox.Show("Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvstattendance.Rows.Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            AttendanceRecord adt = new AttendanceRecord();
            adt.Show();
        }
    }
}

