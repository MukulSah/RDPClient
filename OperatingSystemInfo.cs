using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;

namespace RDPClientApplication
{
    class OperatingSystemInfo
    {
        enum DataExecutionPrevention_SupportPolicyValues
        {
            [Description("Always Off")]
            AlwaysOff = 0,
            [Description("Always On")]
            AlwaysOn = 1,
            [Description("Opt In")]
            OptIn = 2,
            [Description("Opt Out")]
            OptOut = 3
        }
        enum EncryptionLevelValues
        {
            [Description("40-bit")]
            A = 0,
            [Description("128-bit")]
            B = 1,
            [Description("n-bit")]
            C = 2
        }

        enum ForegroundApplicationBoostValues
        {
            [Description("None")]
            None = 0,
            [Description("Minimum")]
            Minimum = 1,
            [Description("Maximum ")]
            Maximum = 2
        }
        enum LargeSystemCacheValues
        {
            [Description("Optimize for Applications")]
            OptimizeforApplications = 0,
            [Description("Optimize for System Performance")]
            OptimizeforSystemPerformance = 1,


        }

        enum ProductTypeValues
        {
            [Description("Work Station")]
            WorkStation = 1,
            [Description("Domain Controller ")]
            DomainController = 2,
            [Description("Server ")]
            Server = 3
        }
        enum OSTypeValues
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
            [Description("OS/390")]

            OS390 = 60,
            [Description("VSE")]

            VSE = 61,
            [Description("TPF")]
            TPF = 62
        }

        enum OSLanguageValues
        {
            [Description("Arabic")]
            x01 = 1,
            [Description("Chinese (Simplified)– China")]
            x4 = 4,
            [Description("English")]
            x9 = 9,
            [Description("Arabic – Saudi Arabia")]
            x401 = 1025,
            [Description("Bulgarian")]
            x402 = 1026,
            [Description("Catalan")]
            x403 = 1027,
            [Description("Chinese (Traditional) – Taiwan")]
            x404 = 1028,
            [Description("Czech")]
            x405 = 1029,
            [Description("Danish")]
            x406 = 1030,
            [Description("German – Germany")]
            x407 = 1031,
            [Description("Greek")]
            x408 = 1032,
            [Description("English – United States")]
            x409 = 1033,
            [Description("Finnish")]
            x40B = 1035,
            [Description("French – France")]
            x40C = 1036,
            [Description("Hebrew")]
            x40D = 1037,
            [Description("Hungarian")]
            x40E = 1038,
            [Description("Icelandic")]
            x40F = 1039,
            [Description("Italian – Italy")]

            x410 = 1040,
            [Description("Japanese")]

            x411 = 1041,
            [Description("Korean")]

            x412 = 1042,
            [Description("Dutch – Netherlands")]

            x413 = 1043,
            [Description("Norwegian – Bokmal")]

            x414 = 1044,
            [Description("Polish")]
            x415
                        = 1045,
            [Description("Portuguese – Brazil")]

            x416 = 1046,
            [Description("Rhaeto-Romanic")]

            x417 = 1047,
            [Description("Romanian")]

            x418 = 1048,
            [Description("Russian")]

            x41A = 1050,




        }

        public string BootDevice { get; private set; }
        public string BuildNumber { get; private set; }
        public string BuildType { get; private set; }
        public string Caption { get; private set; }
        public string CodeSet { get; private set; }
        public string CountryCode { get; private set; }
        public string CSCreationClassName { get; private set; }
        public string CSDVersion { get; private set; }
        public string CSName { get; private set; }
        public string CurrentTimeZone { get; private set; }
        public string DataExecutionPrevention_32BitApplications { get; private set; }
        public string DataExecutionPrevention_Available { get; private set; }
        public string DataExecutionPrevention_Drivers { get; private set; }
        public string DataExecutionPrevention_SupportPolicy { get; private set; }
        public string Debug { get; private set; }
        public string Description { get; private set; }
        public string Distributed { get; private set; }
        public string EncryptionLevel { get; private set; }
        public string ForegroundApplicationBoost { get; private set; }
        public string FreePhysicalMemory { get; private set; }
        public string FreeSpaceInPagingFiles { get; private set; }
        public string FreeVirtualMemory { get; private set; }
        public string InstallDate { get; private set; }
        public string LargeSystemCache { get; private set; }
        public string LastBootUpTime { get; private set; }
        public string LocalDateTime { get; private set; }
        public string Locale { get; private set; }
        public string Manufacturer { get; private set; }
        public string MaxNumberOfProcesses { get; private set; }
        public string MaxProcessMemorySize { get; private set; }
        public string MUILanguages { get; private set; }
        public string Name { get; private set; }
        public string NumberOfLicensedUsers { get; private set; }
        public string NumberOfProcesses { get; private set; }
        public string NumberOfUsers { get; private set; }
        public object OperatingSystemSKU { get; private set; }
        public string Organization { get; private set; }
        public string OSArchitecture { get; private set; }
        public string OSLanguage { get; private set; }
        public string OSProductSuite { get; private set; }
        public string OSType { get; private set; }
        public string PAEEnabled { get; private set; }
        public string PlusProductID { get; private set; }
        public string PlusVersionNumber { get; private set; }
        public string PortableOperatingSystem { get; private set; }
        public string Primary { get; private set; }
        public string ProductType { get; private set; }
        public string SerialNumber { get; private set; }
        public string ServicePackMajorVersion { get; private set; }
        public string ServicePackMinorVersion { get; private set; }
        public string SizeStoredInPagingFiles { get; private set; }
        public string Status { get; private set; }
        public string SystemDevice { get; private set; }
        public string SystemDrive { get; private set; }
        public string TotalSwapSpaceSize { get; private set; }
        public string TotalVirtualMemorySize { get; private set; }
        public string TotalVisibleMemorySize { get; private set; }
        public string Version { get; private set; }
        public string WindowsDirectory { get; private set; }

