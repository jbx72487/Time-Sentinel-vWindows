using System;
using System.Collections.Generic;
using System.Windows.Forms;

// main Settings dialog box where users choose all options

namespace Time_Sentinel_v1
{
    public partial class MainSettingsDialog : Form
    {
        public class AppArrayIndexer
        {
            /// <summary>
            /// indexer class for BlockedAppsIndexer property
            /// </summary>
            private MainSettingsDialog arrayOwner;

            public AppArrayIndexer(MainSettingsDialog arrayOwner)
            {
                this.arrayOwner = arrayOwner;
            }

            public string this[int index]
            {
                get { return arrayOwner.localAppsArray[index]; }
            }

            public int Length
            {
                get { return arrayOwner.localAppsArray.Length; }
            }
        }

        // create read only properties showing chosen options
        public bool PressedOkay
        {
            get { return _pressedOkay; }
        }

        public RestrictionLevel RestrictLevel
        {
            get { return _restrictLevel; }
        }

        public TimeLimit TimeLimit
        {
            get { return _timeLimit; }
        }

        public UnblockEvent UnblockEvent
        {
            get { return _unblockEvent; }
        }

        public UInt32 TimeLimMins
        {
            get { return _timeLimMins; }
        }

        public string Password
        {
            get { return _password; }
        }

        public AppArrayIndexer BlockedAppsIndexer
        {
            get { return _blockedAppsIndexer; }
        }

        public Dictionary<string, string> processNameDictionary;

        public MainSettingsDialog()
        {
            InitializeComponent();

            // create dictionary of application process names
            processNameDictionary = new Dictionary<string, string>();
            processNameDictionary.Add("Task Manager", "taskmgr");
            processNameDictionary.Add("AIM", "aim6");
            processNameDictionary.Add("Firefox", "firefox");
            processNameDictionary.Add("Google Chrome", "chrome");
            processNameDictionary.Add("Google Talk", "googletalk");
            processNameDictionary.Add("Internet Explorer", "iexplore");
            processNameDictionary.Add("Microsoft Outlook", "OUTLOOK");
            processNameDictionary.Add("MSN Messenger", "msmsgs");
            processNameDictionary.Add("Safari", "Safari");
            processNameDictionary.Add("Thunderbird", "thunderbird");

            // initialize PressedOkay to be false
            _pressedOkay = false;

            // instantiate settings variables
            _restrictLevel = new RestrictionLevel();
            _timeLimit = new TimeLimit();
            _unblockEvent = new UnblockEvent();

            // initialize timeLimMins, password, and the hacker settings to default values
            _timeLimMins = 0;
            _password = string.Empty;

            // instantiate a blockedApps List
            blockedApps = new List<string>();
        }

        private void levelApp_CheckedChanged(object sender, EventArgs e)
        {
            // enable selection of applications to block only if user selects the application restriction option
            if (levelAppsRadioButton.Checked == true)
                levelAppsPanel.Enabled = true;
            else
                levelAppsPanel.Enabled = false;
        }

        private void unblockPswd_CheckedChanged(object sender, EventArgs e)
        {
            // enable setting of a password only if user selects the unblock by password option
            if (unblockPswdRadioButton.Checked == true)
            {
                unblockPswdPanel.Enabled = true;
            }
            else
            {
                unblockPswdPanel.Enabled = false;
            }
        }

        private void limitEvent_CheckedChanged(object sender, EventArgs e)
        {
            // if user chooses to limit by unblock event, disable the "Never" unblock option in the "Advanced" tab
            if (limitEventRadioButton.Checked == true)
            {
                // if the Never option is currently selected, select the math instead
                if (unblockNeverRadioButton.Checked == true)
                    unblockMathRadioButton.Checked = true;
                // disable the never button
                unblockNeverRadioButton.Enabled = false;
            }
            else
            {
                unblockNeverRadioButton.Enabled = true;
            }
        }

        private void limitTime_CheckedChanged(object sender, EventArgs e)
        {
            // enable setting of a time limit only if user selects the restrict by time limit option
            if (limitTimeRadioButton.Checked == true)
            {
                limitTimePanel.Enabled = true;
            }
            else
            {
                limitTimePanel.Enabled = false;
            }
        }

