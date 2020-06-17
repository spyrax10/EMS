using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            DbQ.loadSysLog(gVList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DbQ.clrSysLog(gVList, frmMain.empId);
        }

        private void dT_ValueChanged(object sender, EventArgs e)
        {
            DbQ.sortSysLog(gVList, dT.Value.ToShortDateString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DbQ.print(gVList, msg.sysLog);
        }
    }
}
