using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

// background thread which blocks specified applications and interfaces with the main thread via progress updates and other events/handlers

namespace Time_Sentinel_v1
{
    public partial class ActiveTimer : Form
    {
        // public members
        // ArgumentsObject contains necessary information for blocking application
        public ArgumentsObject timerArgs;
        // defining the ArgumentsObject class
        
        public class ArgumentsObject
        {
            public UInt32 TimeMins { get; set; }
            public string[] Applications { get; set; }
        }
        
        // constructor takes in time in minutes and an array of applications to block
        public ActiveTimer(UInt32 timeMins, string[] applications)
        {
            InitializeComponent();
            
            // copy arguments into timerArgs property
            timerArgs = new ArgumentsObject();
            timerArgs.TimeMins = timeMins;
            timerArgs.Applications = new string[applications.Length];
            applications.CopyTo(timerArgs.Applications, 0);

            // instantiate and set up background worker
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true; // enable reporting of progress
            backgroundWorker.WorkerSupportsCancellation = true; // enable cancellation of bkgd process
            // attach event handlers to regular function, progress update, and post-completion tasks
            backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
            // allow for updating of time countdown window only if time limit was set by the user
            if (timeMins < SentinelExecute.maxTime)
            {
                backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            }
            else
            {
                questionLabel.Text = "Time Sentinel";
                timeLabel.Text = "Restrictions in Effect";
            }
            backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

            // start running the background process
            backgroundWorker.RunWorkerAsync(timerArgs);
        }

        // method to hide the dialog box from view
        public void HideFromView()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }
        
        // method to show the dialog box
        public void ShowDialogBox()
        {
            Show();
            ShowInTaskbar = true; 
            WindowState = FormWindowState.Normal;

        }

        // method to stop, or cancel, the background processes
        public void StopBkgd()
        {
            backgroundWorker.CancelAsync();
        }

        // define backgroundWorker's tasks that are running in a separate stream from the main one
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Process[] applications;
            UInt32 cumulativeTimeSecs = 0;
            double percentage;
            uint secsRemaining;

            // report back that 0% has been completed and have timerArgs.Time minutes left
            backgroundWorker.ReportProgress(0, timerArgs.TimeMins * 60);

            // progress toward the time limit second by second
            for (UInt32 i = 0; i < timerArgs.TimeMins * 60; i++)
            {
                // cancel if request to stop backgroundWorker was made, otherwise proceed
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    // sleep for 1 second
                    Thread.Sleep(1000);
                    cumulativeTimeSecs += 1;

                    // block processes
                    for (int j = 0; j < timerArgs.Applications.Length; j++)
                    {
                        applications = Process.GetProcessesByName(timerArgs.Applications[j]);
                        foreach (Process app in applications)
                        {
                            // kill the process
                            app.Kill();
                            // some processes (ex. task manager) won't close with Kill(), so Close() must be used as well
                            app.Close();
                        }
                    }

                    // calculate percentage completed and time remaining
                    percentage = ((double)cumulativeTimeSecs / (double)(timerArgs.TimeMins * 60)) * 100;
                    secsRemaining = timerArgs.TimeMins * 60 - cumulativeTimeSecs;

                    // report progress
                    backgroundWorker.ReportProgress((int)Math.Round(percentage, 0, MidpointRounding.AwayFromZero), secsRemaining);
                }
            }
        }

        // define actions for when progress is reported
        public void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UInt32 secsRemaining = (UInt32)e.UserState;
            int hrsRemaining = (int)Math.Floor((double)secsRemaining / (60 * 60));
            secsRemaining = secsRemaining - (UInt32)hrsRemaining * 60 * 60;
            int minsRemaining = (int)Math.Floor((double)secsRemaining / 60);
            secsRemaining = secsRemaining - (UInt32)minsRemaining * 60;

            string remainingTime = "";
            if (hrsRemaining > 0)
                remainingTime = String.Concat(remainingTime, hrsRemaining, " hours, ");
            if (!(hrsRemaining == 0 && minsRemaining == 0))
                remainingTime = String.Concat(remainingTime, minsRemaining, " minutes, ");
            remainingTime = String.Concat(remainingTime, secsRemaining, " seconds.");
            timeLabel.Text = remainingTime;
        }

        // define actions for when backgroundWorker finishes
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // if worker was not canceled, fire the actions associated with completion
            if (e.Cancelled == false)
            {
                if (timerArgs.TimeMins == SentinelExecute.maxTime)
                {
                    // if maximum time was elapsed without user ending restrictions, exit accordingly
                    Close();
                    SentinelExecute.Exit(EndReason.MaxTimeReached);
                }
                else
                {
                    // otherwise the user-set time elapsed, so also exit accordingly
                    Close();
                    SentinelExecute.Exit(EndReason.TimeElapsed);
                }
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            // to keep the timer background process going without displaying the time countdown, hide the box from view
            HideFromView();
        }

        // private members
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

