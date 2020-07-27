﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetStalker.MainLogic
{
    public static class AppConfiguration
    {
        /// <summary>
        /// Returns the app setting option whether to activate spoof protection or not.
        /// </summary>
        public static bool SpoofProtection => Properties.Settings.Default.SpoofProtection;

        /// <summary>
        /// Returns the gateway Ip from app settings
        /// </summary>
        public static IPAddress GatewayIp => IPAddress.Parse(NetStalker.Properties.Settings.Default.Gateway);

        /// <summary>
        /// Returns the gateway Mac from app settings
        /// </summary>
        public static PhysicalAddress GatewayMac => PhysicalAddress.Parse(NetStalker.Properties.Settings.Default.gatewaymac);

        /// <summary>
        /// Returns the local Ip from app settings
        /// </summary>
        public static IPAddress LocalIp => IPAddress.Parse(NetStalker.Properties.Settings.Default.localip);

        /// <summary>
        /// Returns the local Mac from app settings
        /// </summary>
        public static PhysicalAddress LocalMac => PhysicalAddress.Parse(NetStalker.Properties.Settings.Default.localmac);

        /// <summary>
        /// Returns the network size
        /// </summary>
        public static int NetworkSize => NetStalker.Properties.Settings.Default.NetSize;

        /// <summary>
        /// Returns the friendly name of the selected adapter
        /// </summary>
        public static string FriendlyName => NetStalker.Properties.Settings.Default.friendlyname;

        /// <summary>
        /// Returns the subnet mask
        /// </summary>
        public static string SubnetMask => NetStalker.Properties.Settings.Default.NetMask;

        /// <summary>
        /// App User Model Id (Necessary for the toast notification service)
        /// </summary>
        public const String APP_ID = "HMZSoftware.NetStalker";

        /// <summary>
        /// Toast Activator CLSID (Necessary for the toast notification service)
        /// </summary>
        public const string Guid = "79A80A63-EFA4-4E1E-B749-E4D4DDCB5B49";
    }
}