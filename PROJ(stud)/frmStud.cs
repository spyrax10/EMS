using System;
using System.Data.SqlClient;
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
            SqlConnection.ClearAllPools();
        }

        public void info()
        {
            lblID.Text = tBID.Text;
            lblCode.Text = cBCode.Text;
            lblTStart.Text = msg.time;
            lblSet.Text = tBSet.Text;
        }
        public void info2()
        {
            lblID2.Text = lblID.Text;
            lblCode2.Text = lblCode.Text;
            lblPer2.Text = lblPer.Text;
            lblTStart2.Text = lblTStart.Text;
            lblSet2.Text = lblSet.Text;
            lblTEnd.Text = msg.time;
        }
        public void showScore()
        {
            timer.Stop();
            paneExam.Visible = false;
            info2();
            DbQ.calScore(lblID.Text, lblCode.Text, lblSet.Text,
                tBIdenCor, tBIdenTot, tBEnuCor, tBEnuTot, tBMulCor, tBMulTot,
                tBTotCor, tBTotAns, tBGrade, lblPer.Text);
            gBRes.Visible = true;
            gBRes.BringToFront();
            DbQ.dispAns(gVRes, lblID.Text, lblCode.Text, lblSet.Text);      
        }
        public void def()
        {
            timer1.Stop();
            timer2.Stop();
            timer.Stop();
            paneLogo.Visible = false;
            paneExam.Visible = false;
            lblTime.Visible = false;
            tBCurAns.Visible = false;
            gBDet.Visible = true;
        }
        public void refresh()
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
        public void showExam()
        {
            lblTime.Visible = true;
            lblDisp.Visible = false;
            gBDet.Visible = false;
            gBRes.Visible = false;
            pBClose.Visible = false;
            info();
            DbQ.loadType(cBCode.Text, tBSet.Text, cBType);
            DbQ.studStart(tBID.Text, cBCode.Text);
            paneChoice.Visible = false;
            paneExam.Visible = true;
            paneExam.BringToFront();
            tBAns.Focus();
            misc.fullScr(this);
            misc.disableTask();
        }
        public void close()
        {
            DbQ.studOffline(lblID.Text);
            misc.enableTask();
            Application.Exit();
        }
        private void pBClose_Click(object sender, EventArgs e)
        {
            close();
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
            refresh();
        }

        [Obsolete]
        private void btnStart_Click(object sender, EventArgs e)
        {
            DbQ.studLog(tBID.Text, cBCode.Text, tBSet.Text, examTimer, colTime,
                lblDisp, btnStart, refresh, lblPer);
        }

        private void cBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBType.Text != "")
            {
                DbQ.dispStudQues(gVQues, lblCode.Text, lblSet.Text, 
                    cBType.Text, lblNum, tBQues, paneChoice, gVChoice, lblID.Text, tBAns, btnOk, tBCurAns);
                DbQ.dispStudAns(gVAns, lblID.Text, lblCode.Text, lblSet.Text, cBType.Text);
            }
        }

        private void gVQues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVQues.Rows.Count > 0)
            {
                DbQ.editSQues(gVQues, lblID.Text, lblCode.Text, cBType.Text, lblSet.Text,
                    lblNum, tBQues, tBAns, btnOk, tBCurAns);
                if (cBType.Text == "Multiple Choice")
                {
                    DbQ.dispChoice(gVChoice, lblCode.Text, lblSet.Text, lblNum.Text);
                    paneChoice.Visible = true;
                }
                else
                {
                    paneChoice.Visible = false;
                }
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void gVChoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVChoice.Rows.Count > 0)
            {
                tBAns.Text = gVChoice.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                msg.dataEmpty();
            }    
        }

        private void gVAns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVAns.Rows.Count > 0)
            {
                DbQ.editStudAns(gVAns, lblID.Text, lblCode.Text, lblSet.Text, cBType.Text,
                    lblNum, tBQues, tBAns, btnOk, tBCurAns);
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (gVQues.Rows.Count > 0 || cBType.Text != "")
            {
                DbQ.studAns(lblID.Text, lblCode.Text, lblSet.Text, cBType.Text,
                    lblNum, tBQues, tBAns, gVAns, btnOk, gVChoice, tBCurAns);
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (gVQues.Rows.Count > 0 || cBType.Text != "")
            {
                DbQ.nextQues(lblID.Text, lblCode.Text, lblSet.Text, cBType.Text,
                    lblNum, tBQues, tBAns, btnOk, gVChoice, tBCurAns);
            }
            else
            {
                msg.dataEmpty();
            }     
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (gVAns.Rows.Count > 0)
            {
                if (MessageBox.Show("Are your sure to submit your answers?, Remember you CAN'T GO BACK..., " +
                "Continue Anyway?", msg.ver, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    showScore();
                }
                else
                {
                    return;
                }
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void frmStud_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt || Control.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
            else
            {
                close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            misc.saveRes(lblID2.Text, paneMain);
            close();
        }

        private void tBAns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBType.Text == "Multiple Choice")
            {
                e.Handled = true;
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
