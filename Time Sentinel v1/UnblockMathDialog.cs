using System;
using System.Windows.Forms;

// dialog box used in the unblock event where user must complete 5 math problems

namespace Time_Sentinel_v1
{
    public partial class UnblockMathDialog : Form
    {
        // property indicating whether termination attempt was successful
        public bool TerminateSuccess { get; set; }

        // constant representing number of math problems to give
        public const int numMathProbs = 5;

        // constructor
        public UnblockMathDialog()
        {
            InitializeComponent();
            randNum = new Random();
            a = randomNbr();
            b = randomNbr();
            questionLabel.Text = string.Concat("What is ", a, " * ", b, "?");
            questionNumberLabel.Text = string.Concat("Problem 1 of ", numMathProbs);
            TerminateSuccess = false;
            numberCompleted = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            // if correct, then increment the number of problems solved correctly and check for termination success
            if (Convert.ToUInt32(answerTextBox.Text) == a * b)
            {
                numberCompleted++;
                incorrectLabel.Visible = false;
                if (numMathProbs == numberCompleted)
                {
                    // if requisite number of problems have been completed, note success in TerminateSuccess and exit
                    TerminateSuccess = true;
                    Close();
                }
                else
                {
                    // otherwise go to next problem
                    a = randomNbr();
                    b = randomNbr();
                    questionLabel.Text = string.Concat("What is ", a, " * ", b, "?");
                    questionNumberLabel.Text = string.Concat("Problem ", numberCompleted+1, " of ", numMathProbs);
                }
                answerTextBox.Text = "";
            }
            // if not correct, display "incorrect" label
            else
            {
                incorrectLabel.Visible = true;
                answerTextBox.Text = "";
            }
        }

        private UInt32 randomNbr()
        {
            return (UInt32) randNum.Next(10, 100);
        }

        private int numberCompleted;
        private uint a, b;
        private Random randNum;
    }
}
