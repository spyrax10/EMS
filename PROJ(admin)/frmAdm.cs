using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmAdm : Form
    {
        public static string empId;
        public frmAdm()
        {
            InitializeComponent();
            home();
            SqlConnection.ClearAllPools();
        }

        public void home()
        {
            paneSlide.Height = btnEmp.Height;
            paneSlide.Top = btnEmp.Top;
            if (misc.activeForm != null)
                misc.activeForm.Close();
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            lblEmpId.Text = frmMain.empId;
            home();
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

        private void pBHome_Click(object sender, EventArgs e)
        {
            home();         
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", msg.ver, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == 
                DialogResult.Yes)
            {
                DbQ.sysLog(frmMain.empId, msg.time, msg.date, msg.logOut);
                frmMain ma = new frmMain();
                ma.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnEmp.Height;
            paneSlide.Top = btnEmp.Top;
            misc.opnChild(paneCont, new empBio());
            empId = lblEmpId.Text;
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnStud.Height;
            paneSlide.Top = btnStud.Top;
            misc.opnChild(paneCont, new studBio());
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnEmp.Height;
            paneSlide.Top = btnEmp.Top;
            misc.opnChild(paneCont, new frmSet());
        }

        private void btnSys_Click(object sender, EventArgs e)
        {
            paneSlide.Height = btnSys.Height;
            paneSlide.Top = btnSys.Top;
            misc.opnChild(paneCont, new frmLog());
        }

        private void frmAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbQ.sysLog(frmMain.empId, msg.time, msg.date, msg.appClose);
        }

        private void frmAdm_VisibleChanged(object sender, EventArgs e)
        {
            home();
        }
    }
}