        public OperatingSystemInfo ReadRAMDetails()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem ");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                this.BootDevice = mo["BootDevice"] == null ? "" : mo["BootDevice"].ToString();
                this.BuildNumber = mo["BuildNumber"] == null ? "" : mo["BuildNumber"].ToString();
                this.BuildType = mo["BuildType"] == null ? "" : mo["BuildType"].ToString();
                this.Caption = mo["Caption"] == null ? "" : mo["Caption"].ToString();
                this.CodeSet = mo["CodeSet"] == null ? "" : mo["CodeSet"].ToString();
                this.CountryCode = mo["CountryCode"] == null ? "" : mo["CountryCode"].ToString();
                this.CSCreationClassName = mo["CSCreationClassName"] == null ? "" : mo["CSCreationClassName"].ToString();
                this.CSDVersion = mo["CSDVersion"] == null ? "" : mo["CSDVersion"].ToString();
                this.CSName = mo["CSName"] == null ? "" : mo["CSName"].ToString();
                this.CurrentTimeZone = mo["CurrentTimeZone"] == null ? "" : mo["CurrentTimeZone"].ToString();
                this.DataExecutionPrevention_32BitApplications = mo["DataExecutionPrevention_32BitApplications"] == null ? "" : mo["DataExecutionPrevention_32BitApplications"].ToString();
                this.DataExecutionPrevention_Available = mo["DataExecutionPrevention_Available"] == null ? "" : mo["DataExecutionPrevention_Available"].ToString();
                this.DataExecutionPrevention_Drivers = mo["DataExecutionPrevention_Drivers"] == null ? "" : mo["DataExecutionPrevention_Drivers"].ToString();
                this.DataExecutionPrevention_SupportPolicy = mo["DataExecutionPrevention_SupportPolicy"] == null ? "" : GetEnumDescription((DataExecutionPrevention_SupportPolicyValues)Convert.ToInt32(mo["DataExecutionPrevention_SupportPolicy"]));
                this.Debug = mo["Debug"] == null ? "" : mo["Debug"].ToString();
                this.Description = mo["Description"] == null ? "" : mo["Description"].ToString();
                this.Distributed = mo["Distributed"] == null ? "" : mo["Distributed"].ToString();
                // this.EncryptionLevel = mo["EncryptionLevel"] == null ? "" : GetEnumDescription((EncryptionLevelValues)Convert.ToInt32(mo["EncryptionLevel"]));
                this.ForegroundApplicationBoost = mo["ForegroundApplicationBoost"] == null ? "" : GetEnumDescription((ForegroundApplicationBoostValues)Convert.ToInt32(mo["ForegroundApplicationBoost"]));

