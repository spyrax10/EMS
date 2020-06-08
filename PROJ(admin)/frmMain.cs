using classLib;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PROJ_admin_
{
    public partial class frmMain : Form
    {
        int move, left = 5;
        private static frmAdm admFrm = new frmAdm();
        private static frmEmp empFrm = new frmEmp();
        public static string empId;
        
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DBInfo.conStat() == true)
            {
                hideForm();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                msg.serverErr();
                Application.Exit();
            }
        }

        public void hideForm()
        {
            misc.hideCont(paneMain);
            misc.clrCont(gBNot);
            paneFor.Visible = false;
            lblReCode.Visible = false;
            lblPass2.Visible = false;
            lblPass.Visible = false;
            paneCode.Visible = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            paneSlide.Left += 2;

            if (paneSlide.Left > 265)
            {
                paneSlide.Left = 0;
            }
            if (paneSlide.Left < 0)
            {
                move = 2;
            }
        }
        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tBLUser.Text == "")
            {
                msg.userNeed();
            }
            else
            {
                string empId = DbQ.getEmpId(tBLUser.Text);
                if (DbQ.userValid == true)
                {
                    if (DbQ.getEmail(empId) != "")
                    {
                        misc.codeSend(DbQ.getEmail(empId), empId);
                        lblForgot.Visible = false;
                    }
                    paneFor.Visible = true;
                }
                else
                {
                    msg.usrInv();
                }           
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (misc.isEmptyFields(gBadmCre) == true)
            {
                msg.incMsg();
            }
            if (misc.passMatch(tBCPass, tBCPass2) == false)
            {
                lblPass.Visible = true;
                lblPass.Text = msg.matchErr();
            }
            else
            {
                DbQ.empCre(tBId.Text, tBCUser.Text, tBCPass.Text, msg.date(), "ADMIN");
                gBNot.Visible = true;
                gBadmCre.Visible = false;
                lblID.Text = tBId.Text;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (paneCode.Visible == true)
            {
                msg.verMsg();
                tBCode.Focus();
            }
            else
            {
                DbQ.admSet(lblID.Text, tBPath.Text, tBEmail.Text, msg.nverified());
                hideForm();
                gBLog.Visible = true;
            }
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            tBPath.Text = misc.path();
        }

        private void tBCUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.invChar(e);
        }

        private void tBId_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.invSpace(e);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            misc.codeSend(tBEmail.Text, lblID.Text);
            if (misc.emailSent == true)
            {
                msg.sentMsg();
                paneCode.Visible = true;
                btnVer.Enabled = false;
                lblReCode.Visible = true;
                btnFin.Visible = false;
                tBCode.Focus();
            }
        }

        private void tBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DbQ.chkCode(tBCode.Text, lblID.Text);

                if (DbQ.codeStat == true)
                {
                    DbQ.admSet(lblID.Text, tBPath.Text, tBEmail.Text, msg.verified());
                    misc.usrCode(lblID.Text);
                    hideForm();
                    gBLog.Visible = true;           
                }
                else
                {
                    tBCode.Text = "";
                }
            }
        }

        private void tBCPass_Leave(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (misc.valPass(tb.Text) == true)
            {
                lblPass.Visible = false;
            }
            else
            {
                lblPass.Visible = true;
                lblPass.Text = msg.valPass(); tb.Focus();
            }
        }

        private void tBCPass2_Leave(object sender, EventArgs e)
        {
            if (misc.passMatch(tBCPass, tBCPass2) == false)
            {
                lblPass.Visible = true;
                lblPass.Text = msg.matchErr();
            }
            else
            {
                lblPass.Visible = false;
            }
        }

        private void lblReCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tBCode.Text = "";
            tBEmail.Text = "";
            lblReCode.Visible = false;
            paneCode.Visible = false;
            btnVer.Enabled = true;
            btnFin.Visible = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (misc.passMatch(tBLPass, tBLPass2) == false)
            {
                lblPass2.Visible = true;
                lblPass2.Text = msg.matchErr();
            }
            else
            {
                DbQ.empLog(tBLUser.Text, tBLPass.Text, tBLPass2.Text);
                empId = DbQ.getEmpId(tBLUser.Text);

                if (DbQ.isPass == true)
                {
                    if (DbQ.empStat(empId) == "ADMIN")
                    {
                        misc.usrCode(empId);
                        admFrm.Visible = true;
                        this.Visible = false;
                    }
                    else if (DbQ.empStat(empId) == "EMP")
                    {
                        empFrm.Visible = true;
                        this.Visible = false;
                    }
                }
            }
           
        }

        private void tBLPass_Leave(object sender, EventArgs e)
        {
            misc.invPass(sender, lblPass2);
        }

        private void lblAdLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DBInfo.conStat() == true)
            {
                if (DBInfo.admChk() == false)
                {
                    gBadmCre.Visible = true;
                }
                else if (DBInfo.admChk() == true)
                {
                    gBLog.Visible = true;
                }
                gBMain.Visible = false;
            }
            else
            {
                msg.serverErr();
            }
        }
        private void tBForCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                empId = DbQ.getEmpId(tBLUser.Text);
                DbQ.chkCode(tBForCode.Text, empId);

                if (DbQ.codeStat == true)
                {
                    msg.logSuc();
                    DbQ.sysLog(empId, msg.time(), msg.date(), msg.logInVC() + tBForCode.Text);
                    if (DbQ.empStat(empId) == "ADMIN")
                    {
                        misc.usrCode(empId);
                        admFrm.Visible = true;
                        this.Visible = false;
                    }
                    else if (DbQ.empStat(empId) == "EMP")
                    {
                        empFrm.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    tBForCode.Focus(); tBForCode.Text = "";
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            left--;
            if (left == 0)
            {
                timer1.Stop();
                timer2.Stop();
                paneLogo.Visible = false;

                if (DBInfo.conStat() == true)
                {
                    gBMain.Visible = true;
                }
                else
                {
                    msg.serverErr();
                }
            }
        }
    }
}
