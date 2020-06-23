using System;
using System.Windows.Forms;
using classLib;

namespace PROJ_admin_
{
    public partial class studLog : Form
    {
        public studLog()
        {
            InitializeComponent();
        }

        private void studLog_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DbQ.loadStudLog(gVData, examBio.code);
        }

        private void studLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
