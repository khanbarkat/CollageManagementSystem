using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBAccessLayer;
namespace BussinessLayer
{
   public class Student
    {
        public int sid { get; set; }
        public int rollno { get; set; }
        public string sname { get; set; }
        public string SFname { get; set; }
        public string scnic { get; set; }
        public string sdob { get; set; }
        public string gender { get; set; }
        public string scity { get; set; }
        public string Mobileno { get; set; }
        public string email { get; set; }
        public string standard { get; set; }
        public string year { get; set; }
        public string Address { get; set; }
        public string course { get; set; }
        public string cmbxfrom { get; set; }
        public string cmbxto { get; set; }
        public string date { get; set; }
        public string Attendance { get; set; }
        public string month { get; set; }
        public int pendingfee { get; set; }

        public void StudentsRegistration()
        {
            string q = "insert into StudentAdmission values('" + rollno + "','" + sname + "','" + SFname + "','" + scnic + "','" + sdob + "','" + gender + "','" + scity + "','" + Mobileno + "','" + email + "','" + standard + "','" + year + "','" + Address + "','" + course + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }

        public void UpgradeStudent()
        {
            string q = "Update StudentAdmission set standard='" + cmbxto + "' where standard='" + cmbxfrom + "' ";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }
        public void StudentAttendance()
        {
            string q = "Insert into StudentAttendance values('" + course + "','" + sname + "','" + rollno + "','" + standard + "','" + date + "','" + Attendance + "','"+sid+"')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }
        public void StudentPendingFee()
        {
            string q = "Insert into PendingFee values('" + sid + "','" + sname + "','" + standard + "','" + date + "','" + month + "','" + pendingfee + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }





    }
}
