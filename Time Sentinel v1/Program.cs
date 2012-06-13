using System;
using System.Windows.Forms;


namespace Time_Sentinel_v1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            MainSettingsDialog mainSettings = new MainSettingsDialog();
            mainSettings.ShowDialog();
            if (mainSettings.PressedOkay == true)
            {
                // instantiate a sentinelExecute object according to settings
                SentinelExecute sentinelExecute = new SentinelExecute(mainSettings.RestrictLevel, mainSettings.TimeLimit, mainSettings.UnblockEvent, mainSettings.TimeLimMins, mainSettings.Password, mainSettings.BlockedAppsIndexer);
            }
        }
    }
}

