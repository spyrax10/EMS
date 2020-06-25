using System;
using System.Drawing;
using System.Windows.Forms;
using classLib;

namespace PROJ_stud_
{
    public partial class frmStud : Form
    {
        int move, left = 5, min = 0, second = 59, sec = 59;
        public frmStud()
        {
            InitializeComponent();
        }

        public void info()
        {
            lblID.Text = tBID.Text;
            lblCode.Text = cBCode.Text;
            lblTStart.Text = msg.time;
            lblSet.Text = tBSet.Text;
        }
        public void def()
        {
            timer1.Stop();
            timer2.Stop();
            timer.Stop();
            paneLogo.Visible = false;
            paneExam.Visible = false;
            lblTime.Visible = false;
            gBDet.Visible = true;
        }
        public void showExam()
        {
            lblTime.Visible = true;
            lblDisp.Visible = false;
            gBDet.Visible = false;
            info();
            DbQ.loadType(cBCode.Text, tBSet.Text, cBType);
            DbQ.studStart(tBID.Text, cBCode.Text);
            gBChoice.Visible = false;
            paneExam.Visible = true;
            paneExam.BringToFront();
            tBAns.Focus();
            misc.fullScr(this);
        }
        private void pBClose_Click(object sender, EventArgs e)
        {
            DbQ.studOffline(lblID.Text);
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
            btnStart.Enabled = true;
            tBID.Focus();
        }

        [Obsolete]
        private void btnStart_Click(object sender, EventArgs e)
        {
            DbQ.studLog(tBID.Text, cBCode.Text, tBSet.Text, examTimer, colTime,
                lblDisp, btnStart);
        }

        private void cBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBType.Text != "")
            {
                DbQ.dispStudQues(gVQues, lblCode.Text, lblSet.Text, 
                    cBType.Text, lblNum, tBQues, tBAns);
            }
        }

        private void colTime_Tick(object sender, EventArgs e)
        {
            if (lblDisp.ForeColor == Color.DodgerBlue)
            {
                lblDisp.ForeColor = Color.White;
            }
            else
            {
                lblDisp.ForeColor = Color.DodgerBlue;
            }
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            if (misc.minute(cBCode.Text) > 0)
            {
                examTimer.Stop();
                min = misc.minute(cBCode.Text);
                showExam();
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                min--;
                second = 59;
            }
            if (min == 0)
            {
                sec--;
                if (sec == 0)
                {
                    timer.Stop();
                }
            }
            lblTime.Text = misc.aZero(min) + " : " + misc.aZero(second);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            left--;
            if (left == 0)
            {
                def();
            }
        }
    }
}