                this.FreePhysicalMemory = mo["FreePhysicalMemory"] == null ? "" : mo["FreePhysicalMemory"].ToString() + " KB";
                this.FreeSpaceInPagingFiles = mo["FreeSpaceInPagingFiles"] == null ? "" : mo["FreeSpaceInPagingFiles"].ToString() + " KB";
                this.FreeVirtualMemory = mo["FreeVirtualMemory"] == null ? "" : mo["FreeVirtualMemory"].ToString() + " KB";
                this.InstallDate = mo["InstallDate"] == null ? "" : mo["InstallDate"].ToString();
                this.LargeSystemCache = mo["LargeSystemCache"] == null ? "" : GetEnumDescription((LargeSystemCacheValues)Convert.ToInt32(mo["LargeSystemCache"]));
                this.LastBootUpTime = mo["LastBootUpTime"] == null ? "" : mo["LastBootUpTime"].ToString();
                this.LocalDateTime = mo["LocalDateTime"] == null ? "" : mo["LocalDateTime"].ToString();
                this.Locale = mo["Locale"] == null ? "" : mo["Locale"].ToString();
                this.Manufacturer = mo["Manufacturer"] == null ? "" : mo["Manufacturer"].ToString();
                this.MaxNumberOfProcesses = mo["MaxNumberOfProcesses"] == null ? "" : mo["MaxNumberOfProcesses"].ToString();
                this.MaxProcessMemorySize = mo["MaxProcessMemorySize"] == null ? "" : mo["MaxProcessMemorySize"].ToString();
                this.MUILanguages = mo["MUILanguages"] == null ? "" : mo["MUILanguages"].ToString();
                this.Name = mo["Name"] == null ? "" : mo["Name"].ToString();
                this.NumberOfLicensedUsers = mo["NumberOfLicensedUsers"] == null ? "" : mo["NumberOfLicensedUsers"].ToString();
                this.NumberOfProcesses = mo["NumberOfProcesses"] == null ? "" : mo["NumberOfProcesses"].ToString();
                this.NumberOfUsers = mo["NumberOfUsers"] == null ? "" : mo["NumberOfUsers"].ToString();
                //this.OperatingSystemSKU = mo["OperatingSystemSKU"] == null ? "" : GetEnumDescription((OperatingSystemSKUValues)Convert.ToInt32(mo["OperatingSystemSKU"]));
                this.Organization = mo["Organization"] == null ? "" : mo["Organization"].ToString();
                this.OSArchitecture = mo["OSArchitecture"] == null ? "" : mo["OSArchitecture"].ToString();
                this.OSLanguage = mo["OSLanguage"] == null ? "" : GetEnumDescription((OSLanguageValues)Convert.ToInt32(mo["OSLanguage"]));
                //  this.OSProductSuite = mo["OSProductSuite"] == null ? "" : GetEnumDescription((OSProductSuiteValues)Convert.ToInt32(mo["OSProductSuite"]));
                this.OSType = mo["OSType"] == null ? "" : GetEnumDescription((OSTypeValues)Convert.ToInt32(mo["OSType"]));
                this.PAEEnabled = mo["PAEEnabled"] == null ? "" : mo["PAEEnabled"].ToString();
                this.PlusProductID = mo["PlusProductID"] == null ? "" : mo["PlusProductID"].ToString();
                this.PlusVersionNumber = mo["PlusVersionNumber"] == null ? "" : mo["PlusVersionNumber"].ToString();
                this.PortableOperatingSystem = mo["PortableOperatingSystem"] == null ? "" : mo["PortableOperatingSystem"].ToString();
                this.Primary = mo["Primary"] == null ? "" : mo["Primary"].ToString();
                this.ProductType = mo["ProductType"] == null ? "" : GetEnumDescription((ProductTypeValues)Convert.ToInt32(mo["ProductType"]));
                this.SerialNumber = mo["SerialNumber"] == null ? "" : mo["SerialNumber"].ToString();
                this.ServicePackMajorVersion = mo["ServicePackMajorVersion"] == null ? "" : mo["ServicePackMajorVersion"].ToString();
                this.ServicePackMinorVersion = mo["ServicePackMinorVersion"] == null ? "" : mo["ServicePackMinorVersion"].ToString();
                this.SizeStoredInPagingFiles = mo["SizeStoredInPagingFiles"] == null ? "" : mo["SizeStoredInPagingFiles"].ToString();
                this.Status = mo["Status"] == null ? "" : mo["Status"].ToString();
                this.SystemDevice = mo["SystemDevice"] == null ? "" : mo["SystemDevice"].ToString();
                this.SystemDrive = mo["SystemDrive"] == null ? "" : mo["SystemDrive"].ToString();
                this.TotalSwapSpaceSize = mo["TotalSwapSpaceSize"] == null ? "" : mo["TotalSwapSpaceSize"].ToString();
                this.TotalVirtualMemorySize = mo["TotalVirtualMemorySize"] == null ? "" : mo["TotalVirtualMemorySize"].ToString();
                this.TotalVisibleMemorySize = mo["TotalVisibleMemorySize"] == null ? "" : mo["TotalVisibleMemorySize"].ToString();
                this.Version = mo["Version"] == null ? "" : mo["Version"].ToString();
                this.WindowsDirectory = mo["WindowsDirectory"] == null ? "" : mo["WindowsDirectory"].ToString();



            }
            return this;
        }
        private string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
            if (value == null)
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
    }

}
