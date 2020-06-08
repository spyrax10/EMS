using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void home()
        {
            paneSlide.Height = btnEmp.Height;
            paneSlide.Top = btnEmp.Top;
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            lblEmpId.Text = frmMain.empId;
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
            Application.Exit();
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            if (misc.activeForm != null)
                misc.activeForm.Close();
            home();         
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmMain ma = new frmMain();
            ma.Visible = true;
            this.Visible = false;
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
            empId = lblEmpId.Text;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            empId = lblEmpId.Text;
            misc.opnChild(paneCont, new frmSet());
        }
    }
}
