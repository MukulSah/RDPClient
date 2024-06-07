using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;

namespace RDPClientApplication
{
    class ProcessorInfo
    {
        enum ArchitechureValues
        {
            x86 = 0,
            MIPS = 1,
            Alpha = 2,
            PowerPC = 3,
            ARM = 5,
            ia64 = 6,
            x64 = 9,
            ARM64 = 12
        }

        enum AvailaibilityValues
        {
            Other = 1,
            Unknown= 2,
            RunningFullPower= 3,
            Warning = 4,
            InTest = 5,
            NotApplicable =6,
            PowerOff = 7 ,
            OffLine =8,
            OffDuty = 9,
            Degraded = 10,
            NotInstalled = 11 ,
            InstallError=12,
            PowerSaveUnknown =13,
            PowerSaveLowPowerMode = 14,
            PowerSaveStandby = 15,
            PowerCycle =16,
            PowerSaveWarning=17,
            Paused = 18,
            NotReady = 19,
            NotConfigured = 20,
            Quiesced = 21
        }

        enum CPUStatusValues
        {
            [Description("Unknown")]
            Unknown = 0,
            [Description("CPU Enabled")]
            CPUEnabled = 1,
            [Description("CPU Disabled by User via BIOS Setup")]
            CPUDisabledbyUserviaBIOSSetup =2 ,
            [Description("CPU Disabled By BIOS(POST Error)")]
            CPUDisabledByBIOSPOSTError = 3,
            [Description("CPU is Idle")]
            CPUisIdle = 4 ,
            [Description("Reserved")]
            Reserved = 5 ,
            [Description("Other")]
            Other = 7
        }

        enum ProcessorTypesValues
        {
            [Description("Other")]
            Other = 1,
            [Description("Unknown")]
            Unknown = 2,
            [Display(Name = "Central Processor")]
            CentralProcessor=3,
            [Display(Name = "Math Processor")]
            MathProcessor=4,
            [Display(Name = "DSP Processor")]
            DSPProcessor=5,
            [Display(Name = "Video Processor")]
            VideoProcessor=6,
        }

    
        public string AddressWidth { get; set; }
        public string Architechure { get; set; }
        public string AssetTag { get; set; }
        public string Availability { get; set; }
        public string Caption { get; set; }
        public string CPUStatus { get; set; }
        public string CurrentClockSpeed { get; set; }

        public string DeviceID { get; set; }
        public string CurrentVoltage { get; set; }

        public string InstallDate { get; set; }

        public string L2CacheSize { get; set; }

        public string L2CacheSpeed { get; set; }
        public string L3CacheSize { get; set; }
        public string L3CacheSpeed { get; set; }

        public string Manufacturer { get; set; }
        public string MaxClockSpeed { get; set; }
        public string Name { get; set; }
        public string NumberOfCores { get; set; }
        public string NumberOfEnabledCore { get; set; }
        public string NumberOfLogicalProcessors { get; set; }
        public string ProcessorId { get; set; }

        public string ProcessorType { get; set; }
        public ProcessorInfo ReadProcessorDetails()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                this.AddressWidth = mo["AddressWidth"].ToString() == null ? "": mo["AddressWidth"].ToString() + " bit";

                
                this.Architechure = ((ArchitechureValues)Convert.ToInt32(mo["Architecture"])).ToString();
                
                this.AssetTag = mo["AssetTag"].ToString()==null ? "" : mo["AssetTag"].ToString();

                this.Availability = ((AvailaibilityValues)Convert.ToInt32(mo["Availability"])).ToString();

                this.Caption = (string)mo["Caption"];

                this.CPUStatus= GetEnumDescription((CPUStatusValues)Convert.ToInt32(mo["CpuStatus"])); 

                this.CurrentClockSpeed = mo["CurrentClockSpeed"].ToString() == null ? "" : mo["CurrentClockSpeed"].ToString() + " MHz";

                this.CurrentVoltage = mo["CurrentVoltage"].ToString()==null ? "" : mo["CurrentVoltage"].ToString() + " volts";

                this.DeviceID = mo["DeviceID"].ToString();
                this.InstallDate = mo["InstallDate"] == null ? "" : mo["InstallDate"].ToString();
                this.L2CacheSize = mo["L2CacheSize"].ToString() == null ? "": mo["L2CacheSize"].ToString() + " kilobytes";
                this.L2CacheSpeed = mo["L2CacheSpeed"]==null?"": mo["L2CacheSpeed"].ToString() + " megahertz";
                this.L3CacheSize = mo["L3CacheSize"] == null?"" : mo["L3CacheSize"].ToString() + " kilobytes";
                this.L3CacheSpeed = mo["L3CacheSpeed"]==null?"": mo["L3CacheSpeed"].ToString() + " megahertz";
                this.Manufacturer = mo["Manufacturer"].ToString()==null?"" : mo["Manufacturer"].ToString();
                this.MaxClockSpeed = mo["MaxClockSpeed"].ToString() ==null?"": mo["MaxClockSpeed"].ToString();
                this.Name = mo["Name"] == null ? "": mo["Name"].ToString();
                this.NumberOfCores = mo["NumberOfCores"] == null ?"": mo["NumberOfCores"].ToString();
                this.NumberOfEnabledCore = mo["NumberOfEnabledCore"].ToString() == null ? "" : mo["NumberOfEnabledCore"].ToString();
                this.NumberOfLogicalProcessors = mo["NumberOfLogicalProcessors"].ToString() == null ? 
                "":mo["NumberOfLogicalProcessors"].ToString();
                this.ProcessorId = mo["ProcessorId"] ==null ? "": mo["ProcessorId"].ToString();

                this.ProcessorType = GetEnumDescription((ProcessorTypesValues)Convert.ToInt32(mo["ProcessorType"])); //((ProcessorTypesValues)Convert.ToInt32(mo["ProcessorType"])).ToString();

                Console.WriteLine(this.AddressWidth);
                Console.WriteLine(this.Architechure);
                Console.WriteLine(this.AssetTag);
                Console.WriteLine(this.Availability);
                Console.WriteLine(this.Caption);
                Console.WriteLine(this.CPUStatus);
                Console.WriteLine(this.CurrentClockSpeed);
                Console.WriteLine(this.DeviceID);
                Console.WriteLine(this.InstallDate);
                Console.WriteLine(this.L2CacheSize);
                Console.WriteLine(this.L2CacheSpeed);
                Console.WriteLine(this.L3CacheSize);
                Console.WriteLine(this.L3CacheSpeed);
                Console.WriteLine(this.Manufacturer);
                Console.WriteLine(this.MaxClockSpeed);
                Console.WriteLine(this.NumberOfCores);
                Console.WriteLine(this.NumberOfEnabledCore);
                Console.WriteLine(this.NumberOfLogicalProcessors);
                Console.WriteLine(this.ProcessorId);
                Console.WriteLine(this.ProcessorType);
                
               
            }
            return this;
        }
        private string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), true);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
