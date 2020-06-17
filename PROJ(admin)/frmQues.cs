using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmQues : Form
    {
        public frmQues()
        {
            InitializeComponent();
        }
        public void def()
        {
            DbQ.loadSub(frmMain.empId, cBSub);
            misc.clrCont(gBQues);
            misc.clrCont(gBDet);
            paneIns.BringToFront();
            gBDet.Enabled = false;
            cBSub.Enabled = true;
            cBPer.Enabled = true;
            lblErr.Visible = false;
            tBCode.Enabled = true;
            tBCode.Focus();
        }

        private void frmQues_Load(object sender, EventArgs e)
        {
            def();
        }

        private void tBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DbQ.codeCheck(gBDet, tBCode);
            }
        }

        private void cBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (misc.isEmptyFields(gBDet) == true)
            {
                cBType.Text = null;
                lblErr.Visible = true;
                paneIns.BringToFront();
            }
            else
            {
                misc.typePane(cBType, paneIden, paneEnu, paneMulti);
                cBSub.Enabled = false;
                cBPer.Enabled = false;
                lblErr.Visible = false;
            }
        }

        private void btnRefDet_Click(object sender, EventArgs e)
        {
            def();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
