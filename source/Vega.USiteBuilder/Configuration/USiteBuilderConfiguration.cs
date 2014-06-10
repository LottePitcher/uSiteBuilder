﻿namespace Vega.USiteBuilder.Configuration
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Holds uSiteBuilder configuration settings (read from web.config)
    /// </summary>
    static class USiteBuilderConfiguration
    {
        private static bool? _isSuppressed = null;

        /// <summary>
        /// Get setting whether we should enable Umbraco MVC default controller
        /// </summary>
        public static bool EnableDefaultControllerType
        {
            get
            {
                bool retVal;
                if (!Boolean.TryParse(ConfigurationManager.AppSettings["siteBuilderEnableDefaultControllerType"], out retVal))
                {
                    retVal = true;
                }

                return retVal;
            }
        }


        /// <summary>
        /// Get's username of umbraco user whose account is used with Umbraco API
        /// </summary>
        public static bool SuppressSynchronization
        {
            get
            {
                if (!_isSuppressed.HasValue)
                {
                    string value = ConfigurationManager.AppSettings["siteBuilderSuppressSynchronization"];
                    bool retVal = false;

                    if (!string.IsNullOrEmpty(value))
                    {
                        Boolean.TryParse(value, out retVal);
                    }

                    _isSuppressed = retVal;
                }

                return _isSuppressed.Value;
            }
        }


        /// <summary>
        /// Gets the ';' seperated list of assemblies to scan, if empty all assemblies will be scanned
        /// </summary>
        public static string Assemblies
        {
            get
            {
                string retVal = ConfigurationManager.AppSettings["siteBuilderAssembly"];

                if (String.IsNullOrEmpty(retVal))
                {
                    retVal = "";
                }
                return retVal;
            }
        }
    }
}