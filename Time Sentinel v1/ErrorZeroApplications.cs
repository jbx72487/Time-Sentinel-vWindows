using System;
using System.Windows.Forms;

// error box that pops up if no applications are selected

namespace Time_Sentinel_v1
{
    public partial class ErrorZeroApplications : Form
    {
        public ErrorZeroApplications()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
