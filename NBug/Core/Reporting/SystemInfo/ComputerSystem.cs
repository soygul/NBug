// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System;
using System.ComponentModel;
using System.Globalization;
using System.Management;
using System.Xml.Serialization;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace NBug.Core.Reporting.SystemInfo
{
    [XmlRoot()]
    [Serializable]
    public class ComputerSystem
    {
        #region Fields

        private string manufacturer;
        private string model;
        private string name;
        private string primaryOwnerName;
        private string numberOfProcessors;
        private string totalPhysicalMemory;
        private string adminPasswordStatus;
        private string automaticManagedPagefile;
        private string automaticResetBootOption;
        private string automaticResetCapability;
        private string bootOptionOnLimit;
        private string bootOptionOnWatchDog;
        private string bootROMSupported;
        private string chassisBootupState;
        private string caption;
        private string bootupState;
        private string creationClassName;
        private string description;
        private string daylightInEffect;
        private string currentTimeZone;
        private string domainRole;
        private string domain;
        private string dNSHostName;
        private string enableDaylightSavingsTime;
        private string workgroup;
        private string frontPanelResetStatus;
        private string powerManagementCapabilities;
        private string infraredSupported;
        private string initialLoadInfo;
        private string keyboardPasswordStatus;
        private string installDate;
        private string partOfDomain;
        private string nameFormat;
        private string lastLoadInfo;
        private string oEMLogoBitmap;
        private string[] oEMStringArray;
        private string systemStartupSetting;
        private string systemType;
        private string pCSystemType;
        private string numberOfLogicalProcessors;
        private string networkServerModeEnabled;
        private string resetLimit;
        private string status;
        private string resetCapability;
        private string powerState;
        private string powerOnPasswordStatus;
        private string powerManagementSupported;
        private string powerSupplyState;
        private string systemStartupDelay;
        private string thermalState;
        private string userName;
        private string wakeUpType;
        private string pauseAfterReset;
        private string primaryOwnerContact;
        private string systemStartupOptions;
        private string supportContactDescription;
        private string[] roles;
        private string resetCount;

        #endregion

        #region Constructor

        public ComputerSystem()
        {
        }

        public ComputerSystem(ManagementBaseObject instance)
        {
            manufacturer = instance.Properties["Manufacturer"].Value.ToString().Trim();
            model = instance.Properties["Model"].Value.ToString().Trim();
            name = instance.Properties["Name"].Value.ToString().Trim();
            primaryOwnerName = instance.Properties["PrimaryOwnerName"].Value.ToString().Trim();
            numberOfProcessors = instance.Properties["NumberOfProcessors"].Value.ToString().Trim();
            totalPhysicalMemory = instance.Properties["TotalPhysicalMemory"].Value.ToString().Trim();
            adminPasswordStatus = (instance.Properties["AdminPasswordStatus"].Value != null &&
                                   instance.Properties["AdminPasswordStatus"].Value.ToString() != string.Empty)
                                      ? instance.Properties["AdminPasswordStatus"].Value.ToString().Trim()
                                      : string.Empty;
            automaticManagedPagefile = (instance.Properties["AutomaticManagedPagefile"].Value != null &&
                                        instance.Properties["AutomaticManagedPagefile"].Value.ToString() != string.Empty)
                                           ? instance.Properties["AutomaticManagedPagefile"].Value.ToString().Trim()
                                           : string.Empty;
            automaticResetBootOption = (instance.Properties["AutomaticResetBootOption"].Value != null &&
                                        instance.Properties["AutomaticResetBootOption"].Value.ToString() != string.Empty)
                                           ? instance.Properties["AutomaticResetBootOption"].Value.ToString().Trim()
                                           : string.Empty;
            automaticResetCapability = (instance.Properties["AutomaticResetCapability"].Value != null &&
                                        instance.Properties["AutomaticResetCapability"].Value.ToString() != string.Empty)
                                           ? instance.Properties["AutomaticResetCapability"].Value.ToString().Trim()
                                           : string.Empty;
            bootOptionOnLimit = (instance.Properties["BootOptionOnLimit"].Value != null &&
                                 instance.Properties["BootOptionOnLimit"].Value.ToString() != string.Empty)
                                    ? instance.Properties["BootOptionOnLimit"].Value.ToString().Trim()
                                    : string.Empty;
            bootOptionOnWatchDog = (instance.Properties["BootOptionOnWatchDog"].Value != null &&
                                    instance.Properties["BootOptionOnWatchDog"].Value.ToString() != string.Empty)
                                       ? instance.Properties["BootOptionOnWatchDog"].Value.ToString().Trim()
                                       : string.Empty;
            bootROMSupported = (instance.Properties["BootROMSupported"].Value != null &&
                                instance.Properties["BootROMSupported"].Value.ToString() != string.Empty)
                                   ? instance.Properties["BootROMSupported"].Value.ToString().Trim()
                                   : string.Empty;
            bootupState = (instance.Properties["BootupState"].Value != null &&
                           instance.Properties["BootupState"].Value.ToString() != string.Empty)
                              ? instance.Properties["BootupState"].Value.ToString().Trim()
                              : string.Empty;
            caption = (instance.Properties["Caption"].Value != null &&
                       instance.Properties["Caption"].Value.ToString() != string.Empty)
                          ? instance.Properties["Caption"].Value.ToString().Trim()
                          : string.Empty;
            chassisBootupState = (instance.Properties["ChassisBootupState"].Value != null &&
                                  instance.Properties["ChassisBootupState"].Value.ToString() != string.Empty)
                                     ? instance.Properties["ChassisBootupState"].Value.ToString().Trim()
                                     : string.Empty;
            creationClassName = (instance.Properties["CreationClassName"].Value != null &&
                                 instance.Properties["CreationClassName"].Value.ToString() != string.Empty)
                                    ? instance.Properties["CreationClassName"].Value.ToString().Trim()
                                    : string.Empty;
            currentTimeZone = (instance.Properties["CurrentTimeZone"].Value != null &&
                               instance.Properties["CurrentTimeZone"].Value.ToString() != string.Empty)
                                  ? instance.Properties["CurrentTimeZone"].Value.ToString().Trim()
                                  : string.Empty;
            daylightInEffect = (instance.Properties["DaylightInEffect"].Value != null &&
                                instance.Properties["DaylightInEffect"].Value.ToString() != string.Empty)
                                   ? instance.Properties["DaylightInEffect"].Value.ToString().Trim()
                                   : string.Empty;
            description = (instance.Properties["Description"].Value != null &&
                           instance.Properties["Description"].Value.ToString() != string.Empty)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            dNSHostName = (instance.Properties["DNSHostName"].Value != null &&
                           instance.Properties["DNSHostName"].Value.ToString() != string.Empty)
                              ? instance.Properties["DNSHostName"].Value.ToString().Trim()
                              : string.Empty;
            domain = (instance.Properties["Domain"].Value != null &&
                      instance.Properties["Domain"].Value.ToString() != string.Empty)
                         ? instance.Properties["Domain"].Value.ToString().Trim()
                         : string.Empty;
            domainRole = (instance.Properties["DomainRole"].Value != null &&
                          instance.Properties["DomainRole"].Value.ToString() != string.Empty)
                             ? instance.Properties["DomainRole"].Value.ToString().Trim()
                             : string.Empty;
            enableDaylightSavingsTime = (instance.Properties["EnableDaylightSavingsTime"].Value != null &&
                                         instance.Properties["EnableDaylightSavingsTime"].Value.ToString() !=
                                         string.Empty)
                                            ? instance.Properties["EnableDaylightSavingsTime"].Value.ToString().Trim()
                                            : string.Empty;
            frontPanelResetStatus = (instance.Properties["FrontPanelResetStatus"].Value != null &&
                                     instance.Properties["FrontPanelResetStatus"].Value.ToString() != string.Empty)
                                        ? instance.Properties["FrontPanelResetStatus"].Value.ToString().Trim()
                                        : string.Empty;
            infraredSupported = (instance.Properties["InfraredSupported"].Value != null &&
                                 instance.Properties["InfraredSupported"].Value.ToString() != string.Empty)
                                    ? instance.Properties["InfraredSupported"].Value.ToString().Trim()
                                    : string.Empty;
            initialLoadInfo = (instance.Properties["InitialLoadInfo"].Value != null &&
                               instance.Properties["InitialLoadInfo"].Value.ToString() != string.Empty)
                                  ? instance.Properties["InitialLoadInfo"].Value.ToString().Trim()
                                  : string.Empty;
            installDate = (instance.Properties["InstallDate"].Value != null &&
                           instance.Properties["InstallDate"].Value.ToString() != string.Empty)
                              ? instance.Properties["InstallDate"].Value.ToString().Trim()
                              : string.Empty;
            keyboardPasswordStatus = (instance.Properties["KeyboardPasswordStatus"].Value != null &&
                                      instance.Properties["KeyboardPasswordStatus"].Value.ToString() != string.Empty)
                                         ? instance.Properties["KeyboardPasswordStatus"].Value.ToString().Trim()
                                         : string.Empty;
            lastLoadInfo = (instance.Properties["LastLoadInfo"].Value != null &&
                            instance.Properties["LastLoadInfo"].Value.ToString() != string.Empty)
                               ? instance.Properties["LastLoadInfo"].Value.ToString().Trim()
                               : string.Empty;
            nameFormat = (instance.Properties["NameFormat"].Value != null &&
                          instance.Properties["NameFormat"].Value.ToString() != string.Empty)
                             ? instance.Properties["NameFormat"].Value.ToString().Trim()
                             : string.Empty;
            networkServerModeEnabled = (instance.Properties["NetworkServerModeEnabled"].Value != null &&
                                        instance.Properties["NetworkServerModeEnabled"].Value.ToString() != string.Empty)
                                           ? instance.Properties["NetworkServerModeEnabled"].Value.ToString().Trim()
                                           : string.Empty;
            numberOfLogicalProcessors = (instance.Properties["NumberOfLogicalProcessors"].Value != null &&
                                         instance.Properties["NumberOfLogicalProcessors"].Value.ToString() !=
                                         string.Empty)
                                            ? instance.Properties["NumberOfLogicalProcessors"].Value.ToString().Trim()
                                            : string.Empty;
            oEMLogoBitmap = (instance.Properties["OEMLogoBitmap"].Value != null &&
                             instance.Properties["OEMLogoBitmap"].Value.ToString() != string.Empty)
                                ? instance.Properties["OEMLogoBitmap"].Value.ToString().Trim()
                                : string.Empty;
            oEMStringArray = instance.Properties["OEMStringArray"].Value as string[];
            partOfDomain = (instance.Properties["PartOfDomain"].Value != null &&
                            instance.Properties["PartOfDomain"].Value.ToString() != string.Empty)
                               ? instance.Properties["PartOfDomain"].Value.ToString().Trim()
                               : string.Empty;
            pauseAfterReset = (instance.Properties["PauseAfterReset"].Value != null &&
                               instance.Properties["PauseAfterReset"].Value.ToString() != string.Empty)
                                  ? instance.Properties["PauseAfterReset"].Value.ToString().Trim()
                                  : string.Empty;
            pCSystemType = (instance.Properties["PCSystemType"].Value != null &&
                            instance.Properties["PCSystemType"].Value.ToString() != string.Empty)
                               ? instance.Properties["PCSystemType"].Value.ToString().Trim()
                               : string.Empty;
            powerManagementCapabilities = (instance.Properties["PowerManagementCapabilities"].Value != null &&
                                           instance.Properties["PowerManagementCapabilities"].Value.ToString() !=
                                           string.Empty)
                                              ? instance.Properties["PowerManagementCapabilities"].Value.ToString().Trim
                                                    ()
                                              : string.Empty;
            powerManagementSupported = (instance.Properties["PowerManagementSupported"].Value != null &&
                                        instance.Properties["PowerManagementSupported"].Value.ToString() != string.Empty)
                                           ? instance.Properties["PowerManagementSupported"].Value.ToString().Trim()
                                           : string.Empty;
            powerOnPasswordStatus = (instance.Properties["PowerOnPasswordStatus"].Value != null &&
                                     instance.Properties["PowerOnPasswordStatus"].Value.ToString() != string.Empty)
                                        ? instance.Properties["PowerOnPasswordStatus"].Value.ToString().Trim()
                                        : string.Empty;
            powerState = (instance.Properties["PowerState"].Value != null &&
                          instance.Properties["PowerState"].Value.ToString() != string.Empty)
                             ? instance.Properties["PowerState"].Value.ToString().Trim()
                             : string.Empty;
            powerSupplyState = (instance.Properties["PowerSupplyState"].Value != null &&
                                instance.Properties["PowerSupplyState"].Value.ToString() != string.Empty)
                                   ? instance.Properties["PowerSupplyState"].Value.ToString().Trim()
                                   : string.Empty;
            primaryOwnerContact = (instance.Properties["PrimaryOwnerContact"].Value != null &&
                                   instance.Properties["PrimaryOwnerContact"].Value.ToString() != string.Empty)
                                      ? instance.Properties["PrimaryOwnerContact"].Value.ToString().Trim()
                                      : string.Empty;
            resetCapability = (instance.Properties["ResetCapability"].Value != null &&
                               instance.Properties["ResetCapability"].Value.ToString() != string.Empty)
                                  ? instance.Properties["ResetCapability"].Value.ToString().Trim()
                                  : string.Empty;
            resetCount = (instance.Properties["ResetCount"].Value != null &&
                          instance.Properties["ResetCount"].Value.ToString() != string.Empty)
                             ? instance.Properties["ResetCount"].Value.ToString().Trim()
                             : string.Empty;
            resetLimit = (instance.Properties["ResetLimit"].Value != null &&
                          instance.Properties["ResetLimit"].Value.ToString() != string.Empty)
                             ? instance.Properties["ResetLimit"].Value.ToString().Trim()
                             : string.Empty;
            roles = instance.Properties["Roles"].Value as string[];
            status = (instance.Properties["Status"].Value != null &&
                      instance.Properties["Status"].Value.ToString() != string.Empty)
                         ? instance.Properties["Status"].Value.ToString().Trim()
                         : string.Empty;
            supportContactDescription = (instance.Properties["SupportContactDescription"].Value != null &&
                                         instance.Properties["SupportContactDescription"].Value.ToString() !=
                                         string.Empty)
                                            ? instance.Properties["SupportContactDescription"].Value.ToString().Trim()
                                            : string.Empty;
            systemStartupDelay = (instance.Properties["SystemStartupDelay"].Value != null &&
                                  instance.Properties["SystemStartupDelay"].Value.ToString() != string.Empty)
                                     ? instance.Properties["SystemStartupDelay"].Value.ToString().Trim()
                                     : string.Empty;
            systemStartupOptions = (instance.Properties["SystemStartupOptions"].Value != null &&
                                    instance.Properties["SystemStartupOptions"].Value.ToString() != string.Empty)
                                       ? instance.Properties["SystemStartupOptions"].Value.ToString().Trim()
                                       : string.Empty;
            systemStartupSetting = (instance.Properties["SystemStartupSetting"].Value != null &&
                                    instance.Properties["SystemStartupSetting"].Value.ToString() != string.Empty)
                                       ? instance.Properties["SystemStartupSetting"].Value.ToString().Trim()
                                       : string.Empty;
            systemType = (instance.Properties["SystemType"].Value != null &&
                          instance.Properties["SystemType"].Value.ToString() != string.Empty)
                             ? instance.Properties["SystemType"].Value.ToString().Trim()
                             : string.Empty;
            thermalState = (instance.Properties["ThermalState"].Value != null &&
                            instance.Properties["ThermalState"].Value.ToString() != string.Empty)
                               ? instance.Properties["ThermalState"].Value.ToString().Trim()
                               : string.Empty;
            userName = (instance.Properties["UserName"].Value != null &&
                        instance.Properties["UserName"].Value.ToString() != string.Empty)
                           ? instance.Properties["UserName"].Value.ToString().Trim()
                           : string.Empty;
            wakeUpType = (instance.Properties["WakeUpType"].Value != null &&
                          instance.Properties["WakeUpType"].Value.ToString() != string.Empty)
                             ? instance.Properties["WakeUpType"].Value.ToString().Trim()
                             : string.Empty;
            workgroup = (instance.Properties["Workgroup"].Value != null &&
                         instance.Properties["Workgroup"].Value.ToString() != string.Empty)
                            ? instance.Properties["Workgroup"].Value.ToString().Trim()
                            : string.Empty;
        }

        #endregion

        #region Properties

        #region Computer Information

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PrimaryOwnerName
        {
            get { return primaryOwnerName; }
            set { primaryOwnerName = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NumberOfProcessors
        {
            get { return numberOfProcessors; }
            set { numberOfProcessors = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string TotalPhysicalMemory
        {
            get { return totalPhysicalMemory; }
            set { totalPhysicalMemory = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string AdminPasswordStatus
        {
            get { return adminPasswordStatus; }
            set { adminPasswordStatus = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string AutomaticManagedPagefile
        {
            get { return automaticManagedPagefile; }
            set { automaticManagedPagefile = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string AutomaticResetBootOption
        {
            get { return automaticResetBootOption; }
            set { automaticResetBootOption = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string AutomaticResetCapability
        {
            get { return automaticResetCapability; }
            set { automaticResetCapability = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BootOptionOnLimit
        {
            get { return bootOptionOnLimit; }
            set { bootOptionOnLimit = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BootOptionOnWatchDog
        {
            get { return bootOptionOnWatchDog; }
            set { bootOptionOnWatchDog = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BootROMSupported
        {
            get { return bootROMSupported; }
            set { bootROMSupported = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string ChassisBootupState
        {
            get { return chassisBootupState; }
            set { chassisBootupState = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string BootupState
        {
            get { return bootupState; }
            set { bootupState = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CreationClassName
        {
            get { return creationClassName; }
            set { creationClassName = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string DaylightInEffect
        {
            get { return daylightInEffect; }
            set { daylightInEffect = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CurrentTimeZone
        {
            get { return currentTimeZone; }
            set { currentTimeZone = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string DomainRole
        {
            get { return domainRole; }
            set { domainRole = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string DNSHostName
        {
            get { return dNSHostName; }
            set { dNSHostName = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string EnableDaylightSavingsTime
        {
            get { return enableDaylightSavingsTime; }
            set { enableDaylightSavingsTime = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Workgroup
        {
            get { return workgroup; }
            set { workgroup = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string FrontPanelResetStatus
        {
            get { return frontPanelResetStatus; }
            set { frontPanelResetStatus = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PowerManagementCapabilities
        {
            get { return powerManagementCapabilities; }
            set { powerManagementCapabilities = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string InfraredSupported
        {
            get { return infraredSupported; }
            set { infraredSupported = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string InitialLoadInfo
        {
            get { return initialLoadInfo; }
            set { initialLoadInfo = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string KeyboardPasswordStatus
        {
            get { return keyboardPasswordStatus; }
            set { keyboardPasswordStatus = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string InstallDate
        {
            get { return installDate; }
            set { installDate = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PartOfDomain
        {
            get { return partOfDomain; }
            set { partOfDomain = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NameFormat
        {
            get { return nameFormat; }
            set { nameFormat = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string LastLoadInfo
        {
            get { return lastLoadInfo; }
            set { lastLoadInfo = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string OEMLogoBitmap
        {
            get { return oEMLogoBitmap; }
            set { oEMLogoBitmap = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string[] OEMStringArray
        {
            get { return oEMStringArray; }
            set { oEMStringArray = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemStartupSetting
        {
            get { return systemStartupSetting; }
            set { systemStartupSetting = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemType
        {
            get { return systemType; }
            set { systemType = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PCSystemType
        {
            get { return pCSystemType; }
            set { pCSystemType = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NumberOfLogicalProcessors
        {
            get { return numberOfLogicalProcessors; }
            set { numberOfLogicalProcessors = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NetworkServerModeEnabled
        {
            get { return networkServerModeEnabled; }
            set { networkServerModeEnabled = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string ResetLimit
        {
            get { return resetLimit; }
            set { resetLimit = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string ResetCapability
        {
            get { return resetCapability; }
            set { resetCapability = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PowerState
        {
            get { return powerState; }
            set { powerState = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PowerOnPasswordStatus
        {
            get { return powerOnPasswordStatus; }
            set { powerOnPasswordStatus = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PowerManagementSupported
        {
            get { return powerManagementSupported; }
            set { powerManagementSupported = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PowerSupplyState
        {
            get { return powerSupplyState; }
            set { powerSupplyState = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemStartupDelay
        {
            get { return systemStartupDelay; }
            set { systemStartupDelay = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string ThermalState
        {
            get { return thermalState; }
            set { thermalState = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string WakeUpType
        {
            get { return wakeUpType; }
            set { wakeUpType = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PauseAfterReset
        {
            get { return pauseAfterReset; }
            set { pauseAfterReset = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string PrimaryOwnerContact
        {
            get { return primaryOwnerContact; }
            set { primaryOwnerContact = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SystemStartupOptions
        {
            get { return systemStartupOptions; }
            set { systemStartupOptions = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string SupportContactDescription
        {
            get { return supportContactDescription; }
            set { supportContactDescription = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string[] Roles
        {
            get { return roles; }
            set { roles = value; }
        }

        [Category("Computer Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string ResetCount
        {
            get { return resetCount; }
            set { resetCount = value; }
        }

        #endregion

        #endregion

        #region Nested Class

        public class TypeArrayConverter : CollectionConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if ((destinationType == typeof (string)) && (value is Array))
                {
                    return value.GetType().Name.Replace("[]", "");
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }

            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value,
                                                                       Attribute[] attributes)
            {
                PropertyDescriptor[] descriptorArray1 = null;
                if (value.GetType().IsArray)
                {
                    int num1 = ((Array) value).GetLength(0);
                    descriptorArray1 = new PropertyDescriptor[num1];
                    Type type1 = value.GetType();
                    Type type2 = type1.GetElementType();
                    for (int num2 = 0; num2 < num1; num2++)
                    {
                        descriptorArray1[num2] = new ArrayPropertyDescriptor(type1, type2, num2);
                    }
                }
                return new PropertyDescriptorCollection(descriptorArray1);
            }

            public override bool GetPropertiesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            private class ArrayPropertyDescriptor : SimplePropertyDescriptor
            {
                public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
                    : base(arrayType, elementType.Name + "[" + index + "]", elementType, null)
                {
                    this.index = index;
                }

                public override object GetValue(object instance)
                {
                    if (instance is Array)
                    {
                        Array array1 = (Array) instance;
                        if (array1.GetLength(0) > index)
                        {
                            return array1.GetValue(index);
                        }
                    }
                    return null;
                }

                public override void SetValue(object instance, object value)
                {
                    if (instance is Array)
                    {
                        Array array1 = (Array) instance;
                        if (array1.GetLength(0) > index)
                        {
                            array1.SetValue(value, index);
                        }
                        OnValueChanged(instance, EventArgs.Empty);
                    }
                }

                private int index;
            }
        }

        #endregion
    }
}