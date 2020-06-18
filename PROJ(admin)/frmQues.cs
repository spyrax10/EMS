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
            gBDet.Enabled = false;
            cBSub.Enabled = true;
            cBPer.Enabled = true;
            lblErr.Visible = false;
            tBCode.Enabled = true;
            tBCode.Focus();
            btnCho.Visible = false;
            btnAdd.Visible = false;
            btnOk.Text = "ADD";
        }
        public void showQues()
        {
            lblType.Text = cBType.Text.ToUpper();
            paneQues.Visible = true;
            paneQues.BringToFront();
            cBSub.Enabled = false;
            cBPer.Enabled = false;
            lblErr.Visible = false;
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
                else if (cBType.Text == "Enumeration")
                {
                    btnAdd.Visible = true;
                }
                else
                {
                    btnCho.Visible = false;
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
                btnNum, tBQues, tBAns.Text, lblType, btnOk);
        }

        private void btnCho_Click(object sender, EventArgs e)
        {
            btnNum.Value += 1;
        }

        private void btnDropIden_Click(object sender, EventArgs e)
        {
            DbQ.delQues(gVData, frmMain.empId, tBCode.Text, 
                cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
        }

        private void gVData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gVData.Rows.Count <= 0)
            {
                msg.dataEmpty();
            }
            else
            {
                btnNum.Value = Convert.ToInt32(gVData.CurrentRow.Cells[0].Value.ToString());
                tBQues.Text = gVData.CurrentRow.Cells[1].Value.ToString();
                tBAns.Text = gVData.CurrentRow.Cells[2].Value.ToString();
                btnOk.Text = "UPDATE";
            }
        }
    }
}
