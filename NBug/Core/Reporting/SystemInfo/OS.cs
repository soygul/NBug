// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System;
using System.ComponentModel;
using System.Management;
using System.Xml.Serialization;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace NBug.Core.Reporting.SystemInfo
{
    [Serializable]
    public class OS
    {
        #region Fields O/S Information

        private string caption;
        private string version;
        private string buildNumber;
        private string buildType;
        private string bootDevice;
        private string systemDevice;
        private string windowsDirectory;
        private string systemDirectory;
        private string cSName;
        private string csdVersion;
        private string currentTimeZone;
        private string installDate;
        private string lastBootUpTime;
        private string organization;
        private string osLanguage;
        private string primary;
        private string registeredUser;
        private string serialNumber;
        private string totalVirtualMemorySize;

        #endregion

        #region Constructor

        public OS()
        {
        }

        public OS(ManagementBaseObject instance)
        {
            caption = (instance.Properties["Caption"].Value != null)
                             ? instance.Properties["Caption"].Value.ToString().Trim()
                             : string.Empty;
            version = (instance.Properties["Version"].Value != null)
                             ? instance.Properties["Version"].Value.ToString().Trim()
                             : string.Empty;
            buildNumber = (instance.Properties["BuildNumber"].Value != null)
                                 ? instance.Properties["BuildNumber"].Value.ToString().Trim()
                                 : string.Empty;
            buildType = (instance.Properties["BuildType"].Value != null)
                               ? instance.Properties["BuildType"].Value.ToString().Trim()
                               : string.Empty;
            bootDevice = (instance.Properties["BootDevice"].Value != null)
                                ? instance.Properties["BootDevice"].Value.ToString().Trim()
                                : string.Empty;
            systemDevice = (instance.Properties["SystemDevice"].Value != null)
                                  ? instance.Properties["SystemDevice"].Value.ToString().Trim()
                                  : string.Empty;
            windowsDirectory = (instance.Properties["WindowsDirectory"].Value != null)
                                      ? instance.Properties["WindowsDirectory"].Value.ToString().Trim()
                                      : string.Empty;
            systemDirectory = (instance.Properties["SystemDirectory"].Value != null)
                                     ? instance.Properties["SystemDirectory"].Value.ToString().Trim()
                                     : string.Empty;
            cSName = (instance.Properties["CSName"].Value != null)
                            ? instance.Properties["CSName"].Value.ToString().Trim()
                            : string.Empty;
            csdVersion = (instance.Properties["CsdVersion"].Value != null)
                                ? instance.Properties["CsdVersion"].Value.ToString().Trim()
                                : string.Empty;
            currentTimeZone = (instance.Properties["CurrentTimeZone"].Value != null)
                                     ? instance.Properties["CurrentTimeZone"].Value.ToString().Trim()
                                     : string.Empty;
            installDate = (instance.Properties["InstallDate"].Value != null)
                                 ? instance.Properties["InstallDate"].Value.ToString().Trim()
                                 : string.Empty;
            lastBootUpTime = (instance.Properties["LastBootUpTime"].Value != null)
                                    ? instance.Properties["LastBootUpTime"].Value.ToString().Trim()
                                    : string.Empty;
            organization = (instance.Properties["Organization"].Value != null)
                                  ? instance.Properties["Organization"].Value.ToString().Trim()
                                  : string.Empty;
            osLanguage = (instance.Properties["OsLanguage"].Value != null)
                                ? instance.Properties["OsLanguage"].Value.ToString().Trim()
                                : string.Empty;
            primary = (instance.Properties["Primary"].Value != null)
                             ? instance.Properties["Primary"].Value.ToString().Trim()
                             : string.Empty;
            registeredUser = (instance.Properties["RegisteredUser"].Value != null)
                                    ? instance.Properties["RegisteredUser"].Value.ToString().Trim()
                                    : string.Empty;
            serialNumber = (instance.Properties["SerialNumber"].Value != null)
                                  ? instance.Properties["SerialNumber"].Value.ToString().Trim()
                                  : string.Empty;
            totalVirtualMemorySize = (instance.Properties["TotalVirtualMemorySize"].Value != null)
                                            ? instance.Properties["TotalVirtualMemorySize"].Value.ToString().Trim()
                                            : string.Empty;
        }

        #endregion

        #region OS Information

        [Category("OS Information")]
        [XmlElement()]
        [ReadOnly(true)]
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BuildNumber
        {
            get { return buildNumber; }
            set { buildNumber = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BuildType
        {
            get { return buildType; }
            set { buildType = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BootDevice
        {
            get { return bootDevice; }
            set { bootDevice = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemDevice
        {
            get { return systemDevice; }
            set { systemDevice = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string WindowsDirectory
        {
            get { return windowsDirectory; }
            set { windowsDirectory = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemDirectory
        {
            get { return systemDirectory; }
            set { systemDirectory = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CS_Name
        {
            get { return cSName; }
            set { cSName = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CsdVersion
        {
            get { return csdVersion; }
            set { csdVersion = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CurrentTimeZone
        {
            get { return currentTimeZone; }
            set { currentTimeZone = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string InstallDate
        {
            get { return installDate; }
            set { installDate = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string LastBootUpTime
        {
            get { return lastBootUpTime; }
            set { lastBootUpTime = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string OsLanguage
        {
            get { return osLanguage; }
            set { osLanguage = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Primary
        {
            get { return primary; }
            set { primary = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string RegisteredUser
        {
            get { return registeredUser; }
            set { registeredUser = value; }
        }

        [Category("OS Information")]
        [XmlElement()]
        [ReadOnly(true)]
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        [Category("OS Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string TotalVirtualMemorySize
        {
            get { return totalVirtualMemorySize; }
            set { totalVirtualMemorySize = value; }
        }

        #endregion
    }
}