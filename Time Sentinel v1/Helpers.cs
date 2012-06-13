
// helper code which creates enums that make code easier to read

namespace Time_Sentinel_v1
{    
    public enum RestrictionLevel
    {
        /// <summary>
        /// enum for restriction level
        /// </summary>
        Applications,
        Wireless,
        WirelessWired
    }

    public enum TimeLimit
    {
        /// <summary>
        /// enum for time limit
        /// </summary>
        Time,
        Event
    }

    public enum UnblockEvent
    {
        /// <summary>
        /// enum for unblock event
        /// </summary>
        Button,
        Math,
        Password,
        Never
    }

    public enum HackerTaskMgr
    {
        /// <summary>
        /// enum for the block task manager setting of the hacker options
        /// </summary>
        NoBlockTaskMgr,
        BlockTaskMrg
    }

    public enum EndReason
    {
        /// <summary>
        /// enum for the reason for ending the program
        /// </summary>
        TimeElapsed,
        ManuallyTerminated,
        MaxTimeReached
    }
}
