using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmPro : Form
    {
        public frmPro()
        {
            InitializeComponent();
        }
        public void def()
        {
            DbQ.loadProfile(frmMain.empId, lblProName, lblProID, lblProDept, pBImg);
            DbQ.loadEmpSub(gVSub, frmMain.empId);
            misc.clrCont(paneSub);
            gBPro.Visible = true;
            gBGrade.Visible = false;
            btnSub.Text = "ADD";
        }
        public void showGrade()
        {
            gBPro.Visible = false;
            gBGrade.Visible = true;
            btnGrade.Text = "ADD";
            cBRemarks.Text = "";
            tBGrade.Text = "";
            numPer.Value = 0;
            DbQ.loadGrade(gVGrade, frmMain.empId);        
        }

        private void frmPro_Load(object sender, EventArgs e)
        {
            def();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            DbQ.empSub(paneSub, gVSub, frmMain.empId, tBCode, tBName.Text, btnSub);
        }

        private void gVSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DbQ.empSubDet(gVSub, frmMain.empId, tBCode, tBName, btnSub);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            DbQ.empSubDrop(gVSub, frmMain.empId, btnSub, paneSub);
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            showGrade();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            def();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (cBRemarks.Text == "" || tBGrade.Text == "")
            {
                msg.incMsg();
            }
            else
            {
                DbQ.addGrade(frmMain.empId, numPer,tBGrade, cBRemarks, gVGrade, btnGrade);
            } 
        }

        private void gVGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVGrade.Rows.Count <= 0)
            {
                msg.dataEmpty();
            }
            else
            {
                DbQ.editGrade(frmMain.empId, numPer, tBGrade, cBRemarks, gVGrade, btnGrade);
            }
        }
    }
}
