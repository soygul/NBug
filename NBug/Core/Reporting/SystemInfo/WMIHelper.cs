// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System;
using System.Management;

namespace NBug.Core.Reporting.SystemInfo
{
    public static class WMIHelper
    {
        private static ManagementScope mScope;
        private static string path;

        #region Public Methods

        public static HotFixes[] FillHotFixes(string machineName, string userName, string password, string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            HotFixes[] hotfixesInstalled = new HotFixes[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                hotfixesInstalled[i] = new HotFixes((ManagementObject) enumerator.Current);
                i++;
            }
            return hotfixesInstalled;
        }

        public static ComputerSystem FillComputerInformation(string machineName, string userName, string password,
                                                             string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            foreach (ManagementBaseObject instance in instances)
            {
                return new ComputerSystem(instance);
            }
            return null;
        }

        public static Processor[] FillProcessorInformation(string machineName, string userName, string password,
                                                           string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            Processor[] processors = new Processor[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                processors[i] = new Processor((ManagementObject) enumerator.Current);
                i++;
            }
            return processors;
        }

        public static BIOS FillBiosInformation(string machineName, string userName, string password, string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            foreach (ManagementBaseObject instance in instances)
            {
                return new BIOS(instance);
            }
            return null;
        }

        public static OS FillOSInformation(string machineName, string userName, string password, string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            foreach (ManagementBaseObject instance in instances)
            {
                return new OS(instance);
            }
            return null;
        }

        public static VideoController[] FillVideoController(string machineName, string userName, string password,
                                                            string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            VideoController[] videoControllers = new VideoController[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                videoControllers[i] = new VideoController((ManagementObject) enumerator.Current);
                i++;
            }
            return videoControllers;
        }

        public static SoundCard[] FillSoundCard(string machineName, string userName, string password, string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            SoundCard[] soundCard = new SoundCard[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                soundCard[i] = new SoundCard((ManagementObject) enumerator.Current);
                i++;
            }
            return soundCard;
        }

        public static Disk[] FillDisks(string machineName, string userName, string password, string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            Disk[] disks = new Disk[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                disks[i] = new Disk((ManagementObject) enumerator.Current);
                i++;
            }
            return disks;
        }

        public static LogicalDisk[] FillLogicalDisks(string machineName, string userName, string password,
                                                     string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            LogicalDisk[] logicalDisks = new LogicalDisk[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                logicalDisks[i] = new LogicalDisk((ManagementObject) enumerator.Current);
                i++;
            }
            return logicalDisks;
        }

        public static Printer[] FillPrinters(string machineName, string userName, string password, string queryArea)
        {
            try
            {
                InitializeScope(machineName, userName, password);
                ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
                if (mScope != null)
                {
                    managementClass.Scope = mScope;
                }
                ManagementObjectCollection instances = managementClass.GetInstances();
                if (instances == null)
                {
                    return null;
                }
                Printer[] printers = new Printer[instances.Count];
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
                int i = 0;
                while (enumerator.MoveNext())
                {
                    printers[i] = new Printer((ManagementObject) enumerator.Current);
                    i++;
                }
                return printers;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public static NetworkAdapter[] FillNetworkAdapter(string machineName, string userName, string password,
                                                          string queryArea)
        {
            InitializeScope(machineName, userName, password);
            ManagementClass managementClass = new ManagementClass(path + ":" + queryArea);
            if (mScope != null)
            {
                managementClass.Scope = mScope;
            }
            ManagementObjectCollection instances = managementClass.GetInstances();
            if (instances == null)
            {
                return null;
            }
            NetworkAdapter[] networkAdapters = new NetworkAdapter[instances.Count];
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                networkAdapters[i] = new NetworkAdapter(enumerator.Current);
                i++;
            }
            return networkAdapters;
        }

        #endregion

        #region Private Methods

        private static void InitializeScope(string machineName, string userName, string password)
        {
            path = @"\\" + machineName + @"\root\cimv2";
            if (userName != string.Empty && password != string.Empty)
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Username = userName;
                options.Password = password;
                mScope = new ManagementScope();
                mScope.Options = options;
                mScope.Path = new ManagementPath(path);
            }
        }

        #endregion
    }
}