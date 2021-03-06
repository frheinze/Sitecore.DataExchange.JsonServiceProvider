﻿using Sitecore.DataExchange.Plugins;

namespace Comspace.Sitecore.DataExchange.JsonServiceProvider.Plugins
{
    /// <summary>
    /// Contains all settings for accessing celum (asset picker and webservices).
    /// </summary>
    public class JsonServiceEndpointSettings : EndpointSettings
    {
        public string Host { get; set; }

        public string Protocol { get; set; }

        #region Authorization

        public string Scheme { get; set; }

        public string Parameter { get; set; }

        #endregion
    }
}