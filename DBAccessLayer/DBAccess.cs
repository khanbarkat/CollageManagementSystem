using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DBAccessLayer
{
  public  class DBAccess
    {
        string constr = @"Data Source=DESKTOP-03U05ON\SQLEXPRESS;Initial Catalog=VP_Project;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public DBAccess()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand();

        }
        private void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

        }
        public int IDU(string q)
        {
            OpenCon();
            cmd.CommandText = q;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
            
        }
        public SqlDataReader GetReader(string q)
        {
            OpenCon();
            cmd.CommandText = q;
            cmd.Connection = con;
            return cmd.ExecuteReader();
           
        }



    }

}

