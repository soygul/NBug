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
    public class LogicalDisk
    {
        #region Private Fields

        private string name;
        private string description;
        private string volumeName;
        private string fileSystem;
        private string size;
        private string freeSpace;
        private string volumeSerialNumber;

        #endregion

        #region Constructor

        public LogicalDisk()
        {
        }

        public LogicalDisk(ManagementObject instance)
        {
            name = (instance.Properties["Name"].Value != null)
                       ? instance.Properties["Name"].Value.ToString().Trim()
                       : string.Empty;
            description = (instance.Properties["Description"].Value != null)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            volumeName = (instance.Properties["VolumeName"].Value != null)
                             ? instance.Properties["VolumeName"].Value.ToString().Trim()
                             : string.Empty;
            fileSystem = (instance.Properties["FileSystem"].Value != null)
                             ? instance.Properties["FileSystem"].Value.ToString().Trim()
                             : string.Empty;
            size = (instance.Properties["Size"].Value != null)
                       ? instance.Properties["Size"].Value.ToString().Trim()
                       : string.Empty;
            freeSpace = (instance.Properties["FreeSpace"].Value != null)
                            ? instance.Properties["FreeSpace"].Value.ToString().Trim()
                            : string.Empty;
            volumeSerialNumber = (instance.Properties["VolumeSerialNumber"].Value != null)
                                     ? instance.Properties["VolumeSerialNumber"].Value.ToString().Trim()
                                     : string.Empty;
        }

        private LogicalDisk(string name, string description, string volumename, string filesystem, string size,
                            string freespace, string serial)
        {
            this.name = name;
            this.description = description;
            volumeName = volumename;
            fileSystem = filesystem;
            this.size = size;
            freeSpace = freespace;
            volumeSerialNumber = serial;
        }

        #endregion

        #region Override

        public override string ToString()
        {
            return name;
        }

        #endregion

        #region Public Property

        [Category("Logical LogicalDisk Information")]
        [XmlElement()]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElementAttribute()]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElementAttribute()]
        public string VolumeName
        {
            get { return volumeName; }
            set { volumeName = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElementAttribute()]
        public string FileSystem
        {
            get { return fileSystem; }
            set { fileSystem = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElement()]
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElementAttribute()]
        public string FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }

        [Category("Logical LogicalDisk Information")]
        [XmlElementAttribute()]
        public string VolumeSerialNumber
        {
            get { return volumeSerialNumber; }
            set { volumeSerialNumber = value; }
        }

        #endregion

        #region Converters

        public class DiskConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is LogicalDisk))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new LogicalDisk((string) propertyValues["name"],
                                    (string) propertyValues["description"],
                                    (string) propertyValues["volumeName"],
                                    (string) propertyValues["fileSystem"],
                                    (string) propertyValues["size"],
                                    (string) propertyValues["freeSpace"],
                                    (string) propertyValues["volumeSerialNumber"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }

        #endregion
    }
}