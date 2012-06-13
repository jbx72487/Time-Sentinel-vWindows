using System;
using System.Windows.Forms;

// error box that pops up if passwords don’t match

namespace Time_Sentinel_v1
{
    public partial class ErrorPswdMismatch : Form
    {
        public ErrorPswdMismatch()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
