using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class studBio : Form
    {
        public studBio()
        {
            InitializeComponent();
        }
        public void def()
        {
            pBImg.Image = Properties.Resources.download;
            lblEmail.Visible = false;
            tBID.Enabled = true;
            tBID.Focus();
            tBID.Text = "";
            misc.clrCont(paneCour);
            misc.clrCont(paneInfo);
            misc.clrCont(paneSub);
            btnReg.Text = "REGISTER";
            paneInfo.Enabled = false;
            paneCour.Enabled = false;
            paneSub.Visible = false;        
            gBDet.Visible = false;
            btnViewSub.Visible = false;
            gBInfo.Visible = true; 
            paneInfo.Visible = true;
            btnAdd.Image = Properties.Resources.List;
        }
        public void showSub()
        {
            paneInfo.Visible = false;
            paneCour.Enabled = false;
            btnSub.Text = "ADD";
            paneSub.Visible = true;
            DbQ.loadStudSub(gVSub, tBID);

        }
        public void showDet()
        { 
            gBInfo.Visible = false;
            gBDet.Visible = true;
            DbQ.loadStud(gVList);   
            btnAdd.Image = Properties.Resources.add_user_icon__1_;
        }
        private void studBio_Load(object sender, EventArgs e)
        {
            DbQ.loadCount(cBCount);
            showDet();
        }

        private void cBCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadPro(cBCount, cBPro);
        }

        private void cBPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadMun(cBCount, cBPro, cBMun);
        }

        private void cBMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadBar(cBCount, cBPro, cBMun, cBBar);
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (DbQ.IDExits(tBID) == false)
                {
                    tBID.Enabled = false;
                    paneCour.Enabled = true;
                }
                else
                {
                    msg.idUse();
                    paneCour.Enabled = false;
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (btnReg.Text == "REGISTER")
            {
                DbQ.studCreate(paneInfo, showSub, frmMain.empId, tBID.Text, tBDept.Text, tBCourse.Text, tBYear.Text, 
                    tBFirst.Text, tBMid.Text, tBLast.Text, 
                    cBCount.Text, cBPro.Text, cBMun.Text, cBBar.Text, tBPur.Text, tBMob.Text, tBEmail.Text);
            }
            else
            {
                DbQ.updateStud(frmMain.empId,paneInfo, tBID, tBDept, tBCourse, tBYear, tBFirst, tBMid, tBLast, 
                    tBMob, tBEmail, tBPur, cBCount, cBPro, cBMun, cBBar, btnViewSub);
            }
        }

        private void tBDept_Leave(object sender, EventArgs e)
        {
            misc.capFirst(sender);
        }

        private void tBDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.invChar(e);
        }

        private void tBYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.numOnly(e);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            def();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (tBCourse.Text != "" && tBDept.Text != "")
            {
                paneInfo.Enabled = true;
            }
            else
            {
                msg.incMsg();
                paneInfo.Enabled = false;
            }
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            if (btnReg.Text == "UPDATE")
            {
                DbQ.studImg(pBImg, tBID);
            }
            else
            {
                misc.selImg(pBImg);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gBInfo.Visible == true)
            {
                showDet();
            }
            else
            {
                def();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            def();
            paneInfo.Enabled = true;
            paneCour.Enabled = true;
            btnReg.Text = "UPDATE";
            DbQ.editStud(gVList, tBID, tBDept, tBCourse, tBYear, tBFirst, tBMid,
                tBLast, tBMob, tBEmail, tBPur, cBCount, cBPro,
                cBMun, cBBar, pBImg);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (btnSub.Text == "ADD")
            {
                DbQ.addStudSub(paneSub, gVSub, tBID, tBCode, tBName);
            }
            else
            {
                DbQ.updStudSub(paneSub, gVSub, tBID, tBCode, tBName, btnSub);
            }
        }

        private void gVSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DbQ.editStudSub(gVSub, tBCode, tBName, btnSub);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            showDet();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (gVSub.Rows.Count > 0)
            {
                DbQ.dropSub(gVSub, tBID);
                tBCode.Text = "";
                tBName.Text = ""; tBCode.Focus();
                btnSub.Text = "ADD";
            }
        }

        private void tBEmail_Leave(object sender, EventArgs e)
        {
            if (!misc.valEmail(tBEmail.Text))
            {
                lblEmail.Text = "Email Not Valid!";
                lblEmail.Visible = true;
                tBEmail.Focus();
            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        private void tBMob_Leave(object sender, EventArgs e)
        {
            if (!misc.numFormat(tBMob.Text))
            {
                lblEmail.Text = "Mobile Format Not Valid!";
                lblEmail.Visible = true;
                tBMob.Focus();
            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        private void btnViewSub_Click(object sender, EventArgs e)
        {
            showSub();
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            DbQ.srchStud(gVList, tbSearch.Text);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                DbQ.loadStud(gVList);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DbQ.print(gVList, msg.studList);
        }
    }
}
