using System;
using System.Windows.Forms;

// dialog box used in the unblock event where user must enter the correct password (set in Settings box)

namespace Time_Sentinel_v1
{
    public partial class UnblockPswdDialog : Form
    {
        // property indicating whether termination attempt was successful
        public bool TerminateSuccess { get; set; }

        // constructor with password passed in as argument
        public UnblockPswdDialog(string password)
        {
            InitializeComponent();
            truePswd = string.Copy(password);
            TerminateSuccess = false;
        }

        // checks an inputted password to see if it matches the real one
        public bool PasswordMatch(string inputPswd)
        {
            return (string.Compare(inputPswd, truePswd) == 0) ? true : false;
        }

        // Cancel indicates failed attempt to lift restrictions
        private void cancelButton_Click(object sender, EventArgs e)
        {
            TerminateSuccess = false;
        }

        // if password is correct upon pressing Okay, program terminated successfully
        private void okayButton_Click(object sender, EventArgs e)
        {
            if (PasswordMatch(pswdTextBox.Text.ToString()))
            {
                incorrectLabel.Visible = false;
                TerminateSuccess = true;
                Close();
            }
            else
            {
                // otherwise, show red "incorrect" label
                incorrectLabel.Visible = true;
            }
        }

        // private members
        private string truePswd;

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
