using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmRec : Form
    {
        public frmRec()
        {
            InitializeComponent();
        }
        public void def()
        {
            gBScore.Visible = false;
            gBSum.Visible = true;
            DbQ.loadQuesCode(cBCode, frmMain.empId);
            DbQ.dispResult(gVData, frmMain.empId);
        }

        public void showAns()
        {
            gBSum.Visible = false;
            gBScore.Visible = true;
        }
        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRec_Load(object sender, EventArgs e)
        {
            def();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gVData.Rows.Count > 0)
            {
                DbQ.print(gVData, msg.testSum);
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void cBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.sortResult(gVData, frmMain.empId, cBCode.Text);
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            if (gVScore.Rows.Count > 0)
            {
                DbQ.print(gVScore, msg.score);
            }
            else
            {
                msg.dataEmpty();
            }
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            DbQ.ansBreak(gVData, gVScore, cBCode, showAns);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            def();
        }
    }
}
