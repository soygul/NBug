// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System;
using System.ComponentModel;
using System.Management;
using System.Xml.Serialization;

#pragma warning disable CS1591 // Missing XML comment for internally visible type or member
namespace NBug.Core.Reporting.SystemInfo
{
    [Serializable]
    public class BIOS

  {
        #region Fields BIOS Information

        private string manufacturer;
        private string name;
        private string version;
        private string releaseDate;
        private string sMBIOSBIOSVersion;
        private UInt16[] biosCharacteristics;
        private string[] bIOSVersion;
        private string caption;
        private string buildNumber;
        private string codeSet;
        private string description;
        private string identificationCode;
        private string currentLanguage;
        private string installableLanguages;
        private string languageEdition;
        private string[] listOfLanguages;
        private string installDate;
        private string softwareElementID;
        private string serialNumber;
        private string primaryBIOS;
        private string otherTargetOS;
        private string sMBIOSMajorVersion;
        private string sMBIOSMinorVersion;
        private string softwareElementState;
        private string sMBIOSPresent;
        private string targetOperatingSystem;
        private string status;

        #endregion

        #region Constructor

        internal BIOS()
        {
        }

        internal BIOS(ManagementBaseObject instance)
        {
            manufacturer = instance.Properties["Manufacturer"].Value.ToString().Trim();
            name = instance.Properties["Name"].Value.ToString().Trim();
            version = instance.Properties["Version"].Value.ToString().Trim();
            releaseDate = instance.Properties["ReleaseDate"].Value.ToString().Trim();
            sMBIOSBIOSVersion = instance.Properties["SMBIOSBIOSVersion"].Value.ToString().Trim();
            biosCharacteristics = instance.Properties["BiosCharacteristics"].Value as ushort[];
            bIOSVersion = instance.Properties["BIOSVersion"].Value as string[];
            buildNumber = (instance.Properties["BuildNumber"].Value != null &&
                           instance.Properties["BuildNumber"].Value.ToString() != string.Empty)
                              ? instance.Properties["BuildNumber"].Value.ToString().Trim()
                              : string.Empty;
            caption = (instance.Properties["Caption"].Value != null &&
                       instance.Properties["Caption"].Value.ToString() != string.Empty)
                          ? instance.Properties["Caption"].Value.ToString().Trim()
                          : string.Empty;
            codeSet = (instance.Properties["CodeSet"].Value != null &&
                       instance.Properties["CodeSet"].Value.ToString() != string.Empty)
                          ? instance.Properties["CodeSet"].Value.ToString().Trim()
                          : string.Empty;
            currentLanguage = (instance.Properties["CurrentLanguage"].Value != null &&
                               instance.Properties["CurrentLanguage"].Value.ToString() != string.Empty)
                                  ? instance.Properties["CurrentLanguage"].Value.ToString().Trim()
                                  : string.Empty;
            description = (instance.Properties["Description"].Value != null &&
                           instance.Properties["Description"].Value.ToString() != string.Empty)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            identificationCode = (instance.Properties["IdentificationCode"].Value != null &&
                                  instance.Properties["IdentificationCode"].Value.ToString() != string.Empty)
                                     ? instance.Properties["IdentificationCode"].Value.ToString().Trim()
                                     : string.Empty;
            installableLanguages = (instance.Properties["InstallableLanguages"].Value != null &&
                                    instance.Properties["InstallableLanguages"].Value.ToString() != string.Empty)
                                       ? instance.Properties["InstallableLanguages"].Value.ToString().Trim()
                                       : string.Empty;
            installDate = (instance.Properties["InstallDate"].Value != null &&
                           instance.Properties["InstallDate"].Value.ToString() != string.Empty)
                              ? instance.Properties["InstallDate"].Value.ToString().Trim()
                              : string.Empty;
            languageEdition = (instance.Properties["LanguageEdition"].Value != null &&
                               instance.Properties["LanguageEdition"].Value.ToString() != string.Empty)
                                  ? instance.Properties["LanguageEdition"].Value.ToString().Trim()
                                  : string.Empty;
            listOfLanguages = instance.Properties["ListOfLanguages"].Value as string[];
            otherTargetOS = (instance.Properties["OtherTargetOS"].Value != null &&
                             instance.Properties["OtherTargetOS"].Value.ToString() != string.Empty)
                                ? instance.Properties["OtherTargetOS"].Value.ToString().Trim()
                                : string.Empty;
            primaryBIOS = (instance.Properties["PrimaryBIOS"].Value != null &&
                           instance.Properties["PrimaryBIOS"].Value.ToString() != string.Empty)
                              ? instance.Properties["PrimaryBIOS"].Value.ToString().Trim()
                              : string.Empty;
            serialNumber = (instance.Properties["SerialNumber"].Value != null &&
                            instance.Properties["SerialNumber"].Value.ToString() != string.Empty)
                               ? instance.Properties["SerialNumber"].Value.ToString().Trim()
                               : string.Empty;
            sMBIOSMajorVersion = (instance.Properties["SMBIOSMajorVersion"].Value != null &&
                                  instance.Properties["SMBIOSMajorVersion"].Value.ToString() != string.Empty)
                                     ? instance.Properties["SMBIOSMajorVersion"].Value.ToString().Trim()
                                     : string.Empty;
            sMBIOSMinorVersion = (instance.Properties["SMBIOSMinorVersion"].Value != null &&
                                  instance.Properties["SMBIOSMinorVersion"].Value.ToString() != string.Empty)
                                     ? instance.Properties["SMBIOSMinorVersion"].Value.ToString().Trim()
                                     : string.Empty;
            sMBIOSPresent = (instance.Properties["SMBIOSPresent"].Value != null &&
                             instance.Properties["SMBIOSPresent"].Value.ToString() != string.Empty)
                                ? instance.Properties["SMBIOSPresent"].Value.ToString().Trim()
                                : string.Empty;
            softwareElementID = (instance.Properties["SoftwareElementID"].Value != null &&
                                 instance.Properties["SoftwareElementID"].Value.ToString() != string.Empty)
                                    ? instance.Properties["SoftwareElementID"].Value.ToString().Trim()
                                    : string.Empty;
            softwareElementState = (instance.Properties["SoftwareElementState"].Value != null &&
                                    instance.Properties["SoftwareElementState"].Value.ToString() != string.Empty)
                                       ? instance.Properties["SoftwareElementState"].Value.ToString().Trim()
                                       : string.Empty;
            targetOperatingSystem = (instance.Properties["TargetOperatingSystem"].Value != null &&
                                     instance.Properties["TargetOperatingSystem"].Value.ToString() != string.Empty)
                                        ? instance.Properties["TargetOperatingSystem"].Value.ToString().Trim()
                                        : string.Empty;
            status = (instance.Properties["Status"].Value != null &&
                      instance.Properties["Status"].Value.ToString() != string.Empty)
                         ? instance.Properties["Status"].Value.ToString().Trim()
                         : string.Empty;
        }

