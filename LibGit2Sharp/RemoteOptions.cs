﻿namespace LibGit2Sharp
{
    /// <summary>
    /// Collection of parameters controlling reote behavior.
    /// </summary>
    public class RemoteOptions
    {
        /// <summary>
        /// Configures operating behind a proxy
        /// <para>
        /// If not set, any proxy settings will be ignored
        /// </para>
        /// </summary>
        public ProxyOptions ProxyOptions { get; set; }
    }
}
