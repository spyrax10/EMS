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
            DbQ.loadSub(frmMain.empId, cBSub2);
            DbQ.loadQuesCode(cBCode, frmMain.empId);
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
            btnCho.Visible = false;
            btnOk.Text = "ADD";
            btnAddCho.Text = "ADD";
            btnSet.Text = "STUDENT TEST SET";
            btnAdd.Visible = false;
            gBSet.Visible = false;
            gBQues.Visible = true;
            btnAdd.Visible = false;
            gVSet.DataSource = null;
            cBCode2.Text = "";
            tBCode.Focus();
        }
        public void showQues()
        {
            lblType.Text = cBType.Text.ToUpper();
            paneIns.Visible = false;
            cBSub.Enabled = false;
            cBPer.Enabled = false;
            lblErr.Visible = false;
            tBQues.Text = "";
            tBAns.Text = "";
            tBQues.Focus();
            btnNum.Value = 1;
            paneQues.Visible = true;
            DbQ.loadQues(gVData, frmMain.empId, tBCode.Text,
                        cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
        }
        public void showCho()
        {
            tBCho.Text = "";
            paneCho.Focus();
            btnAddCho.Text = "ADD";
            DbQ.loadCho(gVData, frmMain.empId, tBCode.Text, tBSet.Text, btnNum);
            paneCho.Visible = true;
            paneCho.BringToFront();
        }
        public void Ref()
        {
            tBQues.Text = "";
            tBAns.Text = "";
            tBQues.Focus();
            paneCho.Visible = false;
            tBCho.Text = "";
            btnAddCho.Text = "ADD";
            btnOk.Text = "ADD";
            DbQ.loadQues(gVData, frmMain.empId, tBCode.Text,
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
            if (gVData.Rows.Count <= 0 || misc.isEmptyFields(paneQues) == true)
            {
                msg.dataEmpty();
            }
            else
            {
                DbQ.addChoDef(frmMain.empId, tBCode.Text, tBSet.Text, btnNum, tBQues, tBAns);
                showCho();
            }
        }

        private void btnDropIden_Click(object sender, EventArgs e)
        {
            if (gVData.Rows.Count > 0)
            {
                DbQ.delQues(gVData, frmMain.empId, tBCode.Text,
                     cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text, tBQues, tBAns, btnOk,
                     btnAddCho, tBCho, btnNum);
            }
            else
            {
                msg.dataEmpty();
            }
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
                
                if (cBType.Text == "Enumeration")
                {
                    btnAdd.Visible = true;
                }
                else
                {
                    btnAdd.Visible = false;
                }
            }
        }

        private void btnNum_ValueChanged(object sender, EventArgs e)
        {
            Ref();
        }

        private void btnChoX_Click(object sender, EventArgs e)
        {
            paneCho.Visible = false;
            DbQ.loadQues(gVData, frmMain.empId, tBCode.Text,
                        cBSub.Text, cBPer.Text, tBSet.Text, cBType.Text);
        }
        private void btnAddCho_Click(object sender, EventArgs e)
        {
            DbQ.addChoQues(paneQues, gVData, frmMain.empId, tBCode.Text,
                            tBSet.Text, btnNum, tBQues, tBCho, btnAddCho);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tBQues.Text != "")
            {
                tBAns.Text = ""; tBAns.Focus(); btnOk.Text = "ADD";
            }
            else
            {
                msg.incMsg();
            }
        }
        private void cBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.dispQues(gBDet, cBCode, frmMain.empId, tBCode, cBSub, cBPer, tBSet);
            cBType.Text = "";
            paneIns.Visible = true;
            paneIns.BringToFront();
        }

        private void tBSet_TextChanged(object sender, EventArgs e)
        {
            cBType.Text = "";
            paneIns.Visible = true;
            paneIns.BringToFront();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Ref();
            btnNum.Value = 1;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (btnSet.Text == "STUDENT TEST SET")
            {
                btnSet.Text = "QUESTIONAIRE";
                cBSet.Text = "";
                cBSub2.Text = "";
                gBSet.Visible = true;
                DbQ.loadStudents(frmMain.empId, gVStud);
                gBQues.Visible = false;

            }
            else
            {
                def();
            }       
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            def();
        }

        private void cBSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBSub2.Text != "")
            {
                DbQ.loadSet2(cBSet, frmMain.empId, cBSub2.Text, cBCode2);
                DbQ.loadEmpStud(frmMain.empId, cBSub2, gVStud);
                gVSet.DataSource = null;
            }
        }

        private void cBCode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBCode2.Text != "")
            {           
                DbQ.loadStudSet(gVSet, frmMain.empId, cBSub2.Text, cBCode2.Text);
            }
        }

        private void cBSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBSet.Text != "")
            {
                DbQ.insStudSet(gVStud, cBCode2.Text, frmMain.empId, 
                    cBSub2.Text, cBSet, gVSet);
            }
        }

        private void gVStud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cBSet.Text = "";
        }

        private void btnDelSet_Click(object sender, EventArgs e)
        {
            if (gVSet.Rows.Count <= 0)
            {
                msg.dataEmpty();
            }
            else
            {
                DbQ.delStudSet(gVSet, cBCode2.Text, cBSub2.Text, frmMain.empId);
            }
        }
    }
}
