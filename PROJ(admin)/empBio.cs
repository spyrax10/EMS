using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class empBio : Form
    {
        public empBio()
        {
            InitializeComponent();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void paneRef()
        {
            tBID.Text = "";
            lblEmail.Visible = false;
            tBID.Enabled = true;
            btnReg.Text = "REGISTER";
            pBImg.Image = Properties.Resources.download;
            paneInfo.Enabled = false;
            misc.clrCont(gBInfo);
            tBID.Focus();
        }
        public void showInfo()
        {
            paneRef();
            gBDet.Visible = false;
            gBInfo.Visible = true;
            btnReg.Text = "REGISTER";
            btnAdd.Image = Properties.Resources.List;
        }
        public void showDet()
        {        
            gBInfo.Visible = false;
            gBDet.Visible = true;
            DbQ.loadEmp(gVList);
            btnAdd.Image = Properties.Resources.add_user_icon__1_;
        }
        private void empBio_Load(object sender, EventArgs e)
        {
            DbQ.loadCount(cBCount);
            showDet();
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            if (btnReg.Text == "UPDATE")
            {
                DbQ.updateImg(pBImg, tBID);
            }
            else
            {
                misc.selImg(pBImg);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (btnReg.Text == "REGISTER")
            {
                DbQ.empCreate(frmMain.empId, paneInfo, tBID.Text, tBDept.Text, tBFirst.Text,
                tBMid.Text, tBLast.Text, cBCount.Text, cBPro.Text,
                cBMun.Text, cBBar.Text, tBPur.Text, tBMob.Text,
                tBEmail.Text, showDet);
            }
            else
            {
                DbQ.updateEmp(paneInfo, frmMain.empId, tBID, tBDept, tBFirst, tBMid,
                tBLast, tBMob, tBEmail, tBPur, cBCount, cBPro,
                cBMun, cBBar, showDet);
            }
        }

        private void cBPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadMun(cBCount, cBPro, cBMun);
        }

        private void cBCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadPro(cBCount, cBPro);
        }

        private void cBMun_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbQ.loadBar(cBCount, cBPro, cBMun, cBBar);
        }

        private void tBDept_Leave(object sender, EventArgs e)
        {
            misc.capFirst(sender);
        }

        private void tBEmail_Leave(object sender, EventArgs e)
        {
            if (!misc.valEmail(tBEmail.Text))
            {
                lblEmail.Visible = true;
                tBEmail.Focus();
            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        private void tBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DbQ.IDExits(tBID, paneInfo);
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            paneRef();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gBInfo.Visible == true)
            {
                showDet();
            }
            else
            {
                showInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showInfo();
            paneInfo.Enabled = true;
            btnReg.Text = "UPDATE";
            DbQ.editEmp(gVList, tBID, tBDept, tBFirst, tBMid,
                tBLast, tBMob, tBEmail, tBPur, cBCount, cBPro,
                cBMun, cBBar, pBImg);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                DbQ.loadEmp(gVList);
            }
        }

        private void tBDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.invChar(e);
        }

        private void tBMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            misc.numOnly(e);
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

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            DbQ.srchEmp(gVList, tbSearch.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gVList.Rows.Count > 0)
            {
                DbQ.print(gVList, msg.empList);
            }
            else
            {
                msg.dataEmpty();
            }
        }
    }
}
