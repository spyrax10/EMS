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
            gBStud.Visible = false;
            btnSub.Text = "ADD";
        }
        public void showStud()
        {
            gBPro.Visible = false;
            gBStud.Visible = true;
            DbQ.loadStudents(frmMain.empId, cBSub, gVStud);        
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
            showStud();
        }

        private void cBSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadEmpStud(frmMain.empId, cBSub, gVStud);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            def();
        }
    }
}
