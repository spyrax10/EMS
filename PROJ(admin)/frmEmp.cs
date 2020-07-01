using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmEmp : Form
    {
        public static string empId;
        public frmEmp()
        {
            InitializeComponent();
            home();
        }
        public void home()
        {
            paneSlide.Height = btnPro.Height;
            paneSlide.Top = btnPro.Top;
            if (misc.activeForm != null)
                misc.activeForm.Close();
        }
        private void frmEmp_Load(object sender, EventArgs e)
        {
            lblEmpId.Text = frmMain.empId;
        }

        private void btnShut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit?", msg.ver, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }          
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", msg.ver, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                DbQ.sysLog(frmMain.empId, msg.time, msg.date, msg.logOut);
                frmMain ma = new frmMain();
                ma.Visible = true;
                this.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                paneMenu.Width += 50;
                if (paneMenu.Width >= 200)
                {
                    timer1.Stop();
                }
            }
            else
            {
                paneMenu.Width -= 50;
                if (paneMenu.Width <= 0)
                {
                    paneMenu.Hide();
                    timer1.Stop();
                }
            }
        }
        bool isShow;
        private void pBHide_Click(object sender, EventArgs e)
        {
            if (paneMenu.Visible)
            {
                isShow = false;
                timer1.Start();
            }
            else
            {
                isShow = true;
                paneMenu.Show();
                timer1.Start();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnPro.Height;
            paneSlide.Top = btnPro.Top;
            misc.opnChild(paneCont, new frmSet());
        }

        private void frmEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbQ.sysLog(frmMain.empId, msg.time, msg.date, msg.appClose);
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            home();
        }

        private void pBHome_VisibleChanged(object sender, EventArgs e)
        {
            home();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnPro.Height;
            paneSlide.Top = btnPro.Top;
            misc.opnChild(paneCont, new frmPro());
        }

        private void btnQues_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnQues.Height;
            paneSlide.Top = btnQues.Top;
            misc.opnChild(paneCont, new frmQues());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnTest.Height;
            paneSlide.Top = btnTest.Top;
            misc.opnChild(paneCont, new examBio());
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnRec.Height;
            paneSlide.Top = btnRec.Top;
            misc.opnChild(paneCont, new frmRec());
        }
    }
}
