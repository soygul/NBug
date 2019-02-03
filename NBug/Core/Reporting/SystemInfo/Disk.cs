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
    [TypeConverter(typeof (DiskConverter))]
    [ReadOnly(true)]
    [Serializable]
    public class Disk
    {
        private string manufacturer;
        private string model;
        private string description;
        private string interfaceType;
        private string size;
        private string partitions;
        private string scsiBus;
        private string scsiTargetID;
        private string deviceID;

        public Disk()
        {
        }

        public Disk(ManagementObject instance)
        {
            PropertyDataCollection.PropertyDataEnumerator enumerator = instance.Properties.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
            manufacturer = (instance.Properties["Manufacturer"].Value != null)
                               ? instance.Properties["Manufacturer"].Value.ToString().Trim()
                               : string.Empty;
            model = (instance.Properties["Model"].Value != null)
                        ? instance.Properties["Model"].Value.ToString().Trim()
                        : string.Empty;
            description = (instance.Properties["Description"].Value != null)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            interfaceType = (instance.Properties["InterfaceType"].Value != null)
                                ? instance.Properties["InterfaceType"].Value.ToString().Trim()
                                : string.Empty;
            size = (instance.Properties["Size"].Value != null)
                       ? instance.Properties["Size"].Value.ToString().Trim()
                       : string.Empty;
            partitions = (instance.Properties["Partitions"].Value != null)
                             ? instance.Properties["Partitions"].Value.ToString().Trim()
                             : string.Empty;
            scsiBus = (instance.Properties["ScsiBus"].Value != null)
                          ? instance.Properties["ScsiBus"].Value.ToString().Trim()
                          : string.Empty;
            scsiTargetID = (instance.Properties["ScsiTargetID"].Value != null)
                               ? instance.Properties["ScsiTargetID"].Value.ToString().Trim()
                               : string.Empty;
            deviceID = (instance.Properties["DeviceID"].Value != null)
                           ? instance.Properties["DeviceID"].Value.ToString().Trim()
                           : string.Empty;
        }

        private Disk(string manufacturar, string model, string description, string interfacetype, string size,
                     string partitions, string scsibus, string scsitarget, string deviceID)
        {
            manufacturer = manufacturar;
            this.model = model;
            this.description = description;
            interfaceType = interfacetype;
            this.size = size;
            this.partitions = partitions;
            scsiBus = scsibus;
            scsiTargetID = scsitarget;
            this.deviceID = deviceID;
        }

        public override string ToString()
        {
            return description;
        }

        [Category("Disk Drive Information")]
        [XmlElement()]
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string InterfaceType
        {
            get { return interfaceType; }
            set { interfaceType = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string Partitions
        {
            get { return partitions; }
            set { partitions = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string ScsiBus
        {
            get { return scsiBus; }
            set { scsiBus = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElementAttribute()]
        public string ScsiTargetID
        {
            get { return scsiTargetID; }
            set { scsiTargetID = value; }
        }

        [Category("Disk Drive Information")]
        [XmlElement()]
        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public class DiskConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is Disk))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new Disk((string) propertyValues["Disk_Manufacturer"],
                             (string) propertyValues["Disk_Model"], (string) propertyValues["Description"],
                             (string) propertyValues["Disk_InterfaceType"],
                             (string) propertyValues["Size"], (string) propertyValues["Disk_Partitions"],
                             (string) propertyValues["Disk_ScsiBus"],
                             (string) propertyValues["Disk_ScsiTargetID"],
                             (string) propertyValues["Disk_DeviceID"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }
    }
}