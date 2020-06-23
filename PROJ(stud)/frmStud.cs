using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_stud_
{
    public partial class frmStud : Form
    {
        int move, left = 5;
        public frmStud()
        {
            InitializeComponent();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DbQ.loadStudCode(tBID, cBCode);
            }
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

        private void cBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBCode.Text == "")
            {
                msg.incMsg();
            }
            else
            {
                DbQ.studSet(tBID.Text, cBCode, tBSet);
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            tBID.Text = "";
            tBID.Enabled = true;
            cBCode.Text = "";
            cBCode.Items.Clear();
            cBCode.Enabled = true;
            tBSet.Text = "";
            tBID.Focus();
        }

        [Obsolete]
        private void btnStart_Click(object sender, EventArgs e)
        {
            DbQ.studLog(tBID.Text, cBCode.Text, tBSet.Text, timer);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            left--;
            if (left == 0)
            {
                timer1.Stop();
                timer2.Stop();
                paneLogo.Visible = false;
                gBDet.Visible = true;
            }
        }
    }
}
