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
    [TypeConverter(typeof (PrinterConverter))]
    [ReadOnly(true)]
    [Serializable]
    public class Printer
    {
        #region Private Fields

        private string deviceID;
        private string portName;
        private string isDefault;
        private string location;
        private string verticalResolution;
        private string horizontalResolution;

        #endregion

        #region Constructor

        public Printer()
        {
        }

        public Printer(ManagementObject instance)
        {
            deviceID = (instance.Properties["DeviceID"].Value != null)
                           ? instance.Properties["DeviceID"].Value.ToString().Trim()
                           : string.Empty;
            portName = (instance.Properties["PortName"].Value != null)
                           ? instance.Properties["PortName"].Value.ToString().Trim()
                           : string.Empty;
            isDefault = (instance.Properties["Isdefault"].Value != null)
                            ? instance.Properties["Isdefault"].Value.ToString().Trim()
                            : string.Empty;
            location = (instance.Properties["Location"].Value != null)
                           ? instance.Properties["Location"].Value.ToString().Trim()
                           : string.Empty;
            verticalResolution = (instance.Properties["VerticalResolution"].Value != null)
                                     ? instance.Properties["VerticalResolution"].Value.ToString().Trim()
                                     : string.Empty;
            horizontalResolution = (instance.Properties["HorizontalResolution"].Value != null)
                                       ? instance.Properties["HorizontalResolution"].Value.ToString().Trim()
                                       : string.Empty;
        }

        public Printer(string deviceID, string PortName, string Default, string Location, string vr, string hr)
        {
            this.deviceID = deviceID;
            portName = PortName;
            isDefault = Default;
            location = Location;
            verticalResolution = vr;
            horizontalResolution = hr;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return deviceID;
        }

        #endregion

        #region Public Properties

        [Category("Printer detail")]
        [XmlElement()]
        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        [Category("Printer detail")]
        [XmlElementAttribute()]
        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }

        [Category("Printer detail")]
        [XmlElementAttribute()]
        public string Isdefault
        {
            get { return isDefault; }
            set { isDefault = value; }
        }

        [Category("Printer detail")]
        [XmlElement()]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [Category("Printer detail")]
        [XmlElementAttribute()]
        public string VerticalResolution
        {
            get { return verticalResolution; }
            set { verticalResolution = value; }
        }

        [Category("Printer detail")]
        [XmlElementAttribute()]
        public string HorizontalResolution
        {
            get { return horizontalResolution; }
            set { horizontalResolution = value; }
        }

        #endregion

        #region Converter

        public class PrinterConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is Printer))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new Printer((string) propertyValues["DeviceID"],
                                (string) propertyValues["PortName"],
                                (string) propertyValues["Isdefault"],
                                (string) propertyValues["Location"],
                                (string) propertyValues["VerticalResolution"],
                                (string) propertyValues["HorizontalResolution"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }

        #endregion
    }
}