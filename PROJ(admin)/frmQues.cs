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
            paneQues.Visible = false;
            paneCho.Visible = false;
            gBDet.Enabled = false;
            cBSub.Enabled = true;
            cBPer.Enabled = true;
            lblErr.Visible = false;
            tBCode.Enabled = true;
            tBCode.Focus();
            btnCho.Visible = false;
            btnOk.Text = "ADD";
            btnAddCho.Text = "ADD";
        }
        public void showQues()
        {
            lblType.Text = cBType.Text.ToUpper();
            paneQues.Visible = true;
            paneQues.BringToFront();
            cBSub.Enabled = false;
            cBPer.Enabled = false;
            lblErr.Visible = false;
            tBQues.Text = "";
            tBAns.Text = "";
            tBQues.Focus();
            btnNum.Value = 1;
            DbQ.loadQues(gVData, frmMain.empId, tBCode.Text,
                         cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
        }
        public void showCho()
        {
            paneCho.Visible = true;
            paneCho.BringToFront();
            tBCho.Text = "";
            paneCho.Focus();
            btnAddCho.Text = "ADD";
            DbQ.loadCho(gVData, frmMain.empId, tBCode.Text,
                    cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
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
                if (cBType.Text == "Multiple Choice")
                {
                    btnCho.Visible = true;
                }
                else
                {
                    btnCho.Visible = false;
                    paneCho.Visible = false;
                }
                showQues();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            DbQ.addQues(paneQues, gVData, frmMain.empId, tBCode.Text,
                                cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text,
                                btnNum, tBQues, tBAns, lblType, btnOk);
        }

        private void btnCho_Click(object sender, EventArgs e)
        {
            if (gVData.Rows.Count <= 0)
            {
                msg.dataEmpty();
            }
            else
            {
                showCho();
            }
        }

        private void btnDropIden_Click(object sender, EventArgs e)
        {
            DbQ.delQues(gVData, frmMain.empId, tBCode.Text, 
                cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text, tBQues, tBAns, btnOk);
        }

        private void gVData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVData.Rows.Count <= 0)
            {
                msg.dataEmpty();
            }
            else
            {
                DbQ.editQues(paneCho, gVData, frmMain.empId, tBCode.Text, cBSub.Text, cBPer.Text,
                     tBSet.Text, cBType.Text, btnNum, tBQues, tBAns, btnOk, tBCho, btnAddCho);
            }
        }

        private void btnNum_ValueChanged(object sender, EventArgs e)
        {
            tBQues.Text = ""; tBAns.Text = ""; tBQues.Focus();
            paneCho.Visible = false; tBCho.Text = ""; btnAddCho.Text = "ADD";
        }

        private void btnChoX_Click(object sender, EventArgs e)
        {
            paneCho.Visible = false;
            DbQ.loadQues(gVData, frmMain.empId, tBCode.Text,
                        cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            showCho();
        }

        private void btnAddCho_Click(object sender, EventArgs e)
        {
            DbQ.addChoQues(paneQues, gVData, frmMain.empId, tBCode.Text,
                                cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text,
                                btnNum, tBQues, tBCho, btnAddCho);
        }
    }
}
