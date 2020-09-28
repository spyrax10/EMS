using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing.Imaging;

namespace classLib
{
    
    public class misc
    {
        public static string imgLoc = "";
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        [Obsolete]
        public static string ip = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();

        public static Form activeForm = null;
        public static int second = 59;

        public static string getPC(string ip)
        {
            string pc = "";
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ip);
                if (entry != null)
                {
                    pc = entry.HostName.ToString();
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                crashRep(e.Message);
            }
            return pc;
        }
        public static void saveRes(string studId, Panel pane)
        {
            try
            {
                Bitmap bmp = new Bitmap(pane.Width, pane.Height, PixelFormat.Format32bppArgb);
                Rectangle capRec = Screen.AllScreens[0].Bounds;
                Graphics capGraph = Graphics.FromImage(bmp);
                capGraph.CopyFromScreen(capRec.Left, capRec.Top, 0, 0, capRec.Size);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Screenshot";
                sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
                sfd.FileName = studId;
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    bmp.Save(sfd.FileName, format);
                }
                else
                {
                    return;
                }
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                crashRep(e.Message);
            }
        }
        public static void enableTask()
        {
            try
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                objRegistryKey.DeleteValue("DisableTaskMgr");
                objRegistryKey.Close();
            }
            catch (Exception e)
            {
                crashRep(e.Message);
            }
        }

        public static void disableTask()
        {
            try
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (objRegistryKey.GetValue("DisableTaskMgr") == null)
                    objRegistryKey.SetValue("DisableTaskMgr", "1");
            }
            catch(Exception e)
            {
                msg.expMsg(e.Message);
                crashRep(e.Message);
            }
        }
        public static bool enuAns(string studId, string code, string set, string num, string ques)
        {
            bool stat = false; int c1, c2;
            try
            {
                using (var con = DBInfo.getCon())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {                  
                        cmd.CommandText = "Select Count(Answer) from quesTB where Code = @Code and QSet = @Set " +
                            "and Type = @Type and No = @Num and Question = @Ques";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Set", set);
                        cmd.Parameters.AddWithValue("@Type", "Enumeration");
                        cmd.Parameters.AddWithValue("@Num", num);
                        cmd.Parameters.AddWithValue("@Ques", ques);
                        object ob = cmd.ExecuteScalar();
                        c1 = Convert.ToInt32(ob);
                    }
                    using (var cmd2 = con.CreateCommand())
                    {
                        cmd2.CommandText = "Select Count(SAnswer) from studAnsTB where studId = @ID and " +
                            "Code = @Code and QSet = @Set and Type = @Type and No = @Num and Question = @Ques";
                        cmd2.Parameters.AddWithValue("@ID", studId);
                        cmd2.Parameters.AddWithValue("@Code", code);
                        cmd2.Parameters.AddWithValue("@Set", set);
                        cmd2.Parameters.AddWithValue("@Type", "Enumeration");
                        cmd2.Parameters.AddWithValue("@Num", num);
                        cmd2.Parameters.AddWithValue("@Ques", ques);
                        object ob2 = cmd2.ExecuteScalar();
                        c2 = Convert.ToInt32(ob2);
                    }
                    if (c1 == c2)
                    {
                        stat = true;
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                crashRep(e.Message);
            }
            return stat;
        }
        public static int minute(string code)
        {
            int min = 0;
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from testSetTB where Code = @Code and Status = @Stat and Date = @Date";
                        cmd.Parameters.AddWithValue("@Code", code);
                        cmd.Parameters.AddWithValue("@Stat", msg.start);
                        cmd.Parameters.AddWithValue("@Date", msg.date);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                min = Convert.ToInt32(dr["Duration"].ToString()) -1;
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
            return min;
        }

        public static string aZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }
        public static void fullScr(Form frm)
        {
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
        }
        public static void passChar(TextBox tB)
        {
            if (tB.PasswordChar != '\0')
            {
                tB.PasswordChar = '\0';
            }
            else
            {
                tB.PasswordChar = '*';
            }
        }
        public static void sortStud(DataGridView gV)
        {
            if (gV.Rows.Count != 0)
            {
                string val = gV.Rows[0].Cells[0].Value.ToString();
                
                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[0].Value.ToString() == val)
                    {
                        gV.Rows[i].Cells[0].Value = string.Empty;
                    }
                    else
                    {
                        val = gV.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
        }
        public static void sortExam(DataGridView gV)
        {
            if (gV.Rows.Count != 0)
            {
                string val1 = gV.Rows[0].Cells[1].Value.ToString();
                string val2 = gV.Rows[0].Cells[0].Value.ToString();
                string val3 = gV.Rows[0].Cells[2].Value.ToString();
                string val4 = gV.Rows[0].Cells[3].Value.ToString();

                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[3].Value.ToString() == val4)
                    {
                        gV.Rows[i].Cells[3].Value = string.Empty;
                    }
                    else
                    {
                        val4 = gV.Rows[i].Cells[3].Value.ToString();
                    }
                }

                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[1].Value.ToString() == val1)
                    {
                        gV.Rows[i].Cells[1].Value = string.Empty;
                    }
                    else
                    {
                        val1 = gV.Rows[i].Cells[1].Value.ToString();
                    }
                }
                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[0].Value.ToString() == val2)
                    {
                        gV.Rows[i].Cells[0].Value = string.Empty;
                    }
                    else
                    {
                        val2 = gV.Rows[i].Cells[0].Value.ToString();
                    }
                }
                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[2].Value.ToString() == val3)
                    {
                        gV.Rows[i].Cells[2].Value = string.Empty;
                    }
                    else
                    {
                        val3 = gV.Rows[i].Cells[2].Value.ToString();
                    }
                }
            }
        }

        public static void sortGV(DataGridView gV)
        {
            if (gV.Rows.Count > 0)
            {
                string val1 = gV.Rows[0].Cells[1].Value.ToString();
                string val2 = gV.Rows[0].Cells[0].Value.ToString();
               
                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[1].Value.ToString() == val1)
                    {
                        gV.Rows[i].Cells[1].Value = string.Empty;
                    }
                    else
                    {
                        val1 = gV.Rows[i].Cells[1].Value.ToString();
                    }
                }
                for (int i = 1; i < gV.Rows.Count; i++)
                {
                    if (gV.Rows[i].Cells[0].Value.ToString() == val2)
                    {
                        gV.Rows[i].Cells[0].Value = string.Empty;
                    }
                    else
                    {
                        val2 = gV.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            
        }
        public static bool emailCount(string email, string id)
        {
            bool stat = false;
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select dbo.emC(@Email)";
                        cmd.Parameters.AddWithValue("@Email", email);
                        object cnt = cmd.ExecuteScalar();
                        int num = Convert.ToInt32(cnt);

                        if (DbQ.verEmail(email, id) == true)
                        {
                            if (num <= 3)
                            {
                                stat = true;
                            }
                            else
                            {
                                stat = false;
                            }
                        }
                        else if (DbQ.verEmail(email, id) == false)
                        {
                            if (num < 3)
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
                crashRep(e.Message);
            }
            return stat;
        }
        public static void disOrd(DataGridView gV)
        {
            foreach (DataGridViewColumn column in gV.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public static void defGV(DataGridView gV)
        {
            gV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            gV.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            gV.Columns[0].Width = 95;
        }
        public static void capFirst(Object sender)
        {
            var tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                tb.Text = Char.ToUpper(tb.Text[0]) + tb.Text.Substring(1);
            }
        }

        public static bool isEmptyFields(Control comp)
        {
            if(comp.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)) ||
               comp.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }       
        }
        public static void hideCont(Control comp)
        {
            comp.Controls.OfType<GroupBox>().ToList().ForEach(t => t.Visible = false);
        }
        public static void clrCont(Control comp)
        {
            comp.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            comp.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Text = "");
            comp.Controls.OfType<Panel>().ToList().ForEach(t => t.Text = "");
           
            foreach (Control c in comp.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control d in c.Controls)
                    {
                        if (d is TextBox)
                        {
                            d.Text = "";
                        }
                        if (d is ComboBox)
                        {
                            d.Text = "";
                        }
                        if (d is DataGridView)
                        {
                            d.Refresh();
                        }
                    }
                }
            }
        }
        public static void invChar(KeyPressEventArgs evt)
        {
            if (evt.Handled = Char.IsWhiteSpace(evt.KeyChar) ||
               Char.IsPunctuation(evt.KeyChar) ||
               Char.IsSymbol(evt.KeyChar))
            {
                msg.invCharac();
            }
        }
        public static void numOnly(KeyPressEventArgs evt)
        {
            if(evt.Handled = char.IsLetter(evt.KeyChar) ||
                char.IsWhiteSpace(evt.KeyChar) ||
                char.IsPunctuation(evt.KeyChar) ||
                char.IsSymbol(evt.KeyChar))
            {
                msg.numOnly();
            }
        }
        public static void invSpace(KeyPressEventArgs evt)
        {
            if (evt.Handled = Char.IsWhiteSpace(evt.KeyChar))
            {
                msg.invCharac();
            }
        }
        public static void invPass(object send, Label lbl)
        {
            var tb = (TextBox)send;
            if (misc.valPass(tb.Text) == true)
            {
                lbl.Visible = false;
            }
            else
            {
                lbl.Visible = true;
                lbl.Text = msg.valPass(); tb.Focus();
            }

        }
        public static void opnChild(Panel pane, Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pane.Controls.Add(childForm);
            pane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void selImg(PictureBox img)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tif;...";
            dlg.Title = "Select a Photo";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                img.ImageLocation = imgLoc;
            }
        }
        public static bool chkInt(bool stat)
        {
            int Desc;
            stat = InternetGetConnectedState(out Desc, 0);

            return stat;
        }
        public static string buildInfo()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var num = registryKey.GetValue("UBR").ToString();
            var cur = registryKey.GetValue("CurrentBuild").ToString();
            return cur + "." + num;
        }
        public static string getSql()
        {
            string sqlName = "";
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                       
                        sqlName = Environment.MachineName + @"\" + instanceName;
                    }
                }
                else
                {
                    sqlName = "";
                }
                
            }
            return sqlName;
        }
     
        public static string path()
        {
            var diag = new FolderBrowserDialog();
            string pName;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                pName = diag.SelectedPath + "\\";
            }
            else
            {
                pName = "";
            }
            return pName;
        }
        public static string randCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();
            bool containsNum = false;

            do
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                if (stringChars.Any(char.IsDigit))
                {
                    containsNum = true;
                }

            } while (!containsNum);

            var final = new String(stringChars);

            return final;
        }
        public static void crashDet(string path, string stat)
        {
            try
            {
                string usr = System.Environment.UserName;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Date: " + msg.date);
                    sw.WriteLine("Time: " + msg.time + Environment.NewLine);
                    sw.WriteLine("Current User: " + usr);
                    sw.WriteLine("OS Build Info: " + new ComputerInfo().OSFullName + " | " + buildInfo());
                    sw.WriteLine("SQL Version: " + getSql() + Environment.NewLine);
                    sw.WriteLine("Total Memory: " + new ComputerInfo().TotalPhysicalMemory);
                    sw.WriteLine("Available Memory: " + new ComputerInfo().AvailablePhysicalMemory + Environment.NewLine);
                    sw.WriteLine("Reason: " + stat);
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
            }   
        }
        private static string fname(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                if (i == 0)
                    fileName = fileName.Replace(extension, "(" + ++i + ")" + extension);
                else
                    fileName = fileName.Replace("(" + i + ")" + extension, "(" + ++i + ")" + extension);
            }

            return fileName;
        }
        public static void crashRep(string stat)
        {            
            string path = @"..\..\Log\Crash\Crash Report.txt";
            crashDet(fname(path), stat);
        }
        public static void usrCode(string user)
        {
            try
            {
                string path = @"..\..\Log\" + user + ".txt";
               // string path = "Log\\" + user + ".txt";
                string code = randCode();

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(code);
                    }
                    DbQ.codeLog(code, msg.codeNUse, msg.date, "", DbQ.getEmpId(user)); ;
                    DbQ.sysLog(user, msg.time, msg.date, msg.codeReq + code);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 
        }

        public static bool passMatch(TextBox pass, TextBox pass2)
        {
            bool IsMatch = pass.Text == pass2.Text;
            if (IsMatch == false)
            {
                pass.Focus();
                pass.Text = ""; 
                pass2.Text = "";
            }
            return IsMatch;
        }
        public static bool valPass(string password)
        {
            string pat = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{5,}$";
            bool match = Regex.IsMatch(password, pat);
            return match;
        }
        public static bool numFormat(string mob)
        {
            bool isValid = mob.Length == 11 && mob.Substring(0, 2) == "09";
            return isValid;
        }
        public static bool valEmail (string email)
        { 
            string _regexPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            bool stat = Regex.IsMatch(email, _regexPattern) == true && email != "";
            
            return stat;
        }

        public static bool isEmailVer(string email, string id)
        {
            bool stat = false;
            try
            {
                using (var con = DBInfo.getCon())
                {
                    using (var cmd = con.CreateCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Select * from admSet where email = @Email and empId = @ID and eStat = 'VERIFIED';" +
                            "Select * from empTB where Email = @Email and empId = @ID and eStat = 'VERIFIED';" +
                            "Select * from studTB where Email = @Email and studId = @ID and eStat = 'VERIFIED';";
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

                            } while (dr.NextResult());
                        }
                    }
                }
            }
            catch (Exception f)
            {
                msg.expMsg(f.Message);
                crashRep(f.Message);
            }
            return stat;
        }
        public static bool emailSent;
        public static void codeSend(string email, string userId)
        {
            string date = DateTime.Now.ToShortDateString();
            string code = randCode();

            try
            {
                if (valEmail(email) == false)
                {
                    emailSent = false;
                    msg.invEmail();
                }
                else if (userId == "")
                {
                    emailSent = false;
                    msg.userNeed();               
                }
                else if (emailCount(email, userId) == false)
                {
                    emailSent = false;
                    msg.emailAbuse();
                }
                else
                {
                    if (chkInt(true))
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(DBInfo.username);
                        mail.To.Add(email);

                        mail.Subject = "Account Verification";
                        mail.Body = "Code: " + code + "" + Environment.NewLine + "" +
                            "Date Generate: " + date + "" + Environment.NewLine + "" +
                            "" + Environment.NewLine + "" +
                            "" + Environment.NewLine + "" +
                            "Login the code to the app to verify email address. Thank you!" + Environment.NewLine + "" +
                            "" + Environment.NewLine + "" +
                            "Regards," +
                            "" + Environment.NewLine + "" +
                            "- spyrax10";

                        client.Port = 587;
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        client.Credentials = new System.Net.NetworkCredential(DBInfo.username, DBInfo.password);
                        client.Send(mail);

                        DbQ.codeLog(code,
                           msg.codeNUse,
                           msg.date, "",
                           userId);

                        DbQ.sysLog(msg.sysName, msg.time, msg.date, msg.codeReq + code);
                        emailSent = true;
                        msg.sentMsg();
                    }
                    else
                    {
                        emailSent = false;
                        msg.noInt();             
                    }
                }
            }
            catch (Exception e)
            {
                msg.expMsg(e.Message);
                crashRep(e.Message);
                emailSent = false;
            }
        }
    }
}
