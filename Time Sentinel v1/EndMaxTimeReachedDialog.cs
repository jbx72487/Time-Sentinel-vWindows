using System;
using System.Windows.Forms;

// goodbye box after Time Sentinel has reached the internally-set maximum allowable restriction time

namespace Time_Sentinel_v1
{
    public partial class EndMaxTimeReachedDialog : Form
    {
        public EndMaxTimeReachedDialog()
        {
            InitializeComponent();
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
