using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccessLayer;
using System.Data.SqlClient;

namespace BussinessLayer
{
    public class Fee
    {
        public int sid { get; set; }
        public int fee { get; set; }
        public string Date { get; set; }
        public string lblname { get; set; }
        public string lblstandard { get; set; }

        public void StudentFee()
        {
            string q = "insert into FeeTable values('" + sid + "','" + Date + "','" + fee + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);

        }
        public int feeid { get; set; }
      public int stud_id { get; set; }
      public string catagory { get; set; }

        public int totalamount { get; set; }
       
        public string stdname { get; set; }
      public int RollNo { get; set; }
        
      public string standard { get; set; }
      public string paiddate { get; set; }
      public int paidamount { get; set; }
      public int pendingamt { get; set; }
        public string month { get; set; }

        public void AddFee()
        {
            string q = "insert into AddFee values('" + feeid + "','" + stdname + "','" + standard + "','" + RollNo + "','" + stud_id + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }
        private static int a = 1;
        public static int AutoNumber(string q, int StartNumber)
        {
            DBAccess db = new DBAccess();
            SqlDataReader dr = db.GetReader(q);
            if (dr.Read())
            {
                string val = dr[0].ToString();
                dr.Close();
                if (val == "")
                {
                    a = StartNumber;
                }
                else
                {
                    a = Convert.ToInt32(val) + 1;
                }
            }
            return a;
        }

        public void FeeDetails()
        {
            string q = "insert into FeeDetails values('" + feeid + "','" + catagory + "','" + paiddate + "','"+ totalamount + "','" + paidamount + "','" + pendingamt + "','" + month + "')";
            DBAccess db = new DBAccess();
            db.IDU(q);
        }
        public int CalculateFee(int totalamount ,int paidamount)
        {
            return totalamount - paidamount;
        }

    }
}
