namespace Pathoschild.Stardew.Automate.Framework
{
    /// <summary>The raw mod configuration.</summary>
    internal class ModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>Whether to check for updates to the mod.</summary>
        public bool CheckForUpdates { get; set; } = true;

        /// <summary>Write more trace information to the log.</summary>
        public bool VerboseLogging { get; set; } = false;

        /// <summary>The number of ticks between each automation process (60 = once per second).</summary>
        public int AutomationInterval { get; set; } = 60;
    }
}
