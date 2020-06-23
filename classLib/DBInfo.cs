using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace classLib
{
    public class DBInfo
    {        
        public static string cs = ConfigurationManager.ConnectionStrings["defCon"].ConnectionString;
        public static string username = ConfigurationManager.AppSettings["Username"];
        public static string password = ConfigurationManager.AppSettings["Password"];
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
                DbQ.sysLog(msg.sysName, msg.time, msg.date, msg.sysErr);

            }
            return stat;
        }
        public static void chkEmp(TextBox tB, Control chk, Control log, Control cre, TextBox id)
        {
            try
            {
                using (var con = getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empTB where empId = @ID";
                        cmd.Parameters.AddWithValue("@ID", tB.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Select * from empCre where empId = @ID";
                                    cmd2.Parameters.AddWithValue("@ID", tB.Text);
                                    using (var dr2 = cmd2.ExecuteReader())
                                    {
                                        if (dr2.Read())
                                        {
                                            log.Visible = true;
                                            chk.Visible = false;
                                        }
                                        else
                                        {
                                            chk.Visible = false;
                                            cre.Visible = true;
                                            id.Text = tB.Text;
                                            id.Enabled = false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                msg.usrInv();
                                tB.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
                DbQ.sysLog(msg.sysName, msg.time, msg.date, msg.sysErr);
            }
        }
        public static bool admChk()
        {
            bool stat = false;
            try
            {
                using (var con = getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empCre where stat = 'ADMIN'";
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                stat = true;
                            }
                            else
                            {
                                stat = false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
                DbQ.sysLog(msg.sysName, msg.time, msg.date, msg.sysErr);
            }
            return stat;
        }    
    }
}
