using System;
using System.Windows.Forms;

// main backbone of program that executes code according to settings

namespace Time_Sentinel_v1
{
    public class SentinelExecute
    {
        // set maximum possible time for restrictions (even if user does not lift restrictions) to be 12 hours
        public const UInt32 maxTime = 12 * 60;

        // set number of dialog verification boxes to click through before lifting restrictions (for the end restrictions by clicking buttons option)
        public const int numVerificationDialogs = 20;

        public SentinelExecute(RestrictionLevel setRestrictionLevel, TimeLimit setTimeLimit, UnblockEvent setUnblockEvent, UInt32 setTimeLimMins, string setPassword, MainSettingsDialog.AppArrayIndexer setBlockedApps)
        {
            // set all property values according to inputs
            restrictionLevel = setRestrictionLevel;
            timeLimit = setTimeLimit;
            unblockEvent = setUnblockEvent;
            timeLimitMins = (timeLimit == TimeLimit.Time) ? setTimeLimMins : maxTime; // if no time limit given, automatically set to maximum time
            password = setPassword;
            blockedApps = new string[setBlockedApps.Length]; // copy setBlockedApps to member array blockedApps
            for (int i = 0; i < setBlockedApps.Length; i++)
                blockedApps[i] = setBlockedApps[i];

            // set up system tray icon and its context menu
            SetupSysTray(timeLimit, unblockEvent);

            // instantiate and start the timer
            activeTimer = new ActiveTimer(timeLimitMins, blockedApps);
            activeTimer.ShowDialog();
                        
        }

        /*
        // shows settings one by one in a MessageBox. For debugging purposes only
        public void ShowSettings()
        {
            MessageBox.Show(string.Concat("Time Limit Option: ", timeLimit.ToString()));
            MessageBox.Show(string.Concat("Time Limit (in minutes): ", timeLimitMins.ToString()));
            MessageBox.Show(string.Concat("Unblock Event Option: ", unblockEvent.ToString()));
            MessageBox.Show(string.Concat("Password: ", password.ToString()));
            MessageBox.Show(string.Concat("Restriction Level Option: ", restrictionLevel.ToString()));
            foreach (string app in blockedApps)
                MessageBox.Show(string.Concat("Blocked application: ", app));
        }*/

        // set up system tray icon and its context menu
        private void SetupSysTray(TimeLimit timeLimit, UnblockEvent unblockEvent)
        {
            // instantiate and set up system tray icon (icon courtesy of http://www.rw-designer.com/)
            sysTrayIcon = new System.Windows.Forms.NotifyIcon();
            sysTrayIcon.Text = "Time Sentinel";
            sysTrayIcon.Icon = Time_Sentinel_v1.Properties.Resources.AlarmClock;
            sysTrayIcon.Visible = true;

            // instantiate and set up context menu items (with appropriate event handlers hooked up)

            // "About Time Sentinel" option
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            aboutToolStripMenuItem.Text = "About Time Sentinel";
            aboutToolStripMenuItem.Click += new System.EventHandler(aboutToolStripMenuItem_Click);

            // This option was originally intended to be in the program but was later removed, possibly to be implemented at a later time
            /*
            // "Check Remaining Time" option
            checkTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkTimeToolStripMenuItem.Name = "checkTimeToolStripMenuItem";
            checkTimeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            checkTimeToolStripMenuItem.Text = "Check Remaining Time";
            checkTimeToolStripMenuItem.Click += new System.EventHandler(checkTimeToolStripMenuItem_Click);
            // if time limit option is set of unblock by event, disable this option
            if (timeLimit == TimeLimit.Event)
                checkTimeToolStripMenuItem.Enabled = false;
             */

            // "Lift Restrictions" option
            terminateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            terminateToolStripMenuItem.Name = "terminateToolStripMenuItem";
            terminateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            terminateToolStripMenuItem.Text = "Lift Restrictions";
            terminateToolStripMenuItem.Click += new System.EventHandler(terminateToolStripMenuItem_Click);
            // if unblockEvent option is never, disable this option
            if (unblockEvent == UnblockEvent.Never)
                terminateToolStripMenuItem.Enabled = false;

            // create context menu and link to system tray icon
            trayContext = new System.Windows.Forms.ContextMenuStrip();
            sysTrayIcon.ContextMenuStrip = trayContext;
            trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{
                terminateToolStripMenuItem,
                aboutToolStripMenuItem});
            trayContext.Name = "trayContext";
            trayContext.Size = new System.Drawing.Size(182, 70);

