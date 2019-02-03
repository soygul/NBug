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
    [TypeConverter(typeof (NetworkInfoConverter))]
    [ReadOnly(true)]
    [Serializable]
    public class NetworkAdapter
    {
        #region Private Fields

        private string description;
        private string dHCPEnabled;
        private string mACAddress;
        private string iPAddress;

        #endregion

        #region Constructor

        public NetworkAdapter()
        {
        }

        public NetworkAdapter(ManagementBaseObject instance)
        {
            description = instance.Properties["Description"].Value.ToString().Trim();
            dHCPEnabled = instance.Properties["DHCPEnabled"].Value.ToString().Trim();
            mACAddress = (instance.Properties["MACAddress"].Value != null)
                             ?
                         instance.Properties["MACAddress"].Value.ToString().Trim()
                             : string.Empty;
            iPAddress = (instance.Properties["IPAddress"].Value != null)
                            ? (instance.Properties["IPAddress"].Value as string[])[0]
                            : string.Empty;
        }

        private NetworkAdapter(string description, string dhcp, string mac)
        {
            this.description = description;
            dHCPEnabled = dhcp;
            mACAddress = mac;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return description;
        }

        #endregion

        #region Public Property

        [Category("Network Adapter Configuration")]
        [XmlElement()]
        [ReadOnly(true)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Network Adapter Configuration")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string DHCPEnabled
        {
            get { return dHCPEnabled; }
            set { dHCPEnabled = value; }
        }

        [Category("Network Adapter Configuration")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string MACAddress
        {
            get { return mACAddress; }
            set { mACAddress = value; }
        }

        [Category("Network Adapter Configuration")]
        [XmlElement()]
        [ReadOnly(true)]
        public string PAddress
        {
            get { return iPAddress; }
            set { iPAddress = value; }
        }

        #endregion

        #region Converter

        public class NetworkInfoConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is NetworkAdapter))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new NetworkAdapter((string) propertyValues["Description"],
                                       (string) propertyValues["DHCPEnabled"],
                                       (string) propertyValues["MACAddress"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }

        #endregion
    }
}