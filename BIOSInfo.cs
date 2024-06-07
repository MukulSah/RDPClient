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
    class BIOSInfo
    {
        enum BiosChractersticsValues
        {
            [Description("Reserved")]
            Reserved = 0,
            [Description("Unknown")]
            Unknown = 2,
            [Description("BIOS Characteristics Not Supported")]
            BIOSCharacteristicsNotSupported = 3,
            [Description("ISA is supported")]
            ISAissupported = 4,
            [Description("MCA is supported")]
            MCAissupported = 5,
            [Description("EISA is supported")]
            EISAissupported = 6,
            [Description("PCI is supported")]
            PCIissupported = 7,
            [Description("PC Card(PCMCIA) is supported")]
            PCCardPCMCIAissupported = 8,
            [Description("Plug and Play is supported")]
            PlugandPlayissupported = 9,
            [Description("APM is supported")]
            APMissupported = 10,
            [Description("BIOS is Upgradeable(Flash)")]
            BIOSisUpgradeableFlash = 11,
            [Description("BIOS shadowing is allowed")]
            BIOSshadowingisallowed = 12,
            [Description("VL-VESA is supported")]
            VLVESAissupported = 13,
            [Description("ESCD support is available")]
            ESCDsupportisavailable = 14,
            [Description("Boot from CD is supported")]
            BootfromCDissupported = 15,
            [Description("Selectable Boot is supported")]
            SelectableBootissupported = 16,
            [Description("BIOS ROM is socketed")]
            BIOSROMissocketed = 17,
            [Description("Boot From PC Card(PCMCIA) is supported")]
            BootFromPCCardPCMCIAissupported = 18,
            [Description("EDD(Enhanced Disk Drive) Specification is supported")]
            EDDEnhancedDiskDriveSpecificationissupported =19,
            [Description(" Int 13h - Japanese Floppy for NEC 9800 1.2mb(3.5\", 1k Bytes/Sector, 360 RPM) is supported")]
            Int13hJapaneseFloppyforNEC9800 = 20,
            [Description("Int 13h - Japanese Floppy for Toshiba 1.2mb(3.5\", 360 RPM) is supported")]
            Int13hJapaneseFloppyforToshiba = 21,
            [Description("Int 13h - 5.25\" / 360 KB Floppy Services are supported")]
            Int25360KBFloppyServicesaresupported = 22,
            [Description("Int 13h - 5.25\" /1.2MB Floppy Services are supported")]
            Int13h52512MBFloppyServicesaresupported = 23,
            [Description("Int 13h - 3.5\" / 720 KB Floppy Services are supported")]
            Int720KBFloppyServicesaresupported =24,
            [Description("Int 13h - 3.5\" / 2.88 MB Floppy Services are supported")]      
            Int288MBFloppyServicesaresupported =25,
            [Description("Int 5h, Print Screen Service is supported")]
            Int5hPrintScreenServiceissupported =26,
            [Description("Int 9h, 8042 Keyboard services are supported")]
            Int9h8042Keyboardservicesaresupported =27,
            [Description("Int 14h, Serial Services are supported")]
            Int14hSerialServicesaresupported = 28,
            [Description("Int 17h, printer services are supported")]
            Int17hprinterservicesaresupported = 29,
            [Description("Int 10h, CGA/Mono Video Services are supported")]
            Int10hCGAMonoVideoServicesaresupported = 30,
            [Description("NEC PC-98")]
            NECPC98 = 31,
            [Description("ACPI supported")]
            ACPIsupported =32,
            [Description("USB Legacy is supported")]     
            USBLegacyissupported = 33,
            [Description("AGP is supported")]
            AGPissupported = 34,
            [Description("I2O boot is supported")]
            I2Obootissupported =35,
            [Description("LS-120 boot is supported")]
            LS120bootissupported = 36,
            [Description("ATAPI ZIP Drive boot is supported")]
            ATAPIZIPDrivebootissupported = 37,
            [Description("1394 boot is supported")]
            boot1394issupported = 38,
            [Description("Smart Battery supported")]
            SmartBatterysupported = 39,
            [Description("Reserved for BIOS vendor")]
            ReservedforBIOSvendor = 40,
            [Description("Reserved for BIOS vendor")]
            ReservedBIOSvendor = 47,
            [Description("Reserved for system vendor")]
            Reservedforsystemvendor = 48,
            [Description("Reserved for system vendor")]
            Reservedsystemvendor = 63,

        }

        enum SoftwareElementStateValues
        {
            [Description("Deployable")]
            Deployable = 0,
            [Description("Installable")]
            Installable = 1,
            [Description("Executable")]
            Executable = 2,
            [Description("Running")]
            Running = 3
        }
        enum TargetOperatingSystemValues
        {
            [Description("Unknown")]
            Unknown = 0,
            [Description("Other")]
            Other = 1,
            [Description("MACOS")]
            MACOS = 2,
            [Description("ATTUNIX")]

            ATTUNIX = 3,
            [Description("DGUX")]

            DGUX = 4,
            [Description("DECNT")]

            DECNT = 5,
            [Description("Digital Unix")]

            DigitalUnix = 6,
            [Description("OpenVMS")]

            OpenVMS = 7,
            [Description("HPUX")]

            HPUX = 8,
            [Description("AIX")]

            AIX = 9,
            [Description("MVS")]

            MVS = 10,
            [Description("OS400")]

            OS400 = 11,
            [Description("OS/2")]

            OS2 = 12,
            [Description("JavaVM")]

            JavaVM = 13,
            [Description("MSDOS")]

            MSDOS = 14,
            [Description("WIN3x")]

            WIN3x = 15,
            [Description("WIN95")]

            WIN95 = 16,
            [Description("WIN98")]

            WIN98 = 17,
            [Description("WINNT")]

            WINNT = 18,
            [Description("WINCE")]

            WINCE = 19,
            [Description("NCR3000")]

            NCR3000 = 20,
            [Description("NetWare")]

            NetWare = 21,
            [Description("OSF")]

            OSF = 22,
            [Description("DC/OS")]

            DCOS = 23,
            [Description("Reliant UNIX")]

            ReliantUNIX = 24,
            [Description("SCO UnixWare")]

            SCOUnixWare = 25,
            [Description("SCO OpenServer")]

            SCOOpenServer = 26,
            [Description("Sequent")]

            Sequent = 27,
            [Description("IRIX")]

            IRIX = 28,
            [Description("Solaris")]

            Solaris = 29,
            [Description("SunOS")]

            SunOS = 30,
            [Description("U6000")]

            U6000 = 31,
            [Description("ASERIES")]

            ASERIES = 32,
            [Description("TandemNSK")]

            TandemNSK = 33,
            [Description("TandemNT")]

            TandemNT = 34,
            [Description("BS2000")]

            BS2000 = 35,
            [Description("LINUX")]

            LINUX = 36,
            [Description("Lynx")]

            Lynx = 37,
            [Description("XENIX")]

            XENIX = 38,
            [Description("VM/ESA")]

            VMESA = 39,
            [Description("Interactive UNIX")]

            InteractiveUNIX = 40,
            [Description("BSDUNIX")]

            BSDUNIX = 41,
            [Description("FreeBSD")]

            FreeBSD = 42,
            [Description("NetBSD")]

            NetBSD = 43,
            [Description("GNU Hurd")]

            GNUHurd = 44,
            [Description("OS9")]

            OS9 = 45,

            [Description("MACH Kernel")]
            MACHKernel = 46,
            [Description("Inferno")]

            Inferno = 47,
            [Description("QNX")]

            QNX = 48,
            [Description("EPOC")]

            EPOC = 49,
            [Description("IxWorks")]

            IxWorks = 50,
            [Description("VxWorks")]

            VxWorks = 51,
            [Description("MiNT")]

            MiNT = 52,

            [Description("BeOS")]
            BeOS = 53,
            [Description("HP MPE")]

            HPMPE = 54,
            [Description("NextStep")]

            NextStep = 55,
            [Description("PalmPilot")]

            PalmPilot = 56,
            [Description("Rhapsody")]

            Rhapsody = 57,
            [Description("Windows 2000")]

            Windows2000 = 58,
            [Description("Dedicated")]

            Dedicated = 59,
            [Description("VSE")]

            VSE = 60,
            [Description("TPF")]
            TPF = 61
        }

        public List<string> BiosCharactersticsList { get; set; } = new List<string>();
        public List<String> BiosVersion { get; set; } = new List<String>();
        public string BuildNumber { get; set; }
        public string Caption { get; set; }
        public string CodeSet { get; set; }
        public string CurrentLanguage { get; set; }
        public string Description { get; set; }
        public string EmbeddedControllerMajorVersion { get; set; }
        public string EmbeddedControllerMinorVersion { get; set; }
        public string IdentificationCode { get; set; }
        public string InstallableLanguages { get; set; }
        public string InstallDate { get; set; }
        public string LanguageEdition { get; set; }
        public List<String> ListOfLanguages { get; set; } = new List<String>();
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string OtherTargetOS { get; set; }
        public string PrimaryBIOS { get; set; }
        public string ReleaseDate { get; set; }
        public string SerialNumber { get; set; }
        public string SMBIOSBIOSVersion { get; set; }
        public string SMBIOSMajorVersion { get; set; }
        public string SMBIOSMinorVersion { get; set; }
        public string SMBIOSPresent { get; set; }
        public string SoftwareElementID { get; set; }
        public string SoftwareElementState { get; set; }
        public string Status { get; set; }
        public string SystemBiosMajorVersion { get; set; }
        public string SystemBiosMinorVersion { get; private set; }
        public string TargetOperatingSystem { get; private set; }
        public BIOSInfo ReadBIOSDetails()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                if (mo["BiosCharacteristics"] as UInt16[] != null)
                {
                    GetBiosCharacterstics(mo["BiosCharacteristics"] as UInt16[]);
                }
                if (mo["BIOSVersion"] != null)
                {
                   //this.BiosVersion = (List<String>)mo["BIOSVersion"];
                }

                this.BuildNumber = mo["BuildNumber"] == null ? "" : mo["BuildNumber"].ToString();
                this.Caption = mo["Caption"] == null ? "" : mo["Caption"].ToString();
                this.CodeSet = mo["CodeSet"] == null ? "" : mo["CodeSet"].ToString();
                this.CurrentLanguage = mo["CurrentLanguage"] == null ? "" : mo["CurrentLanguage"].ToString();
                this.Description = mo["Description"] == null ? "" : mo["Description"].ToString();
                this.EmbeddedControllerMajorVersion = mo["EmbeddedControllerMajorVersion"] == null ? "" : mo["EmbeddedControllerMajorVersion"].ToString();
                this.EmbeddedControllerMinorVersion = mo["EmbeddedControllerMinorVersion"] == null ? "" : mo["EmbeddedControllerMinorVersion"].ToString();
                this.IdentificationCode = mo["IdentificationCode"] == null ? "" : mo["IdentificationCode"].ToString();
                this.InstallableLanguages = mo["InstallableLanguages"] == null ? "" : mo["InstallableLanguages"].ToString();
                this.InstallDate = mo["InstallDate"] == null ? "" : mo["InstallDate"].ToString();
                this.LanguageEdition = mo["LanguageEdition"] == null ? "" : mo["LanguageEdition"].ToString();
                if (mo["ListOfLanguages"] != null)
                {
                    //this.ListOfLanguages = (List<String>)mo["ListOfLanguages"];
                }
                this.Manufacturer = mo["Manufacturer"] == null ? "" : mo["Manufacturer"].ToString();
                this.Name = mo["Name"] == null ? "" : mo["Name"].ToString();
                this.OtherTargetOS = mo["OtherTargetOS"] == null ? "" : mo["OtherTargetOS"].ToString();
                this.PrimaryBIOS = mo["PrimaryBIOS"] == null ? "" : mo["PrimaryBIOS"].ToString();
                this.ReleaseDate = mo["ReleaseDate"] == null ? "" : mo["ReleaseDate"].ToString();
                this.SerialNumber = mo["SerialNumber"] == null ? "" : mo["SerialNumber"].ToString();
                this.SMBIOSBIOSVersion = mo["SMBIOSBIOSVersion"] == null ? "" : mo["SMBIOSBIOSVersion"].ToString();
                this.SMBIOSMajorVersion = mo["SMBIOSMajorVersion"] == null ? "" : mo["SMBIOSMajorVersion"].ToString();
                this.SMBIOSMinorVersion = mo["SMBIOSMinorVersion"] == null ? "" : mo["SMBIOSMinorVersion"].ToString();
                this.SMBIOSPresent = mo["SMBIOSPresent"] == null ? "" : mo["SMBIOSPresent"].ToString();
                this.SoftwareElementID = mo["SoftwareElementID"] == null ? "" : mo["SoftwareElementID"].ToString();
                this.SoftwareElementState = mo["SoftwareElementState"] == null ? "" : GetEnumDescription((SoftwareElementStateValues)Convert.ToInt32(mo["SoftwareElementState"]));
                this.Status = mo["Status"] == null ? "" : mo["Status"].ToString();
                this.SystemBiosMajorVersion = mo["SystemBiosMajorVersion"] == null ? "" : mo["SystemBiosMajorVersion"].ToString();
                this.SystemBiosMinorVersion = mo["SystemBiosMinorVersion"] == null ? "" : mo["SystemBiosMinorVersion"].ToString();
                this.TargetOperatingSystem = mo["TargetOperatingSystem"] == null ? "" : GetEnumDescription((TargetOperatingSystemValues)Convert.ToInt32(mo["TargetOperatingSystem"]));


                foreach (PropertyData property in mo.Properties)
                {
                    Console.WriteLine(property.Name + " - " + property.Value);

                }
            }
            return this;
        }
        private string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
           if(value == null)
           {
                return "";
           }
           FieldInfo fi = value.GetType().GetField(value.ToString());
           DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), true);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();          
            
        }
        private void GetBiosCharacterstics(UInt16[] biosCharcter)
        {
            foreach (UInt16 value in biosCharcter)
            {
                string characterstic;
                if (value >= 40 && value <= 47)
                {
                    characterstic = GetEnumDescription((BiosChractersticsValues)40);
                }
                else if (value >= 48 && value <= 63)
                {
                    characterstic = GetEnumDescription((BiosChractersticsValues)48);
                }
                else
                {
                    characterstic = GetEnumDescription((BiosChractersticsValues)Convert.ToInt32(value));
                }
                if (characterstic.Equals(""))
                {
                    continue;
                }
                Console.WriteLine(characterstic);
                this.BiosCharactersticsList.Add(characterstic);
            }
        }
    }
}
