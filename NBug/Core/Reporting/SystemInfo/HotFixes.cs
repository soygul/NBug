// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Management;
using System.Xml.Serialization;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace NBug.Core.Reporting.SystemInfo
{
    [TypeConverter(typeof (HotFixesConverter))]
    [ReadOnly(true)]
    [Serializable]
    public class HotFixes
    {
        #region Private Fields

        private string hotFixID;
        private string description;
        private string servicePackInEffect;
        private string caption;
        private string cSName;
        private string installDate;
        private string fixComments;
        private string installedBy;
        private string installedOn;
        private string status;

        #endregion

        #region Constructor

        public HotFixes()
        {
        }

        public HotFixes(ManagementObject instance)
        {
            hotFixID = (instance.Properties["HotFixID"].Value != null && instance.Properties["HotFixID"].Value != null)
                           ? instance.Properties["HotFixID"].Value.ToString().Trim()
                           : string.Empty;
            description = (instance.Properties["Description"].Value != null && instance.Properties["Description"].Value != null)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            servicePackInEffect = (instance.Properties["ServicePackInEffect"].Value != null && instance.Properties["ServicePackInEffect"].Value.ToString() != string.Empty)
                                      ? instance.Properties["ServicePackInEffect"].Value.ToString().Trim()
                                      : string.Empty;
            caption = (instance.Properties["Caption"].Value != null && instance.Properties["Caption"].Value.ToString() != string.Empty)
                                      ? instance.Properties["Caption"].Value.ToString().Trim()
                                      : string.Empty;
            cSName = (instance.Properties["CSName"].Value != null && instance.Properties["CSName"].Value.ToString() != string.Empty)
                                      ? instance.Properties["CSName"].Value.ToString().Trim()
                                      : string.Empty;
            installDate = (instance.Properties["InstallDate"].Value != null && instance.Properties["InstallDate"].Value != null && instance.Properties["InstallDate"].Value.ToString() != string.Empty)
                                      ? instance.Properties["InstallDate"].Value.ToString().Trim()
                                      : string.Empty;
            fixComments = (instance.Properties["FixComments"].Value != null && instance.Properties["FixComments"].Value.ToString() != string.Empty)
                                      ? instance.Properties["FixComments"].Value.ToString().Trim()
                                      : string.Empty;
            installedBy = (instance.Properties["InstalledBy"].Value != null && instance.Properties["InstalledBy"].Value.ToString() != string.Empty)
                                      ? instance.Properties["InstalledBy"].Value.ToString().Trim()
                                      : string.Empty;
            installedOn = (instance.Properties["InstalledOn"].Value != null && instance.Properties["InstalledOn"].Value.ToString() != string.Empty)
                                      ? instance.Properties["InstalledOn"].Value.ToString().Trim()
                                      : string.Empty;
            status = (instance.Properties["Status"].Value != null && instance.Properties["Status"].Value.ToString() != string.Empty)
                                      ? instance.Properties["Status"].Value.ToString().Trim()
                                      : string.Empty;
        }

        public HotFixes(string hotfixID, string description, string servicePackInEffect)
        {
            hotFixID = hotfixID;
            this.description = description;
            this.servicePackInEffect = servicePackInEffect;
        }

        #endregion

        #region Override

        public override string ToString()
        {
            if (servicePackInEffect != null)
            {
                return servicePackInEffect;
            }
            else
            {
                return hotFixID;
            }
        }

        #endregion

        #region Public Properties

        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("HotFixID")]
        [ReadOnly(true)]
        public string HotFixID
        {
            get { return hotFixID; }
            set { hotFixID = value; }
        }

        [Category("Hotfixes (QFEs) Installed")]
        [XmlElementAttribute()]
        [DisplayName("Description")]
        [ReadOnly(true)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("ServicePackInEffect")]
        [ReadOnly(true)]
        public string ServicePackInEffect
        {
            get { return servicePackInEffect; }
            set { servicePackInEffect = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("Caption")]
        [ReadOnly(true)]
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("CSName")]
        [ReadOnly(true)]
        public string CSName
        {
            get { return cSName; }
            set { cSName = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("InstallDate")]
        [ReadOnly(true)]
        public string InstallDate
        {
            get { return installDate; }
            set { installDate = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("FixComments")]
        [ReadOnly(true)]
        public string FixComments
        {
            get { return fixComments; }
            set { fixComments = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("InstalledBy")]
        [ReadOnly(true)]
        public string InstalledBy
        {
            get { return installedBy; }
            set { installedBy = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("InstalledOn")]
        [ReadOnly(true)]
        public string InstalledOn
        {
            get { return installedOn; }
            set { installedOn = value; }
        }
        [Category("Hotfixes (QFEs) Installed")]
        [XmlElement()]
        [DisplayName("Status")]
        [ReadOnly(true)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion

        #region Converter

        public class HotFixesConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is HotFixes))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new HotFixes((string) propertyValues["HotFixID"],
                                 (string) propertyValues["Description"],
                                 (string) propertyValues["Fixes_ServicePackInEffect"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }

        #endregion
    }
}