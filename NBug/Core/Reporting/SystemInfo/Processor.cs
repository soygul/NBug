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
    [TypeConverter(typeof (ProcessorConverter))]
    [Serializable]
    public class Processor
    {
        private string name;
        private string manufacturer;
        private string description;
        private string currentClockSpeed;
        private string maxClockSpeed;
        private string addressWidth;
        private string extClock;
        private string l2CacheSize;
        private string l2CacheSpeed;
        private string numberOfCores;
        private string numberOfLogicalProcessors;

        public Processor()
        {
        }

        public Processor(string Name, string Manufacturer, string Description, string CurrentClockSpeed,
                         string MaxClockSpeed, string AddressWidth, string ExtClock, string L2CacheSize,
                         string L2CacheSpeed, string NumberOfCores, string NumberOfLogicalProcessors)
        {
            name = Name;
            manufacturer = Manufacturer;
            description = Description;
            currentClockSpeed = CurrentClockSpeed;
            maxClockSpeed = MaxClockSpeed;
            addressWidth = AddressWidth;
            extClock = ExtClock;
            l2CacheSize = L2CacheSize;
            l2CacheSpeed = L2CacheSpeed;
            numberOfCores = NumberOfCores;
            numberOfLogicalProcessors = NumberOfLogicalProcessors;
        }

        public Processor(ManagementObject instance)
        {
            name = (instance.Properties["Name"].Value != null)
                       ? instance.Properties["Name"].Value.ToString().Trim()
                       : string.Empty;
            manufacturer = (instance.Properties["Manufacturer"].Value != null)
                               ? instance.Properties["Manufacturer"].Value.ToString().Trim()
                               : string.Empty;
            description = (instance.Properties["Description"].Value != null)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            maxClockSpeed = (instance.Properties["MaxClockSpeed"].Value != null)
                                ? instance.Properties["MaxClockSpeed"].Value.ToString().Trim()
                                : string.Empty;
            currentClockSpeed = (instance.Properties["CurrentClockSpeed"].Value != null)
                                    ? instance.Properties["CurrentClockSpeed"].Value.ToString().Trim()
                                    : string.Empty;
            addressWidth = (instance.Properties["AddressWidth"].Value != null)
                               ? instance.Properties["AddressWidth"].Value.ToString().Trim()
                               : string.Empty;
            extClock = (instance.Properties["ExtClock"].Value != null)
                           ? instance.Properties["ExtClock"].Value.ToString().Trim()
                           : string.Empty;
            l2CacheSize = (instance.Properties["L2CacheSize"].Value != null)
                              ? instance.Properties["L2CacheSize"].Value.ToString().Trim()
                              : string.Empty;
            l2CacheSpeed = (instance.Properties["L2CacheSpeed"].Value != null)
                               ? instance.Properties["L2CacheSpeed"].Value.ToString().Trim()
                               : string.Empty;
            try
            {
                if (HasProperty(instance, "NumberOfCores")) //instance.GetQualifierValue("NumberOfCores") != null)
                {
                    numberOfCores = (instance.Properties["NumberOfCores"].Value != null)
                                        ? instance.Properties["NumberOfCores"].Value.ToString().Trim()
                                        : string.Empty;
                }
                else
                {
                    numberOfCores = "Property is valid on longhorn and Vista.";
                }
                if (HasProperty(instance, "NumberOfLogicalProcessors"))
                    //(instance.GetPropertyValue("NumberOfLogicalProcessors") != null)
                {
                    numberOfLogicalProcessors = (instance.Properties["NumberOfLogicalProcessors"].Value !=
                                                 null)
                                                    ? instance.Properties["NumberOfLogicalProcessors"].Value.
                                                          ToString().Trim()
                                                    : string.Empty;
                }
                else
                {
                    numberOfLogicalProcessors = "Property is valid on longhorn and Vista.";
                }
            }
            catch (Exception)
            {
            }
        }

        private bool HasProperty(ManagementObject instance, string s)
        {
            foreach (PropertyData data in instance.Properties)
            {
                if (data.Name.ToUpper() == s.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return name;
        }

        #region Processor Information

        [Category("Processor Information")]
        [XmlElement()]
        [ReadOnly(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string CurrentClockSpeed
        {
            get { return currentClockSpeed; }
            set { currentClockSpeed = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string MaxClockSpeed
        {
            get { return maxClockSpeed; }
            set { maxClockSpeed = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string AddressWidth
        {
            get { return addressWidth; }
            set { addressWidth = value; }
        }

        [Category("Processor Information")]
        [XmlElement()]
        [ReadOnly(true)]
        public string ExtClock
        {
            get { return extClock; }
            set { extClock = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string L2CacheSize
        {
            get { return l2CacheSize; }
            set { l2CacheSize = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string L2CacheSpeed
        {
            get { return l2CacheSpeed; }
            set { l2CacheSpeed = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NumberOfCores
        {
            get { return numberOfCores; }
            set { numberOfCores = value; }
        }

        [Category("Processor Information")]
        [XmlElementAttribute()]
        [ReadOnly(true)]
        public string NumberOfLogicalProcessors
        {
            get { return numberOfLogicalProcessors; }
            set { numberOfLogicalProcessors = value; }
        }

        #endregion

        public class ProcessorConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is Processor))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new Processor((string) propertyValues["Name"],
                                  (string) propertyValues["Manufacturer"],
                                  (string) propertyValues["Description"],
                                  (string) propertyValues["CurrentClockSpeed"],
                                  (string) propertyValues["MaxClockSpeed"],
                                  (string) propertyValues["AddressWidth"],
                                  (string) propertyValues["ExtClock"],
                                  (string) propertyValues["L2CacheSize"],
                                  (string) propertyValues["L2CacheSpeed"],
                                  (string) propertyValues["L2CacheSize"],
                                  (string) propertyValues["L2CacheSpeed"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }
    }
}