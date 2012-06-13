using System;
using System.Windows.Forms;

// error message that pops up if 0 hours, 0 minutes are selected

namespace Time_Sentinel_v1
{
    public partial class ErrorZeroTime : Form
    {
        public ErrorZeroTime()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
