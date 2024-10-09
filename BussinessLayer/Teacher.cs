using DBAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Teacher
    {
        public int tid { get; set; }
        public string tname { get; set; }
        public string cnic { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public int experience { get; set; }
        public string  year{ get; set; }
        public string qualification { get; set; }
        public string address { get; set; }

        public void AddTeacher()
        {
            string q = "insert into TeacherInfo values('" + tname + "','" + cnic + "','" + dob + "','" + gender+ "','" + contact + "','" + email + "','" + subject + "','" + experience + "','" + year+ "','" + qualification + "','" + address + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }
        public void UpdateTeacher()
        {
            string q = "Update TeacherInfo set TeacherName= '"+tname+ "',CNIC='"+cnic+ "',DOB='"+dob+"',Gender='"+gender+ "',Contact='" + contact + "',Email='" + email + "',Subject='" + subject + "',Experience='" + experience + "',Year='" + year + "',Qualification='" + qualification + "',Address='" + address + "' where tid='"+tid+"'";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }

    }
}
