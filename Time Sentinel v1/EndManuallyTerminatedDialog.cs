using System;
using System.Windows.Forms;

// goodbye box after Time Sentinel has been manually terminated by an unblock event

namespace Time_Sentinel_v1
{
    public partial class EndManuallyTerminatedDialog : Form
    {
        public EndManuallyTerminatedDialog()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
