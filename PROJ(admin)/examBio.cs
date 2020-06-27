using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class examBio : Form
    {
        public static string code;
        int min, second = 59, sec = 59;
        public examBio()
        {
            InitializeComponent();
        }
        public void def()
        {
            misc.clrCont(gBDet);
            numLimit.Value = 20;
            gVData.DataSource = null;
            cBCode.Text = "";
            btnStart.Enabled = false;
            numLimit.Enabled = true;
            cBCode.Focus();
        }
        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void examBio_Load(object sender, EventArgs e)
        {
            DbQ.loadQuesCode(cBCode, frmMain.empId);
        }

        private void cBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.dispQues2(gVData, frmMain.empId, cBCode, tBSub, tBPer);
            if (numLimit.Value != 0)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void numLimit_ValueChanged(object sender, EventArgs e)
        {
            if (misc.isEmptyFields(gBDet) == false && numLimit.Value != 0 && gVData.Rows.Count != 0)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (misc.isEmptyFields(gBDet) == false && gVData.Rows.Count != 0)
            {
                DbQ.addTestSet(frmMain.empId, cBCode, tBSub.Text, tBPer.Text, numLimit, 
                    btnStart, timer);
                min = Convert.ToInt32(numLimit.Value);
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            if (misc.isEmptyFields(gBDet) == false && gVData.Rows.Count != 0)
            {
                code = cBCode.Text;
                studLog s = new studLog();
                s.ShowDialog();
            }
            else
            {
                msg.dataEmpty();
            }  
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                min--;
                second = 59;
                DbQ.updTime(frmMain.empId, cBCode.Text, min.ToString());
            }
            if (min == 0)
            {
                sec--;
                if (sec == 0)
                {
                    timer.Stop();
                    DbQ.updTime(frmMain.empId, cBCode.Text, min.ToString());
                    MessageBox.Show("Exam ended!");
                    def();
                }
            }

            lblTime.Text = min.ToString();
        }
    }
}
