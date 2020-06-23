using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class examBio : Form
    {
        public static string code;
        public examBio()
        {
            InitializeComponent();
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
                DbQ.addTestSet(frmMain.empId, cBCode, tBSub.Text, tBPer.Text, numLimit, btnStart);
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
    }
}