        private void btnShowHacker_Click(object sender, EventArgs e)
        {
            // Declare the Hacker Options window
            HackerSettingsDialog hackerOptions;

            // instantiate the hackerOptions window
            hackerOptions = new HackerSettingsDialog();

            // Display the Hacker Options window modally
            hackerOptions.ShowDialog();

            // if option to block access to task manager is selected, add task manager to list of blocked processes
            if (hackerOptions.TaskMgr == HackerTaskMgr.BlockTaskMrg)
                blockedApps.Add(processNameDictionary["Task Manager"]);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            // event handler for Okay button
        
            // proceed only if there are no input errors

            // if inputted time is zero and want to set time limit, display error
            if (limitTimeRadioButton.Checked == true &&
                limitTimeHrsNumericUpDown.Value == 0 && limitTimeMinsNumericUpDown.Value == 0)
            {
                ErrorZeroTime errTime = new ErrorZeroTime();
                errTime.ShowDialog();
            }

            // if passwords do not match, display error
            else if (unblockPswdRadioButton.Checked == true &&
                     string.Compare(pswd1TextBox.Text.ToString(), pswd2TextBox.Text.ToString()) != 0)
            {
                ErrorPswdMismatch errPswd = new ErrorPswdMismatch();
                errPswd.ShowDialog();
            }

            // if want to limit applications but none are selected, display error
            else if (levelAppsRadioButton.Checked == true &&
                     aimCheckBox.Checked == false &&
                     chromeCheckBox.Checked == false &&
                     firefoxCheckBox.Checked == false &&
                     iexplorerCheckBox.Checked == false &&
                     msnCheckBox.Checked == false &&
                     gtalkCheckBox.Checked == false &&
                     outlookCheckBox.Checked == false &&
                     safariCheckBox.Checked == false &&
                     thunderbirdCheckBox.Checked == false)
            {
                ErrorZeroApplications errNoApps = new ErrorZeroApplications();
                errNoApps.ShowDialog();
            }

            else
            {
                // indicate that options were submitted
                _pressedOkay = true;

                // instantiate variables in which to store options
                _restrictLevel = new RestrictionLevel();
                _timeLimit = new TimeLimit();
                _unblockEvent = new UnblockEvent();

                // initialize timeLim and password to default values
                _timeLimMins = 0;
                _password = string.Empty;

                // get restriction level option from radio buttons, and add to blockedApps if relevant
                if (levelAppsRadioButton.Checked == true)
                {
                    _restrictLevel = RestrictionLevel.Applications;

                    // add applications one by one to blockedApps, according to check boxes
                    if (aimCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["AIM"]);
                    if (firefoxCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Firefox"]);
                    if (chromeCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Google Chrome"]);
                    if (gtalkCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Google Talk"]);
                    if (outlookCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Microsoft Outlook"]);
                    if (msnCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["MSN Messenger"]);
                    if (safariCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Safari"]);
                    if (thunderbirdCheckBox.Checked == true)
                        blockedApps.Add(processNameDictionary["Thunderbird"]);
                }

                // get time limit option from radio buttons, and set timeLim if relevant
                if (limitTimeRadioButton.Checked == true)
                {
                    _timeLimit = TimeLimit.Time;
                    _timeLimMins = (uint) (limitTimeHrsNumericUpDown.Value * 60 + limitTimeMinsNumericUpDown.Value);
                }
                else if (limitEventRadioButton.Checked == true)
                {
                    _timeLimit = TimeLimit.Event;
                }

                // get unblock event option from radio buttons, and set password if relevant
                if (unblockBtnRadioButton.Checked == true)
                {
                    _unblockEvent = UnblockEvent.Button;
                }
                else if (unblockMathRadioButton.Checked == true)
                {
                    _unblockEvent = UnblockEvent.Math;
                }
                else if (unblockPswdRadioButton.Checked == true)
                {
                    _unblockEvent = UnblockEvent.Password;
                    _password = pswd1TextBox.Text.ToString();
                }
                else if (unblockNeverRadioButton.Checked == true)
                {
                    _unblockEvent = UnblockEvent.Never;
                }

                // copy blockedApps List to an AppArrayIndexer
                localAppsArray = new string[blockedApps.Count];
                blockedApps.CopyTo(localAppsArray);
                _blockedAppsIndexer = new AppArrayIndexer(this);

                Hide();
            }
        }

        // cancel out
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool _pressedOkay;
        private RestrictionLevel _restrictLevel;
        private TimeLimit _timeLimit;
        private UnblockEvent _unblockEvent;
        private UInt32 _timeLimMins;
        private string _password;

        // private members used to maintain the blocked applications indexer property
        private string[] localAppsArray;
        private AppArrayIndexer _blockedAppsIndexer;
        // List of blocked applications
        private List<string> blockedApps; 


    }
}