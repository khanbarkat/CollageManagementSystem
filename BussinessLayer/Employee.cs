using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBAccessLayer;
namespace BussinessLayer
{
  public class Employee
    {
        public string Fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string cnfirmpassword { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public void Registration()
        {
            string q = "insert into Employee values('" +Fullname + "','" + username + "','" + password + "','" + email + "','" + phone+ "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }

        public bool ValidUser()
        {
            string q = "select username,passwrd from Employee where username='" + username + "' and passwrd='" + password + "'";
            DBAccess db = new DBAccess();
            SqlDataReader sdr = db.GetReader(q);
            bool valid = false;
            if (sdr.Read())
            {
                if (sdr["username"].ToString() == username && sdr["passwrd"].ToString() == password)
                {
                    valid = true;
                }
            }
            sdr.Close();
            db.CloseCon();
            return valid;
        }
    }
}
