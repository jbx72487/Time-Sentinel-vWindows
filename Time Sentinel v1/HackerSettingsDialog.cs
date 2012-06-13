using System;
using System.Windows.Forms;

// Hacker settings box that can be opened from advanced settings

namespace Time_Sentinel_v1
{
    public partial class HackerSettingsDialog : Form
    {
        public HackerTaskMgr TaskMgr {get; set;}

        public HackerSettingsDialog()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            // get the StartUp property according to whether the block task manager option is checked
            if (hackerBlockTskMgr.Checked == true)
                TaskMgr = HackerTaskMgr.BlockTaskMrg;
            else
                TaskMgr = HackerTaskMgr.NoBlockTaskMgr;

            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // uncheck both options
            hackerBlockTskMgr.Checked = false;
        }

    }
}
