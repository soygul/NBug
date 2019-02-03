// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System.ComponentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace NBug.Core.Reporting.SystemInfo
{
    public enum QueryArea
    {
        [Description("Win32_ComputerSystem")] WMI_COMPUTER_INFORMATION,
        [Description("Win32_Processor")] WMI_PROCESSOR_INFORMATION,
        [Description("Win32_BIOS")] WMI_BIOS_INFORMATION,
        [Description("Win32_OperatingSystem")] WMI_OS_INFORMATION,
        [Description("Win32_QuickFixEngineering")] WMI_HOTFIX_INFORMATION,
        [Description("Win32_NetworkAdapterConfiguration")] WMI_NETWORK_ADAPTER_INFORMATION,
        [Description("Win32_Printer")] WMI_PRINTER_INFORMATION,
        [Description("Win32_DiskDrive")] WMI_DISK_DRIVE_INFORMATION,
        [Description("Win32_LogicalDisk")] WMI_LOGICAL_DISK_INFORMATION,
        [Description("Win32_VideoController")] WMI_VIDEO_CONTROLLER_INFORMATION,
        [Description("Win32_SoundDevice")] WMI_SOUND_CARD_INFORMATION
    }

    public enum QueryAreaDescription
    {
        [Description("WMI_COMPUTER_INFORMATION")]  Win32_ComputerSystem,
        [Description("WMI_PROCESSOR_INFORMATION")]  Win32_Processor,
        [Description("WMI_BIOS_INFORMATION")]  Win32_BIOS,
        [Description("WMI_OS_INFORMATION")]  Win32_OperatingSystem,
        [Description("WMI_HOTFIX_INFORMATION")]  Win32_QuickFixEngineering,
        [Description("WMI_NETWORK_ADAPTER_INFORMATION")]  Win32_NetworkAdapterConfiguration,
        [Description("WMI_PRINTER_INFORMATION")]  Win32_Printer,
        [Description("WMI_DISK_DRIVE_INFORMATION")]  Win32_DiskDrive,
        [Description("WMI_LOGICAL_DISK_INFORMATION")]  Win32_LogicalDisk,
        [Description("WMI_VIDEO_CONTROLLER_INFORMATION")]  Win32_VideoController,
        [Description("WMI_SOUND_CARD_INFORMATION")]  Win32_SoundDevice
    }

}