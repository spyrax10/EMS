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
            gBInfo.Visible = true; 
            paneInfo.Visible = true;
            btnAdd.Image = Properties.Resources.List;
        }
        public void showDet()
        { 
            gBInfo.Visible = false;
            misc.defGV(gVList);
            gBDet.Visible = true;
            DbQ.loadStud(gVList);
            DbQ.loadStudSub(gVSub, tBID);
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
                DbQ.IDExits(tBID, paneCour);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (btnReg.Text == "REGISTER")
            {
                DbQ.studCreate(paneInfo, tBID.Text, tBDept.Text, tBCourse.Text, tBYear.Text, tBFirst.Text,
                tBMid.Text, tBLast.Text, cBCount.Text, cBPro.Text,
                cBMun.Text, cBBar.Text, tBPur.Text, tBMob.Text, tBEmail.Text);
                if (DbQ.isSucess == true)
                {
                    paneSub.Visible = true;
                    paneInfo.Visible = false;
                    DbQ.sysLog(frmAdm.empId, msg.time(), msg.date(), msg.addStud(tBID.Text));
                }
            }
            else
            {
                DbQ.updateStud(gVSub,paneInfo, tBID, tBDept, tBCourse, tBYear, tBFirst, tBMid, tBLast, 
                    tBMob, tBEmail, tBPur, cBCount, cBPro, cBMun, cBBar, paneCour, paneSub);
                btnSub.Text = "ADD";
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
    }
}
