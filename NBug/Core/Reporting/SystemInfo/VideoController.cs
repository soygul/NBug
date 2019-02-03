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
    [TypeConverter(typeof (VideoControllerConverter))]
    [ReadOnly(true)]
    [Serializable]
    public class VideoController
    {
        private string description;
        private string currentHorizontalResolution;
        private string currentVerticalResolution;
        private string currentNumberOfColors;
        private string videoProcessor;
        private string adapterRAM;
        private string installedDisplayDrivers;
        private string driverVersion;

        public VideoController()
        {
        }

        public VideoController(ManagementObject instance)
        {
            description = (instance.Properties["Description"].Value != null)
                              ? instance.Properties["Description"].Value.ToString().Trim()
                              : string.Empty;
            currentHorizontalResolution = (instance.Properties["CurrentHorizontalResolution"].Value !=
                                           null)
                                              ?
                                          instance.Properties["CurrentHorizontalResolution"].Value.
                                              ToString().Trim()
                                              : string.Empty;
            currentVerticalResolution = (instance.Properties["CurrentVerticalResolution"].Value != null)
                                            ?
                                        instance.Properties["CurrentVerticalResolution"].Value.ToString().
                                            Trim()
                                            : string.Empty;
            currentNumberOfColors = (instance.Properties["CurrentNumberOfColors"].Value != null)
                                        ?
                                    instance.Properties["CurrentNumberOfColors"].Value.ToString().Trim()
                                        : string.Empty;
            videoProcessor = (instance.Properties["VideoProcessor"].Value != null)
                                 ? instance.Properties["VideoProcessor"].Value.ToString().Trim()
                                 : string.Empty;
            adapterRAM = (instance.Properties["AdapterRAM"].Value != null)
                             ? instance.Properties["AdapterRAM"].Value.ToString().Trim()
                             : string.Empty;
            installedDisplayDrivers = (instance.Properties["InstalledDisplayDrivers"].Value != null)
                                          ?
                                      instance.Properties["InstalledDisplayDrivers"].Value.ToString().Trim
                                          ()
                                          : string.Empty;
            driverVersion = (instance.Properties["DriverVersion"].Value != null)
                                ? instance.Properties["DriverVersion"].Value.ToString().Trim()
                                : string.Empty;
        }

        private VideoController(string description, string chr, string cvr, string cnc, string vp, string ram,
                                string idd, string driverVersion)
        {
            this.description = description;
            currentHorizontalResolution = chr;
            currentVerticalResolution = cvr;
            currentNumberOfColors = cnc;
            videoProcessor = vp;
            adapterRAM = ram;
            installedDisplayDrivers = idd;
            this.driverVersion = driverVersion;
        }

        public override string ToString()
        {
            return description;
        }

        [Category("Video Controller Information")]
        [XmlElement()]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string CurrentHorizontalResolution
        {
            get { return currentHorizontalResolution; }
            set { currentHorizontalResolution = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string CurrentVerticalResolution
        {
            get { return currentVerticalResolution; }
            set { currentVerticalResolution = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string CurrentNumberOfColors
        {
            get { return currentNumberOfColors; }
            set { currentNumberOfColors = value; }
        }

        [Category("Video Controller Information")]
        [XmlElement()]
        public string VideoProcessor
        {
            get { return videoProcessor; }
            set { videoProcessor = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string AdapterRAM
        {
            get { return adapterRAM; }
            set { adapterRAM = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string InstalledDisplayDrivers
        {
            get { return installedDisplayDrivers; }
            set { installedDisplayDrivers = value; }
        }

        [Category("Video Controller Information")]
        [XmlElementAttribute()]
        public string DriverVersion
        {
            get { return driverVersion; }
            set { driverVersion = value; }
        }

        public class VideoControllerConverter : ExpandableObjectConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                                             Type destinationType)
            {
                if (destinationType != typeof (string) || !(value is VideoController))
                {
                    return base.ConvertTo(context, culture, value, destinationType);
                }
                return value.ToString().Trim();
            }

            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
            {
                return
                    new VideoController((string) propertyValues["Card_Description"],
                                        (string) propertyValues["Card_CurrentHorizontalResolution"],
                                        (string) propertyValues["Card_CurrentVerticalResolution"],
                                        (string) propertyValues["Card_CurrentNumberOfColors"],
                                        (string) propertyValues["Card_VideoProcessor"],
                                        (string) propertyValues["Card_AdapterRAM"],
                                        (string) propertyValues["VideoCard_InstalledDisplayDrivers"],
                                        (string) propertyValues["VideoCard_DriverVersion"]);
            }

            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }
    }
}