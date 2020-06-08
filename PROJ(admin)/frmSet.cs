using System;
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

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            DbQ.loadSet(frmAdm.empId, tBFold, tBUser, tBPass, tBEmail, pBOk, btnVer);
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            tBFold.Text = misc.path();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            misc.codeSend(tBEmail.Text, frmAdm.empId);
            if (misc.emailSent == true)
            {
                msg.sentMsg();
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
                DbQ.upAdmEmail(tBCode.Text, frmAdm.empId, tBFold.Text, tBEmail, paneCode, btnVer, pBOk);
            }
        }

        private void tBPass_Enter(object sender, EventArgs e)
        {
            misc.passChar(tBPass);
        }

        private void tBPass_Leave(object sender, EventArgs e)
        {
            if (misc.valPass(tBPass.Text))
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
            if (misc.isEmailVer(tBEmail.Text, frmAdm.empId) == false)
            {
                pBOk.Image = Properties.Resources.Ok_icon__1_;
            }
            else
            {
                pBOk.Image = Properties.Resources.close;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
