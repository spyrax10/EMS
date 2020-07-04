using System;
using System.Drawing;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }
        public void close()
        {
            this.Close();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            close();
        }
        public void load()
        {
            if (DbQ.empStat(frmMain.empId) == "EMP")
            {
                lblFold.Visible = false;
                tBFold.Visible = false;
                btnBrow.Visible = false;
            }
            DbQ.loadSet(frmMain.empId, tBFold, tBUser, tBPass, tBEmail, pBOk, btnVer);
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            tBFold.Text = misc.path();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            misc.codeSend(tBEmail.Text, frmMain.empId);
            if (misc.emailSent == true)
            {
                tBEmail.Enabled = false;
                pBOk.Image = Properties.Resources.close;
                paneCode.Visible = true;
                btnVer.Enabled = false;
                tBCode.Focus();
            }
        }

        private void tBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DbQ.upAdmEmail(paneCode, tBCode.Text, frmMain.empId, tBFold.Text, tBEmail, load);
            }
        }

        private void tBPass_Enter(object sender, EventArgs e)
        {
            misc.passChar(tBPass);
        }

        private void tBPass_Leave(object sender, EventArgs e)
        {
            if (misc.valPass(tBPass.Text) == true)
            {
                misc.passChar(tBPass);
                lblPass.Visible = false;
            }
            else
            {
                lblPass.Visible = true;
                lblPass.Text = msg.valPass(); tBPass.Focus();
            }
        }
        private void tBEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (misc.isEmailVer(tBEmail.Text, frmMain.empId) == true)
            {
                pBOk.Image = Properties.Resources.Ok_icon__1_;
                btnVer.Text = "CHANGE";
                btnVer.ForeColor = Color.Lime;
            }
            else
            {
                pBOk.Image = Properties.Resources.close;
                btnVer.Text = "VERIFY";
                btnVer.ForeColor = Color.Red;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DbQ.empStat(frmMain.empId) == "ADMIN")
            {
                DbQ.upAdmSet(frmMain.empId, tBUser.Text, tBPass.Text, tBFold.Text, tBEmail.Text, close);
            }
            else
            {
                DbQ.upEmpSet(frmMain.empId, tBUser.Text, tBPass.Text, tBEmail.Text, close);
            }
        }
    }
}