            // double clicking on sysTrayIcon leads to check time
            // sysTrayIcon.DoubleClick += new System.EventHandler(checkTimeToolStripMenuItem_Click);
        }

        // show appropriate final goodbye message, depending on reason for ending
        public static void Exit(EndReason endReason)
        {
            switch (endReason)
            {
                case EndReason.TimeElapsed:
                    EndTimeElapsedDialog timeElapsed = new EndTimeElapsedDialog();
                    timeElapsed.ShowDialog();
                    break;
                case EndReason.ManuallyTerminated:
                    EndManuallyTerminatedDialog manuallyTerminated = new EndManuallyTerminatedDialog();
                    manuallyTerminated.ShowDialog();
                    break;
                case EndReason.MaxTimeReached:
                    EndMaxTimeReachedDialog maxTimeReached = new EndMaxTimeReachedDialog();
                    maxTimeReached.ShowDialog();
                    break;
            }
        }
         

        // open "About Time Sentinel" dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }

        /*
        // check remaining time by displaying the dialog box
        private void checkTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTimer.ShowDialogBox();
        }
         */

        // attempt to terminate time sentinel according to settings
        private void terminateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool terminateSuccess = false;

            // show different dialog boxes, depending on the unblock event option
            switch (unblockEvent)
            {
                case UnblockEvent.Button:
                    terminateSuccess = unblockButtonsAttempt();
                    break;
                case UnblockEvent.Math:
                    terminateSuccess = unblockMathAttempt();
                    break;
                case UnblockEvent.Password:
                    terminateSuccess = unblockPswdAttempt();
                    break;
            }

            // if unblocking criteria were successfully met, stop background worker and exit
            if (terminateSuccess == true)
            {
                activeTimer.StopBkgd();
                activeTimer.Close();
                Exit(EndReason.ManuallyTerminated);
            }
        }

        // attempt to terminate by clicking a series of buttons
        private bool unblockButtonsAttempt()
        {
            int i = 0;
            bool continueAttempt = true;

            while (i < numVerificationDialogs && continueAttempt == true)
            {
                UnblockBtnDialog unblockAttempt = new UnblockBtnDialog();
                unblockAttempt.ShowDialog();
                continueAttempt = unblockAttempt.TerminateSuccess;
                i++;
            }
            return (i == numVerificationDialogs) ? true : false;
        }

        // attempt to terminate by doing math problems
        private bool unblockMathAttempt()
        {
            UnblockMathDialog unblockAttempt = new UnblockMathDialog();
            unblockAttempt.ShowDialog();
            return unblockAttempt.TerminateSuccess;
        }

        // attempt to terminate by entering the correct password
        private bool unblockPswdAttempt()
        {
            UnblockPswdDialog unblockAttempt = new UnblockPswdDialog(password);
            unblockAttempt.ShowDialog();
            return unblockAttempt.TerminateSuccess;
        }

        // private members
        private RestrictionLevel restrictionLevel;
        private TimeLimit timeLimit;
        private UnblockEvent unblockEvent;
        private UInt32 timeLimitMins;
        private string password;
        private string[] blockedApps;
        private ActiveTimer activeTimer;
        private System.Windows.Forms.NotifyIcon sysTrayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContext;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem checkTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateToolStripMenuItem;

    }
}