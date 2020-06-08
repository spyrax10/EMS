using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace classLib
{
    public class DBInfo
    {
        
        public static string cs = ConfigurationManager.ConnectionStrings["defCon"].ConnectionString;
        
        public static SqlConnection getCon()
        {
            var con = new SqlConnection();
            con.ConnectionString = cs;
            return con;
        }
        public static bool conStat()
        {
            bool stat = false;

            try
            {
                var con = getCon();
                con.Open();
                stat = true;
            }
            catch (Exception e)
            {
                stat = false;
                misc.crashRep(e.Message);
            }
            return stat;
        }

        public static bool admChk()
        {
            var con = getCon();
            bool stat = false;
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from empCre where stat = 'ADMIN'";

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                stat = true;
            }
            else
            {
                stat = false;
            }
            return stat;
        }
      
    }
}
