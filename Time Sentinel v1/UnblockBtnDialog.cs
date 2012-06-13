using System;
using System.Windows.Forms;

// dialog box used in the unblock event where user must click through a series of confirmation boxes

namespace Time_Sentinel_v1
{
    public partial class UnblockBtnDialog : Form
    {
        // property indicating whether termination attempt was successful
        public bool TerminateSuccess { get; set; }

        // constructor
        public UnblockBtnDialog()
        {
            InitializeComponent();
            TerminateSuccess = false;
        }

        // if Okay button is pressed, this box (out of a potential series) terminated in success
        private void okayButton_Click(object sender, EventArgs e)
        {
            TerminateSuccess = true;
            Close();
        }

        // otherwise TerminateSuccess remains as false
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