        #endregion

        #region Bios Information

        [Category("Bios Information")]
        [XmlElement()]
        [ReadOnly(true)]
        internal string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string Version
        {
            get { return version; }
            set { version = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SMBIOSBIOSVersion
        {
            get { return sMBIOSBIOSVersion; }
            set { sMBIOSBIOSVersion = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal UInt16[] BiosCharacteristics
        {
            get { return biosCharacteristics; }
            set { biosCharacteristics = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string[] BIOSVersion
        {
            get { return bIOSVersion; }
            set { bIOSVersion = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string BuildNumber
        {
            get { return buildNumber; }
            set { buildNumber = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string CodeSet
        {
            get { return codeSet; }
            set { codeSet = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string IdentificationCode
        {
            get { return identificationCode; }
            set { identificationCode = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string CurrentLanguage
        {
            get { return currentLanguage; }
            set { currentLanguage = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string InstallableLanguages
        {
            get { return installableLanguages; }
            set { installableLanguages = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string LanguageEdition
        {
            get { return languageEdition; }
            set { languageEdition = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string[] ListOfLanguages
        {
            get { return listOfLanguages; }
            set { listOfLanguages = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string InstallDate
        {
            get { return installDate; }
            set { installDate = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SoftwareElementID
        {
            get { return softwareElementID; }
            set { softwareElementID = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string PrimaryBIOS
        {
            get { return primaryBIOS; }
            set { primaryBIOS = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string OtherTargetOS
        {
            get { return otherTargetOS; }
            set { otherTargetOS = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SMBIOSMajorVersion
        {
            get { return sMBIOSMajorVersion; }
            set { sMBIOSMajorVersion = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SMBIOSMinorVersion
        {
            get { return sMBIOSMinorVersion; }
            set { sMBIOSMinorVersion = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SoftwareElementState
        {
            get { return softwareElementState; }
            set { softwareElementState = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string SMBIOSPresent
        {
            get { return sMBIOSPresent; }
            set { sMBIOSPresent = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string TargetOperatingSystem
        {
            get { return targetOperatingSystem; }
            set { targetOperatingSystem = value; }
        }

        [Category("Bios Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        internal string Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}