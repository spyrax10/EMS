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
       public static SqlDataAdapter adapt;

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
                                    msg.alExits();
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
        public static void loadSet2(ComboBox cB, string empId, string sub, ComboBox code)
        {
            try
            {
                cB.Text = "";
                cB.Items.Clear();
                code.Text = "";
                code.Items.Clear();
                using (var con  = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct QSet from quesTB where empId = @ID " +
                            "and Subject = @Sub";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Sub", sub);
                        using(var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["QSet"]).ToString();
                            }
                        }
                    }
                    using (var cmd2 = con.CreateCommand())
                    {
                        cmd2.CommandText = "Select Distinct Code from quesTB where " +
                            "empId = @ID and Subject = @Sub";
                        cmd2.Parameters.AddWithValue("@ID", empId);
                        cmd2.Parameters.AddWithValue("@Sub", sub);
                        using (var dr2 = cmd2.ExecuteReader())
                        {
                            while (dr2.Read())
                            {
                                code.Items.Add(dr2["Code"]).ToString();
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
        public static void loadStudents(string empId, DataGridView gV)
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
                                    msg.alExits();
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
        public static void editQues(Panel pane, DataGridView gV, string empId, string code, string sub,
            string period, string set, string type, NumericUpDown num, 
            TextBox ques, TextBox ans, Button btn, TextBox cho, Button btn2)
        {
            try
            {
                string val = gV.CurrentRow.Cells[2].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select * from quesTB where Code = @Code and empId = @ID " +
                        "and Subject = @Sub and Period = @Per and QSet = @Set and Type = @Typ " +
                        "and Answer = @Val";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Sub", sub);
                        cmd.Parameters.AddWithValue("@Per", period);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Typ", type);
                        cmd.Parameters.AddWithValue("@Val", val);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                num.Value = Convert.ToInt32(dr["No"].ToString());
                                ques.Text = dr["Question"].ToString();
                                ans.Text = val;
                                cho.Text = val;
                                btn.Text = "UPDATE";
                            }
                            else
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Select * from choiceTB where Code = @Code and empId = @ID " +
                                    "and QSet = @Set and Choices = @Val";
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Set", set);
                                    cmd2.Parameters.AddWithValue("@Val", val);

                                    using (var dr2 = cmd2.ExecuteReader())
                                    {
                                        if (dr2.Read())
                                        {
                                            num.Value = Convert.ToInt32(dr2["No"].ToString());
                                            ques.Text = dr2["Question"].ToString();
                                            cho.Text = val;
                                            btn2.Text = "UPDATE";
                                            pane.Visible = true;
                                            pane.BringToFront();
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
        public static void loadCho(DataGridView gV, string empId, string code, string set,
            NumericUpDown num)
        {
            try
            {
                
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select No, Question, Choices from choiceTB where " +
                        "Code = '" + code + "' and empId = '" + empId + "' and QSet = '" + set + "' and No = '" + num.Value.ToString() + "' " +
                        "ORDER BY CAST (No AS INT) ASC", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    misc.sortGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void dispQues2(DataGridView gV, string empId, ComboBox cB, TextBox sub, TextBox per)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from quesTB where Code = @Code and empId = @ID ";
                        cmd.Parameters.AddWithValue("@Code", cB.Text);
                        cmd.Parameters.AddWithValue("@ID", empId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                sub.Text = dr["Subject"].ToString();
                                per.Text = dr["Period"].ToString();

                                DataTable dt = new DataTable();
                                adapt = new SqlDataAdapter("Select QSet, Type, No, Question, Answer from quesTB where Code = '" + cB.Text + "' and empId = '" + empId + "' ", con);
                                adapt.Fill(dt);
                                gV.DataSource = dt;
                                misc.defGV(gV);
                                misc.sortExam(gV);
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
        public static void dispQues(GroupBox gB, ComboBox cB, string empId, TextBox code,
            ComboBox sub, ComboBox per, TextBox set)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from quesTB where Code = @Code and empId = @ID ";
                        cmd.Parameters.AddWithValue("@Code", cB.Text);
                        cmd.Parameters.AddWithValue("@ID", empId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                gB.Enabled = true;
                                code.Text = dr["Code"].ToString();
                                sub.Text = dr["Subject"].ToString();
                                per.Text = dr["Period"].ToString();
                                set.Text = dr["QSet"].ToString();
                                sub.Enabled = false; per.Enabled = false; code.Enabled = false;
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
        public static void loadQuesCode2(ComboBox sub, string empId, ComboBox code)
        {
            try
            {
                code.Text = "";
                code.Items.Clear();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Code from quesTB where " +
                            "empId = @ID and Subject = @Sub";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Sub", sub);
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                code.Items.Add(dr["Code"]).ToString();
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
        public static void loadQuesCode(ComboBox cB, string empId)
        {
            try
            {
                cB.Text = "";
                cB.Items.Clear();
                using(var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Code from quesTB where empId = @ID";
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
        public static void loadQues(DataGridView gV, string empId, string code, string sub,
            string period, string set, string type)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select No, Question, Answer from quesTB where " +
                        "Code = '" + code + "' and empId = '" + empId + "' and Subject = '" + sub + "' " +
                        "and Period = '" + period + "' and QSet = '" + set + "' and Type = '" + type + "' ORDER BY CAST (No AS INT) ASC", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    misc.sortGV(gV);
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void delQues(DataGridView gV, string empId, string code, string sub,
            string period, string set, string type, TextBox quesT, TextBox ansT, Button btn,
            Button btnCho, TextBox cho, NumericUpDown num)
        {
            try
            {            
                using (var con = DBInfo.getCon())
                {
                    if (gV.Rows.Count <= 0)
                    {
                        msg.dataEmpty();
                    }
                    else
                    {
                        string ans = gV.CurrentRow.Cells[2].Value.ToString();
                        string ques = gV.CurrentRow.Cells[1].Value.ToString();
                        string colName = gV.Columns[2].Name;
                        
                        con.Open();

                        using (var cmd = con.CreateCommand())
                        {
                            if (colName == "Answer")
                            {
                                cmd.CommandText = "Delete from quesTB where Code = @Code and empId = @ID " +
                                "and Subject = @Sub and Period = @Per and QSet = @Set and Type = @Typ " +
                                "and Answer = @Ans";
                                cmd.Parameters.AddWithValue("@Code", code);
                                cmd.Parameters.AddWithValue("@ID", empId);
                                cmd.Parameters.AddWithValue("@Sub", sub);
                                cmd.Parameters.AddWithValue("@Per", period);
                                cmd.Parameters.AddWithValue("@Set", set);
                                cmd.Parameters.AddWithValue("@Typ", type);
                                cmd.Parameters.AddWithValue("@Ans", ans);
                                cmd.ExecuteNonQuery();

                                using (var cmd3 = con.CreateCommand())
                                {
                                    cmd3.CommandText = "Delete from choiceTB where Code = @Code and empId = @ID " +
                                        "and QSet = @Set and Question = @Ques";
                                    cmd3.Parameters.AddWithValue("@Code", code);
                                    cmd3.Parameters.AddWithValue("@ID", empId);
                                    cmd3.Parameters.AddWithValue("@Set", set);
                                    cmd3.Parameters.AddWithValue("@Ques", ques);
                                    cmd3.ExecuteNonQuery();
                                }
                                loadQues(gV, empId, code, sub, period, set, type);
                                quesT.Text = ""; ansT.Text = ""; quesT.Focus();
                                btn.Text = "ADD";
                            }
                            else
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Delete from choiceTB where Code = @Code and empId = @ID " +
                                    "and QSet = @Set and Choices = @Ans";
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Set", set);
                                    cmd2.Parameters.AddWithValue("@Ans", ans);
                                    cmd2.ExecuteNonQuery();
                                    btnCho.Text = "ADD"; cho.Text = ""; cho.Focus();
                                    loadCho(gV, empId, code, set, num);
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
        public static void addChoDef(string empId, string code,
            string set, NumericUpDown num, TextBox ques, TextBox ans)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from choiceTB where Code = @Code and empId = @ID " +
                            "and QSet = @Set and Question = @Ques and Choices = @Ans";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("Ques", ques.Text);
                        cmd.Parameters.AddWithValue("@Ans", ans.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Insert into choiceTB Values(@Code, @ID, " +
                                            "@Set, @Num, @Ques, @Cho)";
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Set", set);
                                    cmd2.Parameters.AddWithValue("@Num", num.Value.ToString());
                                    cmd2.Parameters.AddWithValue("@Ques", ques.Text);
                                    cmd2.Parameters.AddWithValue("@Cho", ans.Text);
                                    cmd2.ExecuteNonQuery();
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
        public static void addChoQues(Panel pane, DataGridView gV, string empId, string code, 
            string set, NumericUpDown num, TextBox ques, TextBox cho, Button btn)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    if (misc.isEmptyFields(pane) == true && cho.Text == "")
                    {
                        msg.incMsg();
                    }
                    else
                    {
                        con.Open();

                        using (var cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "Select * from choiceTB where Code = @Code and empId = @ID " +
                                " and QSet = @Set and No = @Num and Choices = @Cho";
                            cmd.Parameters.AddWithValue("@Code", code);
                            cmd.Parameters.AddWithValue("@ID", empId);
                            cmd.Parameters.AddWithValue("@Set", set);
                            cmd.Parameters.AddWithValue("@Num", num.Value.ToString());
                            cmd.Parameters.AddWithValue("@Cho", cho.Text);
                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.Read() && btn.Text != "UPDATE")
                                {
                                    msg.alExits();
                                }
                                else
                                {
                                    if (btn.Text == "ADD")
                                    {
                                        using (var cmd2 = con.CreateCommand())
                                        {
                                            cmd2.CommandText = "Insert into choiceTB Values(@Code, @ID, " +
                                            "@Set, @Num, @Ques, @Cho)";
                                            cmd2.Parameters.AddWithValue("@Code", code);
                                            cmd2.Parameters.AddWithValue("@ID", empId);
                                            cmd2.Parameters.AddWithValue("@Set", set);
                                            cmd2.Parameters.AddWithValue("@Num", num.Value.ToString());
                                            cmd2.Parameters.AddWithValue("@Ques", ques.Text);
                                            cmd2.Parameters.AddWithValue("@Cho", cho.Text);
                                            cmd2.ExecuteNonQuery();
                                            cho.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        string val = gV.CurrentRow.Cells[2].Value.ToString();
                                        using (var cmd3 = con.CreateCommand())
                                        {
                                            cmd3.CommandText = "Update choiceTB Set Question = @Ques, Choices = @Ans where " +
                                                "Code = @Code and empId = @ID and QSet = @Set and Choices = @valA";
                                            cmd3.Parameters.AddWithValue("@Ques", ques.Text);
                                            cmd3.Parameters.AddWithValue("@Ans", cho.Text);
                                            cmd3.Parameters.AddWithValue("@Code", code);
                                            cmd3.Parameters.AddWithValue("@ID", empId);                        
                                            cmd3.Parameters.AddWithValue("@Set", set);
                                            cmd3.Parameters.AddWithValue("@valA", val);
                                            cmd3.ExecuteNonQuery();
                                            btn.Text = "ADD";
                                        }
                                    }
                                    cho.Focus();
                                    loadCho(gV, empId, code,set, num);
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
        public static void addQues(Panel pane, DataGridView gV, string empId, string code, string sub,
            string period, string set, string type, NumericUpDown num, TextBox ques, TextBox ans, 
            TextBox lbl, Button btn)
        {
            try
            {
                bool stat = false;
            
                using (var con = DBInfo.getCon())
                {
                    if (misc.isEmptyFields(pane) == true)
                    {
                        msg.incMsg();
                    }
                    else
                    {
                        con.Open();

                        if (type == "Identification" || type == "Multiple Choice")
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                cmd.CommandText = "Select * from quesTB where Code = @Code and empId = @ID " +
                                "and Subject = @Sub and Period = @Per and Type = @Type and QSet = @Set and No = @Num ";
                                cmd.Parameters.AddWithValue("@Code", code);
                                cmd.Parameters.AddWithValue("@ID", empId);
                                cmd.Parameters.AddWithValue("@Sub", sub);
                                cmd.Parameters.AddWithValue("@Per", period);
                                cmd.Parameters.AddWithValue("@Type", type);
                                cmd.Parameters.AddWithValue("@Set", set);
                                cmd.Parameters.AddWithValue("@Num", num.Value.ToString());

                                using (var dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read() && btn.Text != "UPDATE")
                                    {
                                        stat = false;
                                    }
                                    else
                                    {
                                        stat = true;
                                    }
                                }
                            }
                        }
                        else if (type == "Enumeration")
                        {
                            using (var cmdE = con.CreateCommand())
                            {
                                cmdE.CommandText = "Select * from quesTB where Code = @Code and empId = @ID " +
                                "and Subject = @Sub and Period = @Per and Type = @Type and QSet = @Set " +
                                "and No = @Num and Answer = @Ans";
                                cmdE.Parameters.AddWithValue("@Code", code);
                                cmdE.Parameters.AddWithValue("@ID", empId);
                                cmdE.Parameters.AddWithValue("@Sub", sub);
                                cmdE.Parameters.AddWithValue("@Per", period);
                                cmdE.Parameters.AddWithValue("@Type", type);
                                cmdE.Parameters.AddWithValue("@Set", set);
                                cmdE.Parameters.AddWithValue("@Num", num.Value.ToString());
                                cmdE.Parameters.AddWithValue("@Ans", ans.Text);

                                using (var drE = cmdE.ExecuteReader())
                                {
                                    if (drE.Read() && btn.Text != "UPDATE")
                                    {
                                        stat = false;
                                    }
                                    else
                                    {
                                        stat = true;
                                    }
                                }
                            }
                        }

                        if (stat == false)
                        {
                            msg.alExits();
                        }
                        else
                        {
                            if (btn.Text == "ADD")
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Insert into quesTB Values(@Code, @ID, @Sub, " +
                                        "@Per, @Date, @Set, @Type, @Num, @Ques, @Ans)";
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Sub", sub);
                                    cmd2.Parameters.AddWithValue("@Per", period);
                                    cmd2.Parameters.AddWithValue("@Date", msg.date);
                                    cmd2.Parameters.AddWithValue("@Type", type);
                                    cmd2.Parameters.AddWithValue("@Set", set);
                                    cmd2.Parameters.AddWithValue("@Num", num.Value.ToString());
                                    cmd2.Parameters.AddWithValue("@Ques", ques.Text);
                                    cmd2.Parameters.AddWithValue("@Ans", ans.Text);
                                    cmd2.ExecuteNonQuery();
                                    if (type == "Enumeration")
                                    {
                                        ans.Text = ""; ans.Focus();
                                    }
                                    else
                                    {
                                        num.Value += 1;
                                        ques.Text = ""; ans.Text = ""; ques.Focus();
                                    }
                                }
                            }
                            else
                            {
                                string valA = gV.CurrentRow.Cells[2].Value.ToString();
                                using (var cmd3 = con.CreateCommand())
                                {
                                    cmd3.CommandText = "Update quesTB Set Question = @Ques, Answer = @Ans where " +
                                        "Code = @Code and empId = @ID and Subject = @Sub and Period = @Per and " +
                                        "Type = @Type and QSet = @Set and Answer = @valA";
                                    cmd3.Parameters.AddWithValue("@Ques", ques.Text);
                                    cmd3.Parameters.AddWithValue("@Ans", ans.Text);
                                    cmd3.Parameters.AddWithValue("@Code", code);
                                    cmd3.Parameters.AddWithValue("@ID", empId);
                                    cmd3.Parameters.AddWithValue("@Sub", sub);
                                    cmd3.Parameters.AddWithValue("@Per", period);
                                    cmd3.Parameters.AddWithValue("@Type", type);
                                    cmd3.Parameters.AddWithValue("@Set", set);
                                    cmd3.Parameters.AddWithValue("@valA", valA);
                                    cmd3.ExecuteNonQuery();
                                    btn.Text = "ADD";
                                    misc.clrCont(pane);
                                }
                            }
                            lbl.Text = type;
                            loadQues(gV, empId, code, sub, period, set, type);
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
        public static void loadStudSet(DataGridView gV, string empId, string sub, string code)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select studSet AS QSet, studId AS StudID from studSetTB where " +
                        "empId = '" + empId + "' and Subject = '" + sub + "' and Code = '" + code + "' Order By studSet ASC", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    misc.sortGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void delStudSet(DataGridView gV, string code, string sub, string empId)
        {
            try
            {
                string id = gV.CurrentRow.Cells[1].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Delete from studSetTB where Code = @Code and empId = @emp " +
                            "and studId = @ID";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@emp", empId);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        loadStudSet(gV, empId, sub, code);
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void insStudSet(DataGridView gV, string code, string empId, 
            string sub, ComboBox set, DataGridView gV2)
        {
            try
            {
                string studId = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from studSetTB where " +
                            "Code = @Code and empId = @Emp and Subject = @Sub " +
                            "and studId = @ID";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Emp", empId);
                        cmd.Parameters.AddWithValue("@Sub", sub);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                msg.studSet();
                            }
                            else
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Insert into studSetTB Values(@Code, @ID, " +
                                        "@Sub, @studID, @Set)";
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Sub", sub);
                                    cmd2.Parameters.AddWithValue("@studID", studId);
                                    cmd2.Parameters.AddWithValue("@Set", set.Text);
                                    cmd2.ExecuteNonQuery();
                                    loadStudSet(gV2, empId, sub, code);
                                    set.Text = "";
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

        public static void loadGrade(DataGridView gV, string empId)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select Percentage, Grade, Remarks, LastUpdate from gradeTB " +
                        "where empId = '" + empId + "' ORDER BY CAST (Percentage AS INT) DESC", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    misc.sortGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void editGrade(string empId, NumericUpDown per, TextBox grade, ComboBox mark,
            DataGridView gV, Button btn)
        {
            try
            {
                string val = gV.CurrentRow.Cells[0].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from gradeTB where empId = @ID and Percentage = @Per";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Per", val);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                per.Value = Convert.ToInt32(dr["Percentage"].ToString());
                                grade.Text = dr["Grade"].ToString();
                                mark.Text = dr["Remarks"].ToString();
                                btn.Text = "UPDATE";
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
        public static void addGrade(string empId, NumericUpDown per, TextBox grade, ComboBox mark,
            DataGridView gV, Button btn)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from gradeTB where" +
                            " empId = @ID and Percentage = @Per";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Per", per.Value.ToString());
                        
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() && btn.Text != "UPDATE")
                            {
                                msg.alExits();
                            }
                            else
                            {
                                if (btn.Text == "ADD")
                                {
                                    using (var cmd2 = con.CreateCommand())
                                    {
                                        cmd2.CommandText = "Insert into gradeTB Values(@ID, @Per," +
                                            "@Grade, @Mark, @Date)";
                                        cmd2.Parameters.AddWithValue("@ID", empId);
                                        cmd2.Parameters.AddWithValue("@Per", per.Value.ToString());
                                        cmd2.Parameters.AddWithValue("@Grade", grade.Text);
                                        cmd2.Parameters.AddWithValue("@Mark", mark.Text);
                                        cmd2.Parameters.AddWithValue("@Date", msg.date);
                                        cmd2.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    string valPer = gV.CurrentRow.Cells[0].Value.ToString();
                                    string valGr = gV.CurrentRow.Cells[1].Value.ToString();

                                    using (var cmd3 = con.CreateCommand())
                                    {
                                        cmd3.CommandText = "Update gradeTB Set Percentage = @Per, " +
                                            "Grade = @Grade, Remarks = @Mark, LastUpdate = @Date where " +
                                            "empId = @ID and Percentage = @vPer";
                                        cmd3.Parameters.AddWithValue("@ID", empId);
                                        cmd3.Parameters.AddWithValue("@Per", per.Value.ToString());
                                        cmd3.Parameters.AddWithValue("@Grade", grade.Text);
                                        cmd3.Parameters.AddWithValue("@Mark", mark.Text);
                                        cmd3.Parameters.AddWithValue("@Date", msg.date);
                                        cmd3.Parameters.AddWithValue("@vPer", valPer);
                                        cmd3.Parameters.AddWithValue("@vGrade", valGr);
                                        cmd3.ExecuteNonQuery();
                                        btn.Text = "ADD";
                                    }
                                }
                                mark.Text = ""; grade.Text = "";
                                loadGrade(gV, empId);
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
        public static void loadStudLog(DataGridView gV, string code)
        {
            try
            {
                using(var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select studLogTB.studId AS StudID, dbo.allCap(Course) as Course, Lastname, Firstname, IP, Status from studLogTB " +
                        "FULL OUTER JOIN studTB on studLogTB.studId = studTB.studId where studLogTB.Code = '" + code + "'", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
                    misc.defGV(gV);
                    misc.sortGV(gV);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void addTestSet(string empId, ComboBox code, 
            string sub, string per, NumericUpDown num, Button btn, Timer time)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using(var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from testSetTB where empId = @ID and Code = @Code " +
                            "and Status = @Stat";
                        cmd.Parameters.AddWithValue("@ID", empId);
                        cmd.Parameters.AddWithValue("@Code", code.Text);
                        cmd.Parameters.AddWithValue("@Stat", msg.start);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                msg.examUse();
                                btn.Enabled = true; num.Enabled = true;
                            }
                            else
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Insert into testSetTB Values (@ID, @Code, @Sub, @Per," +
                                        "@Dur, @Date, @Time, @Stat)";
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.Parameters.AddWithValue("@Code", code.Text);
                                    cmd2.Parameters.AddWithValue("@Sub", sub);
                                    cmd2.Parameters.AddWithValue("@Per", per);
                                    cmd2.Parameters.AddWithValue("@Dur", num.Value.ToString());
                                    cmd2.Parameters.AddWithValue("@Date", msg.date);
                                    cmd2.Parameters.AddWithValue("@Time", msg.time);
                                    cmd2.Parameters.AddWithValue("@Stat", msg.start);
                                    cmd2.ExecuteNonQuery();
                                    btn.Enabled = false;
                                    num.Enabled = false;
                                    time.Start();  
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
        public static void studSet(string studId, ComboBox cB, TextBox set)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from studSetTB where studId = @ID and " +
                            "Code = @Code";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", cB.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                set.Text = dr["studSet"].ToString();
                                cB.Enabled = false;
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

        [Obsolete]
        public static void studLog(string studId, string code, string set,
            Timer time, Timer colTime, Label disp, Button btn, MethodInvoker meth)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from studLogTB where studId = @ID " +
                            "and Code = @Code and Date = @Date";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Date", msg.date);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                msg.accAl();
                                meth();
                            }
                            else
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Insert into studLogTB Values(@ID, @Code, " +
                                        "@Date, @Time, @IP, @Stat)";
                                    cmd2.Parameters.AddWithValue("@ID", studId);
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@Date", msg.date);
                                    cmd2.Parameters.AddWithValue("@Time", msg.time);
                                    cmd2.Parameters.AddWithValue("@IP", misc.ip);
                                    cmd2.Parameters.AddWithValue("@Stat", msg.online);
                                    cmd2.ExecuteNonQuery();
                                    time.Enabled = true;
                                    time.Start();
                                    disp.Visible = true;
                                    btn.Enabled = false;
                                    colTime.Start();
                                    msg.logSuc();
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
        public static  void delTime(string empId, string code)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Delete from testSetTB where empId = @ID and Code = @Code";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@ID", empId);
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
        public static void studStart(string studId, string code)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Update studLogTB Set Status = @Stat where " +
                            "studId = @ID and Code = @Code";
                        cmd.Parameters.AddWithValue("@Stat", msg.start);
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
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
        public static void updTime(string empId, string code, string time)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        int time2 = Convert.ToInt32(time);

                        if (time2 >= 0)
                        {
                            con.Open();
                            cmd.CommandText = "Update testSetTB Set Duration = @Dur " +
                                "where empId = @ID and Code = @Code";
                            cmd.Parameters.AddWithValue("@Dur", time);
                            cmd.Parameters.AddWithValue("@Code", code);
                            cmd.Parameters.AddWithValue("@ID", empId);
                            cmd.ExecuteNonQuery();
                            
                            if (time2 == 0)
                            {
                                using (var cmd2 = con.CreateCommand())
                                {
                                    cmd2.CommandText = "Update testSetTB Set Status = @Stat " +
                                    "where empId = @ID and Code = @Code";
                                    cmd2.Parameters.AddWithValue("@Stat", msg.ended);
                                    cmd2.Parameters.AddWithValue("@Code", code);
                                    cmd2.Parameters.AddWithValue("@ID", empId);
                                    cmd2.ExecuteNonQuery();
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
        public static void loadType(string code, string set, ComboBox cB)
        {
            try
            {
                cB.Text = ""; cB.Items.Clear();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Type from quesTB " +
                            "where Code = @Code and QSet = @Set";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Type"].ToString());
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
        public static void studOffline(string studId)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Update studLogTB SET Status = @Stat where studId = @ID";
                        cmd.Parameters.AddWithValue("@Stat", msg.offline);
                        cmd.Parameters.AddWithValue("@ID", studId);
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
        public static void editStudAns(DataGridView gVAns, string studId, string code, string set, string type, 
            Label num, TextBox ques, TextBox ans, Button btn, TextBox curAns)
        {
            try
            {
                string val = gVAns.CurrentRow.Cells[1].Value.ToString();
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from studAnsTB where studId = @ID and " +
                            "Code = @Code and QSet = @Set and Type = @Type and SAnswer = @Ans";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Ans", val);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                num.Text = dr["No"].ToString();
                                ques.Text = dr["QuesTion"].ToString();
                                ans.Text = val; curAns.Text = val; curAns.Visible = true;
                                btn.Text = "UPDATE";
                                ans.Focus();
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
        public static void dispStudAns(DataGridView gVAns, string studId, string code, string set, string type)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select No, SAnswer as Answer from studAnsTB " +
                        "where studId = '" + studId + "' and Code = '" + code + "' " +
                        "and QSet = '" + set + "' and Type = '" + type + "'", con);
                    adapt.Fill(dt);
                    gVAns.DataSource = dt;
                    misc.defGV(gVAns);
                    misc.sortStud(gVAns);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void editSQues(DataGridView gVQues, string studId, string code, string type, string set,
            Label num, TextBox ques, TextBox ans, Button btn, TextBox cAns)
        {
            try
            {
                num.Text = gVQues.CurrentRow.Cells[0].Value.ToString();
                ques.Text = gVQues.CurrentRow.Cells[1].Value.ToString();
                ans.Focus();
                ansExits(studId, code, set, type, num, ques, ans, btn);
                curAns(studId, code, set, type, cAns, ques, num);
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void dispChoice(DataGridView gV, string code, string set, string num)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select Choices from choiceTB where " +
                        "Code = '" + code + "'and QSet = '" + set + "' and No = '" + num + "'", con);
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
        public static void dispStudQues(DataGridView gVQues, string code, string set, string type,
            Label num, TextBox ques, Panel gBChoice, DataGridView gVChoice, string studId, 
            TextBox ans, Button btn, TextBox cAns)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("Select Distinct No, Question from quesTB " +
                        "where Code = '" + code + "' and QSet = '" + set + "' and Type = '" + type + "' " +
                        " ORDER BY No ASC", con);
                    adapt.Fill(dt);
                    gVQues.DataSource = dt;
                    misc.defGV(gVQues);
                    num.Text = gVQues.CurrentRow.Cells[0].Value.ToString();
                    ques.Text = gVQues.CurrentRow.Cells[1].Value.ToString();
                
                    if (type == "Multiple Choice")
                    {
                        gBChoice.Visible = true;
                        dispChoice(gVChoice, code, set, num.Text);
                    }
                    else
                    {
                        gBChoice.Visible = false;
                    }
                    ansExits(studId, code, set, type, num, ques, ans, btn);
                    curAns(studId, code, set, type, cAns, ques, num);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static void loadStudCode (TextBox studId, ComboBox cB)
        {
            try
            {
                cB.Items.Clear(); cB.Text = "";
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select Distinct Code from studSetTB " +
                            "where studId = @ID";
                        cmd.Parameters.AddWithValue("@ID", studId.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cB.Items.Add(dr["Code"].ToString());
                                cB.Focus();
                                studId.Enabled = false;
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
        public static void ansExits(string studId, string code, string set, string type, 
            Label num, TextBox ques, TextBox ans, Button btn)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select TOP 1 SAnswer from studAnsTB where studId = @ID and " +
                            "Code = @Code and QSet = @Set and Type = @Type and No = @Num and Question = @Ques";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Num", num.Text);
                        cmd.Parameters.AddWithValue("Ques", ques.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                ans.Text = dr["SAnswer"].ToString();
                                ans.Focus();
                                btn.Text = "UPDATE";
                            }
                            else
                            {
                                ans.Text = ""; ans.Focus(); btn.Text = "SUBMIT";
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
        public static void nextQues(string studId, string code, string set, string type,
            Label num, TextBox ques, TextBox ans, Button btn, DataGridView gVChoice, TextBox cAns)
        {
            try
            {
                int newNum = Convert.ToInt32(num.Text) + 1;

                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select * from quesTB where Code = @Code and QSet = @Set " +
                            "and Type = @Type and No = @Num";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Num", newNum.ToString());
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                ques.Text = dr["Question"].ToString();
                                num.Text = newNum.ToString();
                                ansExits(studId, code, set, type, num, ques, ans, btn);
                                curAns(studId, code, set, type, cAns, ques, num);
                            }
                            else
                            {

                            }
                            if (type == "Multiple Choice")
                            {
                                dispChoice(gVChoice, code, set, num.Text);
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
        public static void curAns(string studId, string code, string set, string type, 
            TextBox ans, TextBox ques, Label num)
        {
            try
            {
               
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select TOP 1 SAnswer from studAnsTB where studId = @ID and " +
                            "Code = @Code and QSet = @Set and Type = @Type and No = @Num and Question = @Ques";
                        cmd.Parameters.AddWithValue("@ID", studId);
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Num", num.Text);
                        cmd.Parameters.AddWithValue("@Ques", ques.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                ans.Visible = true;
                                ans.Text = dr["SAnswer"].ToString();
                            }
                            else
                            {
                                ans.Visible = false;
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
        public static void studAns(string studId, string code, string set, string type,
            Label num, TextBox ques, TextBox ans, DataGridView gVAns, 
            Button btn, DataGridView gVChoice, TextBox curAns)
        {
            try
            {
                using (var con = DBInfo.getCon())
                {
                  
                    if (ques.Text == "")
                    {
                        msg.selQues();
                    }
                    else
                    {
                        con.Open();
                        if (btn.Text == "SUBMIT")
                        {
                            using (var cmd = con.CreateCommand())
                            {

                                cmd.CommandText = "Insert into studAnsTB Values (@ID, @Code, @Set, @Type, " +
                                    "@Num, @Ques, @Ans, @Stat)";
                                cmd.Parameters.AddWithValue("@ID", studId);
                                cmd.Parameters.AddWithValue("@Code", code);
                                cmd.Parameters.AddWithValue("@Set", set);
                                cmd.Parameters.AddWithValue("@Type", type);
                                cmd.Parameters.AddWithValue("@Num", num.Text);
                                cmd.Parameters.AddWithValue("@Ques", ques.Text);

                                if (ans.Text == "")
                                    cmd.Parameters.AddWithValue("@Ans", msg.empty);
                                else
                                    cmd.Parameters.AddWithValue("@Ans", ans.Text);

                                cmd.Parameters.AddWithValue("@Stat", msg.tbu);
                                cmd.ExecuteNonQuery();

                                if (type == "Enumeration")
                                {
                                    if (misc.enuAns(studId, code, set, num.Text, ques.Text) == true)
                                    {
                                        nextQues(studId, code, set, type, num, ques, ans, btn, gVChoice, curAns);
                                    }
                                    else
                                    {
                                        ans.Text = ""; ans.Focus();
                                    }
                                }
                                else
                                {
                                    nextQues(studId, code, set, type, num, ques, ans, btn, gVChoice, curAns);
                                }
                            }
                        }
                        else
                        {
                            using (var cmd2 = con.CreateCommand())
                            {
                                cmd2.CommandText = "Update studAnsTB Set SAnswer = @Ans where Code = @Code " +
                                    "and studId = @ID and Type = @Type and QSet = @Set " +
                                    "and No = @Num and Question = @Ques and SAnswer = @Val";
                                cmd2.Parameters.AddWithValue("@ID", studId);
                                cmd2.Parameters.AddWithValue("@Code", code);
                                cmd2.Parameters.AddWithValue("@Set", set);
                                cmd2.Parameters.AddWithValue("@Type", type);
                                cmd2.Parameters.AddWithValue("@Num", num.Text);
                                cmd2.Parameters.AddWithValue("@Ques", ques.Text);
                                cmd2.Parameters.AddWithValue("@Ans", ans.Text);
                                cmd2.Parameters.AddWithValue("@Val", curAns.Text);
                                cmd2.ExecuteNonQuery();
                                btn.Text = "SUBMIT";
                                nextQues(studId, code, set, type, num, ques, ans, btn, gVChoice, curAns);
                            }
                        }
                        dispStudAns(gVAns, studId, code, set, type);
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
