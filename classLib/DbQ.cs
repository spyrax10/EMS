using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using DGVPrinterHelper;

namespace classLib
{
    public class DbQ
    {
        static SqlDataAdapter adapt;

        public static void loadProfile(string empId, Label name, Label id, Label dept, PictureBox pB)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empTB where empID = @ID";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id.Text = empId;
                                name.Text = dr["Lastname"].ToString() + ", " + dr["Firstname"].ToString() + " " + dr["Midname"];
                                dept.Text = dr["Department"].ToString();
                                byte[] img = (byte[])(dr["Image"]);
                                if (img != null)
                                {
                                    MemoryStream ms = new MemoryStream(img);
                                    pB.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadEmpSub(DataGridView gV, string empId)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select Code, Name from empSubTB where empId = '" + empId + "' Order By Code", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void empSubDrop(DataGridView gV, string empId, Button btn, Panel pane)
        {
            try
            {
                if (gV.Rows.Count > 0)
                {
                    string value = gV.CurrentRow.Cells[0].Value.ToString();

                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Delete from empSubTB where empId = @ID and Code = @Code";
                            cmd.Parameters.AddWithValue("@ID", empId);
                            cmd.Parameters.AddWithValue("@Code", value);
                            cmd.ExecuteNonQuery();
                            loadEmpSub(gV, empId);
                            btn.Text = "ADD";
                            misc.clrCont(pane);
                        }
                    }
                }
                else
                {
                    msg.dataEmpty();
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void empSubDet(DataGridView gV, string empId, TextBox code, TextBox name, Button btn)
        {
            try
            {
                if (gV.Rows.Count > 0)
                {
                    string value = gV.CurrentRow.Cells[0].Value.ToString();

                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Select * from empSubTB where empId = @ID and Code = @Code";
                            cmd.Parameters.AddWithValue("@ID", empId);
                            cmd.Parameters.AddWithValue("@Code", value);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    code.Text = value;
                                    name.Text = dr["Name"].ToString();
                                    btn.Text = "UPDATE";
                                }
                            }
                        }
                    }
                }
                else
                {
                    msg.dataEmpty();
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void empSub(Panel pane, DataGridView gV, string empId, TextBox code, string name, Button btn)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        if (misc.isEmptyFields(pane) == true)
                        {
                            msg.incMsg();
                        }
                        else
                        {
                            con.Open();

                            cmd.CommandText = "Select * from empSubTB where empId = @ID and " +
                                "Code = @Code";
                            cmd.Parameters.AddWithValue("@ID", empId);
                            cmd.Parameters.AddWithValue("@Code", code.Text);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read() && btn.Text != "UPDATE")
                                {
                                    msg.subExits();
                                    code.Focus();
                                }
                                else
                                {
                                    if (btn.Text == "ADD")
                                    {
                                        using (var cmd2 = con.CreateCommand())
                                        {
                                            cmd2.CommandText = "Insert into empSubTB Values(@empId, @Code, @Name)";
                                            cmd2.Parameters.AddWithValue("@empId", empId);
                                            cmd2.Parameters.AddWithValue("@Code", code.Text);
                                            cmd2.Parameters.AddWithValue("@Name", name);
                                            cmd2.ExecuteNonQuery();
                                            misc.clrCont(pane);
                                            code.Focus();
                                            loadEmpSub(gV, empId);
                                        }
                                    }
                                    else if (btn.Text == "UPDATE")
                                    {
                                        if (gV.Rows.Count > 0)
                                        {
                                            string value = gV.CurrentRow.Cells[0].Value.ToString();
                                            using (var cmd3 = con.CreateCommand())
                                            {
                                                cmd3.CommandText = "Update empSubTB SET Code = @Code, " +
                                                    "Name = @Name where empId = @ID and Code = @Val";
                                                cmd3.Parameters.AddWithValue("@ID", empId);
                                                cmd3.Parameters.AddWithValue("@Code", code.Text);
                                                cmd3.Parameters.AddWithValue("@Val", value);
                                                cmd3.Parameters.AddWithValue("@Name", name);
                                                cmd3.ExecuteNonQuery();
                                                misc.clrCont(pane);
                                                code.Focus();
                                                btn.Text = "ADD";
                                                loadEmpSub(gV, empId);
                                            }
                                        }
                                        else
                                        {
                                            msg.dataEmpty();
                                        }
                                       
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void print(DataGridView gV, string title)
        {
            try
            {
                if (gV.Rows.Count > 0)
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = title + Environment.NewLine;
                    printer.SubTitle = "Date Printed: " + msg.date + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.PorportionalColumns = true;
                    printer.Footer = "Time Printed: " + msg.time;
                    printer.PageSettings.Landscape = true;
                    printer.FooterSpacing = 15;
                    printer.PrintSettings.PrintToFile = true;
                    printer.PrintDataGridView(gV);
                }
                else
                {
                    msg.dataEmpty();
                }        
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void clrSysLog(DataGridView gV, string empId)
        {
            try
            {
                using(var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();

                        if(MessageBox.Show("This will clear System Log, Are you Sure?", " Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                            DialogResult.Yes)
                        {
                            cmd.CommandText = "Delete from systemLog";
                            cmd.ExecuteNonQuery();
                            sysLog(empId, msg.time, msg.date, "System Logs Clear");
                            loadSysLog(gV);                   
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void sortSysLog(DataGridView gV, string date)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select empId as EmpId, Date, Time, Action " +
                        "from systemLog where Date = '" + date + "' Order By empId", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadSysLog(DataGridView gV)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select empId as EmpId, Date, Time, Action from systemLog Order By empId", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static bool verEmail (string email, string id)
        {
            bool stat = false;
            using (var con = DBInfo.getCon())
            {
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select* from empTB where Email = @Email and empId = @ID;" +
                        "Select * from admSet where email = @Email and empId = @ID;" +
                        "Select * from studTB where Email = @Email and studId = @ID";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (var dr = cmd.ExecuteReader())
                    {
                        do
                        {
                            while (dr.Read())
                            {
                                stat = true;
                            }
                        }
                        while (dr.NextResult());
                    }
                }
            }
            return stat;
        }
        public static string getEmail(string empId)
        {
            string email = "";
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from admSet where empId = @ID;" +
                            "Select * from empTB where empId = @ID";
                        cmd.Parameters.AddWithValue("@ID", getEmpId(empId));
                        using (var dr = cmd.ExecuteReader())
                        {
                            do
                            {
                                while (dr.Read())
                                {
                                    email = (dr["Email"].ToString());
                                }
                            } while (dr.NextResult());

                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
            return email;
        }
        public static void loadSet(string id, TextBox fold, TextBox user, TextBox pass,
            TextBox email, PictureBox pB, Button btn)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    using (var cmd2 = con.CreateCommand())
                    {
                        cmd2.CommandText = "Select * from empCre where empId = '" + id + "'";
                        using (var dr2 = cmd2.ExecuteReader())
                        {
                            if (dr2.Read())
                            {
                                user.Text = (dr2["username"].ToString());
                                pass.Text = (dr2["password"].ToString());
                                string eStat = (dr2["stat"].ToString());

                                if (eStat == "ADMIN")
                                {
                                    using (var cmd = con.CreateCommand())
                                    {
                                        cmd.CommandText = "Select * from admSet";
                                        using (var dr = cmd.ExecuteReader())
                                        {
                                            if (dr.Read())
                                            {
                                                fold.Text = (dr["foldPath"].ToString());
                                                email.Text = (dr["email"].ToString());

                                                string stat = (dr["eStat"].ToString());

                                                if (stat == msg.verified)
                                                {
                                                    pB.Image = Properties.Resources.ok;
                                                    btn.Text = "CHANGE";
                                                    btn.ForeColor = Color.Lime;
                                                }
                                                else
                                                {
                                                    pB.Image = Properties.Resources.close;
                                                    btn.Text = "VERIFY";
                                                    btn.ForeColor = Color.Red;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    using (var cmd3 = con.CreateCommand())
                                    {
                                        cmd3.CommandText = "Select * from empTB where empId = '" + id + "'";
                                        using (var dr3 = cmd3.ExecuteReader())
                                        {
                                            if (dr3.Read())
                                            {
                                                email.Text = (dr3["Email"].ToString());
                                                string stat2 = (dr3["eStat"].ToString());

                                                if (stat2 == msg.verified)
                                                {
                                                    pB.Image = Properties.Resources.ok;
                                                    btn.Text = "CHANGE";
                                                    btn.ForeColor = Color.Lime;
                                                }
                                                else
                                                {
                                                    pB.Image = Properties.Resources.close;
                                                    btn.Text = "VERIFY";
                                                    btn.ForeColor = Color.Red;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static bool chkUsername(string user)
        {
            bool stat = false;
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empCre where username = '" + user + "'";
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
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
                msg.serverErr();
                misc.crashRep(e.Message);
            }
            return stat;
        }
        public static string empStat(string empId)
        {
            string stat = "";
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empCre where empId = @ID";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                stat = dr["stat"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
            return stat;
        }
        public static bool userValid;
        public static string getEmpId(string user)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from empCre where username = @User";
                        cmd.Parameters.AddWithValue("@User", user);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                userValid = true;
                                user = dr["empId"].ToString();
                            }
                            else
                            {
                                userValid = false;
                                user = "";
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
            return user;
        }

        public static void codeLog(string code, string stat, string dateG, string dateU, string usrId)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Insert into codeLog values(@code, @Stat, @dateGen, @dateUse, @usrID)";
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@Stat", stat);
                        cmd.Parameters.AddWithValue("@dateGen", dateG);
                        cmd.Parameters.AddWithValue("@dateUse", dateU);
                        cmd.Parameters.AddWithValue("@usrID", usrId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }

        public static void sysLog(string empId, string time, string date, string action)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Insert into systemLog Values(@empId, @Time, @Date, @Action)";
                        cmd.Parameters.AddWithValue("@empId", empId);
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Action", action);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
           
        }
        public static bool isPass;
        public static void empLog(string user, string pass, string pass2)
        {
            try
            {
                if (user == "" && pass == "" && pass2 == "")
                {
                    msg.incMsg();
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Select * from empCre where username = @User and password = @Pass ";
                            cmd.Parameters.AddWithValue("User", user);
                            cmd.Parameters.AddWithValue("Pass", pass);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    isPass = true;
                                    msg.logSuc();
                                    sysLog(getEmpId(user), msg.time, msg.date, msg.logIn);
                                }
                                else
                                {
                                    isPass = false;
                                    msg.usrErr();
                                    sysLog(getEmpId(user), msg.time, msg.date, msg.logInErr);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
     
        public static void empCre(Control gB, TextBox empId, string user, string pass,
            GroupBox not, Label id, GroupBox log)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        string stat;
                        if (misc.isEmptyFields(gB) == true)
                        {
                            msg.incMsg();
                        }
                        else
                        {
   
                            con.Open();
                            cmd.CommandText = "Insert into empCre values(@empId, @username, @password, @lastUpdate, @stat)";
                            cmd.Parameters.AddWithValue("@empId", empId.Text);
                            cmd.Parameters.AddWithValue("@username", user);
                            cmd.Parameters.AddWithValue("@password", pass);
                            cmd.Parameters.AddWithValue("@lastUpdate", msg.date);
                            if (empId.Enabled == true)
                            {
                                stat = "ADMIN";
                            }
                            else
                            {
                                stat = "EMP";
                            }
                            cmd.Parameters.AddWithValue("@stat", stat);
                            cmd.ExecuteNonQuery();
                            if (empId.Enabled == true)
                            {
                                not.Visible = true;
                                id.Text = empId.Text;
                            }
                            else
                            {
                                log.Visible = true;
                            }
                            msg.accSuc();
                            gB.Visible = false;
                            sysLog(empId.Text, msg.time, msg.date, msg.accCreate);
                        }
                    }
                }     
            }
            catch(Exception e)
            {
                msg.serverErr();
                misc.crashRep(e.Message);
            }
        }
        public static bool codeStat;
        public static void chkCode(string code, string usrId)
        {
            try
            {
                if (code == "")
                {
                    msg.incMsg();
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Select * from codeLog where code = @Code " +
                            "and Stat = '" + msg.codeNUse + "' " +
                            "and dateGen = '" + msg.date + "' " +
                            "and usrID = @ID";
                            cmd.Parameters.AddWithValue("@Code", code);
                            cmd.Parameters.AddWithValue("@ID", usrId);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    using (var cmd2 = con.CreateCommand())
                                    {
                                        cmd2.CommandText = "Update codeLog set Stat = '" + msg.codeUse + "', " +
                                        "dateUse = '" + msg.date + "' where code = @Code " +
                                        "and usrID = @ID";
                                        cmd2.Parameters.AddWithValue("@Code", code);
                                        cmd2.Parameters.AddWithValue("@ID", usrId);
                                        cmd2.ExecuteNonQuery();
                                        sysLog(usrId, msg.time, msg.date, msg.codeVerified + code);
                                        codeStat = true;
                                    }
                                }
                                else
                                {
                                    msg.invCode();
                                    codeStat = false;
                                }
                            }
                        }
                    }
                }      
            }
            catch (Exception e)
            {
                msg.serverErr();
                misc.crashRep(e.Message);
            } 
        }
        public static void upEmpSet(string id, string user, string pass, string email,
            MethodInvoker meth)
        {
            try
            {
                upEmpCre(id, user, pass);
                if (isSave == true)
                {
                    if (misc.emailCount(email, id) == false)
                    {
                        msg.emailAbuse();
                    }
                    else
                    {
                        string stat = "";
                        using (var con = DBInfo.getCon())
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                if (misc.isEmailVer(email, id) == true)
                                    stat = msg.verified;
                                else
                                    stat = msg.nverified;

                                con.Open();
                                cmd.CommandText = "Update empTB SET Email = @Email, eStat = @Stat " +
                                    "where empId = @ID";
                                cmd.Parameters.AddWithValue("@Email", email);
                                cmd.Parameters.AddWithValue("@Stat", stat);
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();
                                msg.accSuc();
                                meth();
                                sysLog(id, msg.time, msg.date, msg.updEmp(id));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.serverErr();
                misc.crashRep(e.Message);
            }
        }
        public static void upAdmSet(string id, string user, string pass, 
            string fold, string email, MethodInvoker meth)
        {
            try
            {
                upEmpCre(id, user, pass);
                if (isSave == true)
                {
                    if (misc.emailCount(email, id) == false)
                    {
                        msg.emailAbuse();
                    }
                    else
                    {
                        string stat = "";
                        using (var con = DBInfo.getCon())
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                if (misc.isEmailVer(email, id) == false)
                                    stat = msg.verified;
                                else
                                    stat = msg.nverified;

                                con.Open();
                                cmd.CommandText = "Update admSet SET foldPath = @fold, email = @Email, " +
                                    "eStat = @Stat where empId = @Id";
                                cmd.Parameters.AddWithValue("@fold", fold);
                                cmd.Parameters.AddWithValue("@Email", email);
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.Parameters.AddWithValue("@Stat", stat);
                                cmd.ExecuteNonQuery();
                                msg.accSuc();
                                meth();
                                sysLog(id, msg.time, msg.date, msg.updEmp(id));
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static bool isSave;
        public static void upEmpCre(string id, string user, string pass)
        {
            try
            {
                if (user == "")
                {
                    msg.incMsg();
                    isSave = false;
                }
                else
                {
                    if (chkUsername(user) == true && getEmpId(user) != id)
                    {
                        msg.userUse();
                        isSave = false;
                    }
                    else
                    {
                        using (var con = DBInfo.getCon())
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                con.Open();
                                cmd.CommandText = "Update empCre Set username = @User, " +
                                    "password = @Pass, lastUpdate = @date " +
                                    "where empId = @ID";
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.Parameters.AddWithValue("@User", user);
                                cmd.Parameters.AddWithValue("@Pass", pass);
                                cmd.Parameters.AddWithValue("@date", msg.date);
                                cmd.ExecuteNonQuery();
                                isSave = true;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void upAdmEmail(string code, string empId, string path, TextBox email)
        {
            try
            {
                chkCode(code, empId);
                if (codeStat == true)
                {
                    using (var con = DBInfo.getCon())
                    {
                        con.Open();
                        if (empStat(empId) == "ADMIN")
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                con.Open();
                                cmd.CommandText = "Update admSet SET foldPath = @Path, " +
                                    "email = @Email, eStat = @Stat where empId = @ID";
                                cmd.Parameters.AddWithValue("@Path", path);
                                cmd.Parameters.AddWithValue("@Email", email.Text);
                                cmd.Parameters.AddWithValue("@Stat", msg.verified);
                                cmd.Parameters.AddWithValue("@ID", empId);
                                cmd.ExecuteNonQuery();                         
                            }
                        }
                        else
                        {
                            using (var cmd2 = con.CreateCommand())
                            {
                                cmd2.CommandText = "Update empTB SET Email = @Email, eStat = @Stat " +
                                    "where empId = @ID";
                                cmd2.Parameters.AddWithValue("@Email", email.Text);
                                cmd2.Parameters.AddWithValue("@Stat", msg.verified);
                                cmd2.Parameters.AddWithValue("@ID", empId);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        msg.emailVer();
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void admSet(string empId, string path, string email, string stat)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Insert into admSet values(@empId, @foldPath, @email, @emailStat)";
                        cmd.Parameters.AddWithValue("@empId", empId);
                        cmd.Parameters.AddWithValue("@foldPath", path);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@emailStat", stat);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void IDExits(Control ID, Control comp)
        {
            try
            {
                using (var con = DBInfo.getCon())
                using (var cmd = con.CreateCommand())
                {
                    con.Open();

                    cmd.CommandText = "Select * from empCre, empTB, studTB " +
                        "where empCre.empId = @ID or empTB.empId = @ID or studTB.studId = @ID";
                    cmd.Parameters.AddWithValue("@ID", ID.Text);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            msg.idUse();
                            comp.Enabled = false;
                        }
                        else
                        {
                            ID.Enabled = false;
                            comp.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }

        public static void empCreate (string empId, Control pane, string id, string dept, string first, 
            string mid, string last, string cont, string pro, string mun,
            string bar, string pur, string mob, string email, MethodInvoker meth)
        {
            try
            {            
                byte[] img = null;
                FileStream fs = new FileStream(misc.imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

               using (var con = DBInfo.getCon())
               using (var cmd = con.CreateCommand())
               {
                    if (misc.isEmptyFields(pane) == true)
                    {
                        msg.incMsg();
                    }
                    else if (misc.emailCount(email, id) == false)
                    {
                        msg.emailAbuse();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "Insert into empTB values(@empId, @Department, " +
                                 "@Firstname, @Midname, @Lastname, @Country, @Province, @Municipality, " +
                                 "@Barangay, @Purok, @Mobile, @Email, @eStat, @Image)";
                        cmd.Parameters.AddWithValue("@empId", id);
                        cmd.Parameters.AddWithValue("@Department", dept);
                        cmd.Parameters.AddWithValue("@Firstname", first);
                        cmd.Parameters.AddWithValue("@Midname", mid);
                        cmd.Parameters.AddWithValue("@Lastname", last);
                        cmd.Parameters.AddWithValue("@Country", cont);
                        cmd.Parameters.AddWithValue("@Province", pro);
                        cmd.Parameters.AddWithValue("@Municipality", mun);
                        cmd.Parameters.AddWithValue("@Barangay", bar);
                        cmd.Parameters.AddWithValue("@Purok", pur);
                        cmd.Parameters.AddWithValue("@Mobile", mob);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@eStat", msg.nverified);
                        cmd.Parameters.Add(new SqlParameter("@Image", img));
                        cmd.ExecuteNonQuery();
                        msg.accSuc();
                        meth();
                        sysLog(empId, msg.time, msg.date, msg.addEmp(id));
                    }
                }
            
            }
            catch (ArgumentException)
            {
                msg.upImg();
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void studCreate (Control pane, MethodInvoker meth, string empId, string id, string dept, string cour, string year,
            string first, string mid, string last, string cont, string pro, string mun,
            string bar, string pur, string mob, string email)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(misc.imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        if (misc.isEmptyFields(pane) == true)
                        {
                            msg.incMsg();
                        }
                        else if (misc.emailCount(email, id) == false)
                        {
                            msg.emailAbuse();
                        }
                        else
                        {
                            con.Open();
                            cmd.CommandText = "Insert into studTB values(@empId, @Department, @Course, @Year, " +
                                     "@Firstname, @Midname, @Lastname, @Country, @Province, @Municipality, " +
                                     "@Barangay, @Purok, @Mobile, @Email, @eStat, @Image)";
                            cmd.Parameters.AddWithValue("@empId", id);
                            cmd.Parameters.AddWithValue("@Department", dept);
                            cmd.Parameters.AddWithValue("@Course", cour);
                            cmd.Parameters.AddWithValue("@Year", year);
                            cmd.Parameters.AddWithValue("@Firstname", first);
                            cmd.Parameters.AddWithValue("@Midname", mid);
                            cmd.Parameters.AddWithValue("@Lastname", last);
                            cmd.Parameters.AddWithValue("@Country", cont);
                            cmd.Parameters.AddWithValue("@Province", pro);
                            cmd.Parameters.AddWithValue("@Municipality", mun);
                            cmd.Parameters.AddWithValue("@Barangay", bar);
                            cmd.Parameters.AddWithValue("@Purok", pur);
                            cmd.Parameters.AddWithValue("@Mobile", mob);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@eStat", msg.nverified);
                            cmd.Parameters.Add(new SqlParameter("@Image", img));
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                            meth();
                            sysLog(empId, msg.time, msg.date, msg.addStud(id));
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                msg.upImg();
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadBar(ComboBox cont, ComboBox pro, ComboBox mun, ComboBox cb)
        {
            try
            {
                cb.Text = "";
                cb.Items.Clear();

                using (var con = DBInfo.getCon())
                using(var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select Distinct Barangay from countTB " +
                        "where Country = @Country and Province = @Province " +
                        "and Municipality = @Mun Order By Barangay";
                    cmd.Parameters.AddWithValue("@Country", cont.Text);
                    cmd.Parameters.AddWithValue("@Province", pro.Text);
                    cmd.Parameters.AddWithValue("@Mun", mun.Text);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cb.Items.Add(dr["Barangay"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadMun(ComboBox cont, ComboBox pro, ComboBox cb)
        {
            try
            {
                cb.Text = "";
                cb.Items.Clear();
                
                using (var con = DBInfo.getCon())
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select Distinct Municipality from countTB " +
                        "where Country = @Country and Province = @Province Order By Municipality";
                    cmd.Parameters.AddWithValue("@Country", cont.Text);
                    cmd.Parameters.AddWithValue("Province", pro.Text);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cb.Items.Add(dr["Municipality"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadPro(ComboBox cont, ComboBox cb)
        {
            try
            {
                cb.Text = "";
                cb.Items.Clear();
                
                using (var con = DBInfo.getCon())
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select Distinct Province from countTB " +
                        "where Country = @Country Order By Province";
                    cmd.Parameters.AddWithValue("@Country", cont.Text);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cb.Items.Add(dr["Province"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }

        public static void loadCount(ComboBox cb)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Country from countTB";
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cb.Items.Add(dr["Country"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadStudents(string empId, ComboBox cB, DataGridView gV)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select Distinct studSubTB.studId as StudID, Lastname, Firstname, " +
                        "dbo.allCap(Department) as Department, dbo.allCap(Course) as Course " +
                        "from studTB, studSubTB Full Outer Join empSubTB ON studSubTB.Code = empSubTB.Code " +
                        "where empSubTB.empId = '" + empId + "' and studTB.studId = studSubTB.studId Order By StudID", con); 
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    loadSub(empId, cB);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadEmpStud(string empId, ComboBox cB, DataGridView gV)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select studTB.studId as StudID, Lastname, Firstname, " +
                        "dbo.allCap(Department) as Department, dbo.allCap(Course) as Course from studTB " +
                        "Full Outer Join studSubTB On studTB.studId = studSubTB.studId " +
                        "where Code = (Select Code from empSubTB where Code = '" + cB.Text + "' and empId = '" + empId + "') Order By StudID", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadSub(string empId, ComboBox cB)
        {
            try
            {
                cB.Text = "";
                cB.Items.Clear();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Code from empSubTB where empId = @ID Order By Code";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Code"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void srchStud(DataGridView gV, string studId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select studId as studId, " +
                        "dbo.allCap(Department) as Department, dbo.allCap(Course) as Course, Lastname, Firstname, Email from studTB " +
                        "where studId LIKE '%" + studId + "%' " +
                        "OR Lastname LIKE '%" + studId + "%'", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void srchEmp(DataGridView gV, string empId)
        {
            try
            {
                DataTable dt = new DataTable();
                using(var con = DBInfo.getCon())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select empId as EmpId, " +
                        "Department, Lastname, Firstname, Mobile, Email from empTB " +
                        "where empId LIKE '%" + empId + "%' " +
                        "OR Lastname LIKE '%" + empId + "%'", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadStud(DataGridView gV)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select studId as StudId, " +
                        "dbo.allCap(Department) as Department, dbo.allCap(Course) as Course , " +
                        "Lastname, Firstname, Email from studTB", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadEmp(DataGridView gV)
        {
            try
            {
                DataTable dt = new DataTable();
                using(var con = DBInfo.getCon())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select empId as EmpId, " +
                        "Department, Lastname, Firstname, Mobile, Email from empTB", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void editStud(DataGridView gV,TextBox studId, 
            TextBox dept, TextBox cour, TextBox year, TextBox first, 
            TextBox mid, TextBox last, TextBox mob, TextBox email, TextBox pur, 
            ComboBox count,ComboBox pro, ComboBox mun, ComboBox bar, PictureBox pb)
        {
            try
            {
                string id = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from studTB where studId = '" + id + "'";
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            studId.Text = (dr["studId"].ToString());
                            dept.Text = (dr["Department"].ToString());
                            cour.Text = (dr["Course"].ToString());
                            year.Text = (dr["Year"].ToString());
                            first.Text = (dr["Firstname"].ToString());
                            mid.Text = (dr["Midname"].ToString());
                            last.Text = (dr["Lastname"].ToString());
                            count.Text = (dr["Country"].ToString());
                            pro.Text = (dr["Province"].ToString());
                            mun.Text = (dr["Municipality"].ToString());
                            bar.Text = (dr["Barangay"].ToString());
                            pur.Text = (dr["Purok"].ToString());
                            mob.Text = (dr["Mobile"].ToString());
                            email.Text = (dr["Email"].ToString());
                            byte[] img = (byte[])(dr["Image"]);

                            if (img != null)
                            {
                                MemoryStream ms = new MemoryStream(img);
                                pb.Image = Image.FromStream(ms);
                            }
                            studId.Enabled = false;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void editEmp(DataGridView gV, 
            TextBox empId, TextBox dept, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox email, TextBox pur, ComboBox count, 
            ComboBox pro, ComboBox mun, ComboBox bar, PictureBox pb)
        {
            try
            {
                string id = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from empTB where empId = '" + id + "'";
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            empId.Text = (dr["empId"].ToString());
                            dept.Text = (dr["Department"].ToString());
                            first.Text = (dr["Firstname"].ToString());
                            mid.Text = (dr["Midname"].ToString());
                            last.Text = (dr["Lastname"].ToString());
                            count.Text = (dr["Country"].ToString());
                            pro.Text = (dr["Province"].ToString());
                            mun.Text = (dr["Municipality"].ToString());
                            bar.Text = (dr["Barangay"].ToString());
                            pur.Text = (dr["Purok"].ToString());
                            mob.Text = (dr["Mobile"].ToString());
                            email.Text = (dr["Email"].ToString());
                            byte[] img = (byte[]) (dr["Image"]);

                            if(img != null)
                            {
                                MemoryStream ms = new MemoryStream(img);
                                pb.Image = Image.FromStream(ms);
                            }
                            empId.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void updateStud(string empId, Control pane, TextBox id,
            TextBox dept, TextBox cour, TextBox year, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox email, TextBox pur, ComboBox count, ComboBox pro, ComboBox mun, ComboBox bar, 
            Button btn)
        {
            try
            {
                if (misc.isEmptyFields(pane))
                {
                    msg.incMsg();
                }
                else if (misc.emailCount(email.Text, id.Text) == false)
                {
                    msg.emailAbuse();
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Update studTB SET Department = @Dept, Course = @Cour, Year = @Year, " +
                                "Firstname = @First, Midname = @Mid, Lastname = @Last, Country = @Count, Province = @Pro, " +
                                "Municipality = @Mun, Barangay = @Bar, Purok = @Pur, Mobile = @Mob, " +
                                "Email = @Email where studId = @Id";
                            cmd.Parameters.AddWithValue("@Dept", dept.Text);
                            cmd.Parameters.AddWithValue("@Cour", cour.Text);
                            cmd.Parameters.AddWithValue("@Year", year.Text);
                            cmd.Parameters.AddWithValue("@First", first.Text);
                            cmd.Parameters.AddWithValue("@Mid", mid.Text);
                            cmd.Parameters.AddWithValue("@Last", last.Text);
                            cmd.Parameters.AddWithValue("@Count", count.Text);
                            cmd.Parameters.AddWithValue("@Pro", pro.Text);
                            cmd.Parameters.AddWithValue("@Mun", mun.Text);
                            cmd.Parameters.AddWithValue("@Bar", bar.Text);
                            cmd.Parameters.AddWithValue("@Pur", pur.Text);
                            cmd.Parameters.AddWithValue("@Mob", mob.Text);
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            cmd.Parameters.AddWithValue("@Id", id.Text);
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                            btn.Visible = true;
                            sysLog(empId, msg.time, msg.date, msg.updStud(id.Text));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void updateEmp(Control pane, string empId, TextBox id,
            TextBox dept, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox email, TextBox pur, ComboBox count, 
            ComboBox pro, ComboBox mun, ComboBox bar, MethodInvoker meth)
        {
            try
            {
                if (misc.isEmptyFields(pane))
                {
                    msg.incMsg();
                }
                else if (misc.emailCount(email.Text, id.Text) == false)
                {
                    msg.emailAbuse();
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Update empTB SET Department = @Dept, Firstname = @First, " +
                                "Midname = @Mid, Lastname = @Last, Country = @Count, Province = @Pro, " +
                                "Municipality = @Mun, Barangay = @Bar, Purok = @Pur, Mobile = @Mob," +
                                "Email = @Email where empId = @Id"; 
                            cmd.Parameters.AddWithValue("@Dept", dept.Text);
                            cmd.Parameters.AddWithValue("@First", first.Text);
                            cmd.Parameters.AddWithValue("@Mid", mid.Text);
                            cmd.Parameters.AddWithValue("@Last", last.Text);
                            cmd.Parameters.AddWithValue("@Count", count.Text);
                            cmd.Parameters.AddWithValue("@Pro", pro.Text);
                            cmd.Parameters.AddWithValue("@Mun", mun.Text);
                            cmd.Parameters.AddWithValue("@Bar", bar.Text);
                            cmd.Parameters.AddWithValue("@Pur", pur.Text);
                            cmd.Parameters.AddWithValue("@Mob", mob.Text);
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            cmd.Parameters.AddWithValue("@Id", id.Text);
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                            meth();
                            sysLog(empId, msg.time, msg.date, msg.updEmp(id.Text));
                        }
                    }                
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void studImg(PictureBox pB, TextBox id)
        {
            try
            {
                misc.selImg(pB);
                byte[] img = null;
                FileStream fs = new FileStream(misc.imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                if (MessageBox.Show("Save?", " Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Update studTB SET Image = @Img where studId = @ID";
                            cmd.Parameters.AddWithValue("@ID", id.Text);
                            cmd.Parameters.Add(new SqlParameter("@Img", img));
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                        }
                    }
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Select * from studTB where studId = @ID";
                            cmd.Parameters.AddWithValue("@ID", id.Text);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    img = (byte[])(dr["Image"]);
                                    MemoryStream ms = new MemoryStream(img);
                                    pB.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void updateImg(PictureBox pB, TextBox empId)
        {
            try
            {       
                misc.selImg(pB);
                byte[] img = null;
                FileStream fs = new FileStream(misc.imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                if (MessageBox.Show("Save?", " Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {           
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Update empTB SET Image = @Img where empId = @ID";
                            cmd.Parameters.AddWithValue("@ID", empId.Text);
                            cmd.Parameters.Add(new SqlParameter("@Img", img));
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                        }
                    }
                }
                else
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Select * from empTB where empId = @ID";
                            cmd.Parameters.AddWithValue("@ID", empId.Text);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    img = (byte[])(dr["Image"]);
                                    MemoryStream ms = new MemoryStream(img);
                                    pB.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
           
        }
        public static void updStudSub(Panel pane, DataGridView gV, TextBox id,
            TextBox code, TextBox desc, Button btn)
        {
            try
            {
                string val = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        if (misc.isEmptyFields(pane))
                        {
                            msg.incMsg();
                        }
                        else
                        {
                            con.Open();
                            cmd.CommandText = "Update studSubTB Set Code = @Code, Name = @Name" +
                                " where studId = @ID and Code = @Val";
                            cmd.Parameters.AddWithValue("@Code", code.Text);
                            cmd.Parameters.AddWithValue("@Name", desc.Text);
                            cmd.Parameters.AddWithValue("@ID", id.Text);
                            cmd.Parameters.AddWithValue("@Val", val);
                            cmd.ExecuteNonQuery();
                            misc.clrCont(pane);
                            loadStudSub(gV, id);
                            code.Focus();
                            btn.Text = "ADD";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void editStudSub(DataGridView gV, 
            TextBox code, TextBox desc, Button btn)
        {
            try
            {
                if (gV.Rows.Count > 0)
                {
                    code.Text = gV.CurrentRow.Cells[0].Value.ToString();
                    desc.Text = gV.CurrentRow.Cells[1].Value.ToString();
                    btn.Text = "UPDATE";
                }           
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void addStudSub(Panel pane, DataGridView gV, TextBox id, 
            TextBox code, TextBox desc)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        if (misc.isEmptyFields(pane))
                        {
                            msg.incMsg();
                        }
                        else
                        {
                            con.Open();
                            cmd.CommandText = "Select * from studSubTB where studId = '" + id.Text + "'" +
                            "and Code = '" + code.Text + "' and Name = '" + desc.Text + "'";

                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    msg.subExits();
                                }
                                else
                                {
                                    using (var cmd2 = con.CreateCommand())
                                    {
                                        cmd2.CommandText = "Insert into studSubTB values(@ID, @Code, @Name)";
                                        cmd2.Parameters.AddWithValue("@ID", id.Text);
                                        cmd2.Parameters.AddWithValue("@Code", code.Text);
                                        cmd2.Parameters.AddWithValue("@Name", desc.Text);
                                        cmd2.ExecuteNonQuery();
                                        misc.clrCont(pane);
                                        code.Focus();
                                        loadStudSub(gV, id);
                                    }                    
                                }
                            }
                        }     
                    }
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadStudSub(DataGridView gV, TextBox id)
        {
            try
            {
                DataTable dt = new DataTable();
                using(var con = DBInfo.getCon())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select Code, Name from studSubTB where studId = '" + id.Text + "'", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void dropSub(DataGridView gV, TextBox id)
        {
            try
            {
                string code = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Delete from studSubTB where Code = '" + code + "'";
                        cmd.ExecuteNonQuery();
                        loadStudSub(gV, id);
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void codeCheck(Control gBDet, TextBox code)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from quesTB where Code = @Code";
                        cmd.Parameters.AddWithValue("@Code", code.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                msg.codeEmpUse();
                            }
                            else
                            {
                                gBDet.Enabled = true;
                                code.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
    }
}
