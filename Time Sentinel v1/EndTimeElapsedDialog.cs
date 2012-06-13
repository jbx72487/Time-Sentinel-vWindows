using System;
using System.Windows.Forms;

// goodbye box after Time Sentinel has reached the user-set time period without any successful unblock events

namespace Time_Sentinel_v1
{
    public partial class EndTimeElapsedDialog : Form
    {
        public EndTimeElapsedDialog()
        {
            InitializeComponent();
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
