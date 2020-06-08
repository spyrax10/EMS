using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace classLib
{
    public class DbQ
    {
        static SqlDataAdapter adapt;
        public static string getEmail(string empId)
        {
            string email;
            var con = DBInfo.getCon();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from admSet where empId = '" + empId + "' and emailStat = 'VERIFIED'";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                email = dr["email"].ToString();
            }
            else
            {
                email = "";
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
                            }
                        }

                    }
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

                                if (stat == msg.verified())
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
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }
        public static string empStat(string empId)
        {
            string stat = "";
            var con = DBInfo.getCon();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from empCre where empId = '" + empId + "'";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
               stat = dr["stat"].ToString();
            }

            return stat;
        }
        public static bool userValid;
        public static string getEmpId(string user)
        {
            var con = DBInfo.getCon();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select empId from empCre where username = '" + user + "'";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                user = dr["empId"].ToString();
                userValid = true;
            }
            else
            {
                userValid = false;
            }
            return user;
        }

        public static void codeLog(string code, string stat, string dateG, string dateU, string usrId)
        {
            try
            {
                var con = DBInfo.getCon();
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into codeLog values(@code, @Stat, @dateGen, @dateUse, @usrID)";
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@Stat", stat);
                cmd.Parameters.AddWithValue("@dateGen", dateG);
                cmd.Parameters.AddWithValue("@dateUse", dateU);
                cmd.Parameters.AddWithValue("@usrID", usrId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }

        public static void sysLog(string empId, string time, string date, string action)
        {
            var con = DBInfo.getCon();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into systemLog Values(@empId, @Time, @Date, @Action)";
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Action", action);
            cmd.ExecuteNonQuery();
            con.Close();
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
                    var con = DBInfo.getCon();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from empCre where username = '" + user + "' and password = '" + pass + "' ";
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        isPass = true;
                        msg.logSuc();          
                        sysLog(getEmpId(user), msg.time(), msg.date(), msg.logIn());
                    }
                    else
                    {
                        isPass = false;
                        msg.usrErr();                    
                        sysLog(user, msg.time(), msg.date(), msg.logInErr());
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
        }

        public static void empCre(string empId, string user, string pass, string udate, string stat)
        {
            try
            {
                var con = DBInfo.getCon();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into empCre values(@empId, @username, @password, @lastUpdate, @stat)";
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@lastUpdate", udate);
                cmd.Parameters.AddWithValue("@stat", stat);
                cmd.ExecuteNonQuery();
                con.Close();
                sysLog(empId, msg.time(), msg.date(), msg.accCreate());
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
            var con = DBInfo.getCon();
            try
            {
                if (code == "")
                {
                    msg.incMsg();
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from codeLog where code = '" + code + "' " +
                        "and Stat = '" + msg.codeNUse() + "' " +
                        "and dateGen = '" + msg.date() + "' " +
                        "and usrID = '" + usrId + "'";
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        SqlCommand ucmd = con.CreateCommand();
                        ucmd.CommandType = CommandType.Text;
                        ucmd.CommandText = "Update codeLog set Stat = '" + msg.codeUse() + "', " +
                            "dateUse = '" + msg.date() + "' where code = '" + code + "' " +
                            "and usrID = '" + usrId + "'";
                        ucmd.ExecuteNonQuery();
                        sysLog(usrId, msg.time(), msg.date(), msg.codeVerified() + code);
                        codeStat = true;
                    }
                    else
                    {
                        msg.invCode();
                        codeStat = false;
                    }
                }
              
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                misc.crashRep(e.Message);
            }
            con.Close();
        }
        public static void upAdmEmail(string code, string empId, string path, TextBox email,
            Panel pane, Button btn, PictureBox pB)
        {
            try
            {
                chkCode(code, empId);
                if (codeStat == true)
                {
                    using (var con = DBInfo.getCon())
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            con.Open();
                            cmd.CommandText = "Update admSet SET foldPath = @Path, " +
                                "email = @Email, eStat = @Stat where empId = @ID";
                            cmd.Parameters.AddWithValue("@Path", path);
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            cmd.Parameters.AddWithValue("@Stat", msg.verified());
                            cmd.Parameters.AddWithValue("ID", empId);
                            cmd.ExecuteNonQuery();
                            msg.emailVer();
                            code = "";
                            pane.Visible = false;
                            btn.Enabled = true;
                            pB.Image = Properties.Resources.ok;
                            email.Enabled = true;
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
        public static void admSet(string empId, string path, string email, string stat)
        {
            try
            {
                var con = DBInfo.getCon();

                con.Open();
                SqlCommand icmd = con.CreateCommand();
                icmd.CommandType = CommandType.Text;
                icmd.CommandText = "Insert into admSet values(@empId, @foldPath, @email, @emailStat)";
                icmd.Parameters.AddWithValue("@empId", empId);
                icmd.Parameters.AddWithValue("@foldPath", path);
                icmd.Parameters.AddWithValue("@email", email);
                icmd.Parameters.AddWithValue("@emailStat", stat);
                icmd.ExecuteNonQuery();
                msg.accSuc();
                con.Close();
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

                    cmd.CommandText = "Select * from empTB where empId = '" + ID.Text + "';" +
                        "Select * from studTB where studId = '" + ID.Text + "'";
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
        public static bool isSucess;
        public static void empCreate (Control pane, string empId, string dept, string first, 
            string mid, string last, string cont, string pro, string mun,
            string bar, string pur, string mob, string email)
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
                    else if (misc.emailCount(email) == true)
                    {
                        msg.emailAbuse();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "Insert into empTB values(@empId, @Department, " +
                                 "@Firstname, @Midname, @Lastname, @Country, @Province, @Municipality, " +
                                 "@Barangay, @Purok, @Mobile, @Email, @eStat, @Image)";
                        cmd.Parameters.AddWithValue("@empId", empId);
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
                        cmd.Parameters.AddWithValue("@eStat", msg.nverified());
                        cmd.Parameters.Add(new SqlParameter("@Image", img));
                        cmd.ExecuteNonQuery();
                        isSucess = true;
                        msg.accSuc();
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
        public static void studCreate (Control pane, string empId, string dept, string cour, string year,
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
                        else if (misc.emailCount(email) == true)
                        {
                            msg.emailAbuse();
                        }
                        else
                        {
                            con.Open();
                            cmd.CommandText = "Insert into studTB values(@empId, @Department, @Course, @Year, " +
                                     "@Firstname, @Midname, @Lastname, @Country, @Province, @Municipality, " +
                                     "@Barangay, @Purok, @Mobile, @Email, @eStat, @Image)";
                            cmd.Parameters.AddWithValue("@empId", empId);
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
                            cmd.Parameters.AddWithValue("@eStat", msg.nverified());
                            cmd.Parameters.Add(new SqlParameter("@Image", img));
                            cmd.ExecuteNonQuery();
                            isSucess = true;
                            msg.accSuc();
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
            catch (Exception e)
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
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select studId as StudId, " +
                        "dbo.allCap(Department) as Department, dbo.allCap(Course) as Course , " +
                        "Lastname, Firstname, Email from studTB", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
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
                using (var cmd = con.CreateCommand())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select empId as EmpId, " +
                        "Department, Lastname, Firstname, Mobile, Email from empTB", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
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
        public static void updateStud(DataGridView gV, Control pane, TextBox id,
            TextBox dept, TextBox cour, TextBox year, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox email, TextBox pur, ComboBox count, ComboBox pro, ComboBox mun, ComboBox bar, 
            Control pane2, Control pane3)
        {
            try
            {
                if (misc.isEmptyFields(pane))
                {
                    msg.incMsg();
                }
                else if (misc.emailCount(email.Text) == true)
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
                            pane.Visible = false;
                            pane2.Enabled = false;
                            pane3.Visible = true;
                            loadStudSub(gV, id);
                            misc.defGV(gV);
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
        public static void updateEmp(Control pane, TextBox empId,
            TextBox dept, TextBox first, TextBox mid, TextBox last,
            TextBox mob, TextBox email, TextBox pur, ComboBox count, 
            ComboBox pro, ComboBox mun, ComboBox bar, PictureBox pb, Button btn)
        {
            try
            {
                if (misc.isEmptyFields(pane))
                {
                    msg.incMsg();
                }
                else if (misc.emailCount(email.Text) == true)
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
                            cmd.Parameters.AddWithValue("@Id", empId.Text);
                            cmd.ExecuteNonQuery();
                            msg.accSuc();
                            misc.clrCont(pane);
                            pane.Enabled = false;
                            empId.Enabled = true;
                            empId.Text = "";
                            empId.Focus();
                            btn.Text = "REGISTER";
                            pb.Image = Properties.Resources._default;
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
                            cmd.CommandText = "Update studSubTB Set Code = '" + code.Text + "', Name = '" + desc.Text + "' " +
                                " where studId = '" + id.Text + "'";
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
                using(var cmd = con.CreateCommand())
                {
                    con.Open();
                    adapt = new SqlDataAdapter("Select Code, Name from studSubTB where studId = '" + id.Text + "'", con);
                    adapt.Fill(dt);
                    gV.DataSource = dt;
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
    }
}
