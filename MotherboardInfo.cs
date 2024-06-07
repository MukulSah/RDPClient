using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;

namespace RDPClientApplication
{
    class MotherboardInfo
    {
        enum AvailabilityValues
        {
            [Description("Other")]
            Other = 1,
            [Description("Unknown")]
            Unknown = 2,
            [Description("Running/Full Power")]
            RunningFullPower = 3,
            [Description("Warning")]
            Warning = 4,
            [Description("In Test")]

            InTest = 5,
            [Description("Not Applicable")]

            NotApplicable = 6,
            [Description("Power Off")]

            PowerOff = 7,
            [Description("Off Line")]

            OffLine = 8,
            [Description("Off Duty")]

            OffDuty = 9,
            [Description("Degraded")]

            Degraded = 10,
            [Description("Not Installed")]

            NotInstalled = 11,
            [Description("Install Error")]

            InstallError = 12,
            [Description("Power Save - Unknown")]

            PowerSaveUnknown = 13,
            [Description("Power Save - Low Power Mode")]

            PowerSaveLowPowerMode = 14,
            [Description("Power Save - Standby")]

            PowerSaveStandby = 15,
            [Description("Power Cycle")]
            PowerCycle = 16,
            [Description("Power Save - Warning")]
            PowerSaveWarning = 17,
            [Description("Paused")]
            Paused = 18,
            [Description("Not Ready")]
            NotReady = 19,
            [Description("Not Configured")]
            NotConfigured = 20,
            [Description("Quiesced")]
            Quiesced = 21,

        }

        enum ConfigManagerErrorCodeValues
        {

            [Description("This device is working properly")]
            Thisdeviceisworkingproperly = 0,
            [Description("This device is not configured correctly")]
            Thisdeviceisnotconfiguredcorrectly = 1,
            [Description("Windows cannot load the driver for this device")]
            Windowscannotloadthedriverforthisdevice = 2,
            [Description("The driver for this device might be corrupted, or your system may be running low on memory or other resources")]
            Thedriverforthisdevicemightbecorruptedoyoursystemmayberunninglowonmemoryorotherresources = 3,
            [Description("This device is not working properly.One of its drivers or your registry might be corrupted")]
            ThisdeviceisnotworkingproperlyOneofitdriversoryourregistrymightbeorrupted = 4,
            [Description("The driver for this device needs a resource that Windows cannot manage")]
            ThedriverforthisdeviceneedsaresourcethatWindowscannotmanage = 5,
            [Description("The boot configuration for this device conflicts with other devices")]
            Thebootconfigurationforthisdeviceconflictswithotherdevices = 6,
            [Description("Cannot filter")]
            Cannotfilter = 7,
            [Description("The driver loader for the device is missing")]
            Thedriverloaderforthedeviceismissing = 8,
            [Description("This device is not working properly because the controlling firmware is reporting the resources for the device incorrectly")]
            Thisdeviceisnotworkingproperlcontrollingfirmwareisreportingheesourcesforthedeviceincorrectly = 9,
            [Description("This device cannot start")]
            Thisdevicecannotstart = 10,
            [Description("This device failed")]
            Thisdevicefailed = 11,

            [Description("This device cannot find enough free resources that it can use")]
            Thisdevicecannotfindenoughfreeresourcesthatitcanuse = 12,
            [Description("Windows cannot verify this device's resources")]
            Windowscannotverifythisdeviceresources = 13,
            [Description("This device cannot work properly until you restart your computer")]
            Thisdevicecannotworkproperluntilyourestartyourcomputer = 14,
            [Description("This device is not working properly because there is probably a re-enumeration problem")]
            Thisdeviceisnotworkingproperlybecausethereisprobablyareenumerationproblem = 15,
            [Description("Windows cannot identify all the resources this device uses")]
            Windowscannotidentifyalltheresourcesthisdeviceuses = 16,
            [Description("This device is asking for an unknown resource type")]
            Thisdeviceisaskingforanunknownresourcetype = 17,
            [Description("Reinstall the drivers for this device")]
            Reinstallthedriversforhisdevice = 18,
            [Description("Failure using the VxD loader")]
            FailureusingtheVxDloader = 19,
            [Description("Your registry might be corrupted")]
            Yourregistrymightbecorrupted = 20,

            [Description("System failure: Try changing the driver for this device.If that does not work, see your hardware documentation. Windows is removing this device")]
            SystemfailurerychangingthedriverforthisdeviceIfhatdoesnotworkseeyourhardwaredocumentationWindowsisremovingthisdevice = 21,
            [Description("This device is disabled")]
            Thisdeviceisisabled = 22,
            [Description("System failure: Try changing the driver for this device.If that doesn't work, see your hardware documentation")]
            SystemfailureTrychangingthedriverforhisdeviceIfthatdoesnworkseeyourhardwaredocumentation = 23,
            [Description("This device is not present, is not working properly, or does not have all its drivers installed")]
            Thisdeviceisnotpresentisnotworkingproperlyordoesnothavallitsdriversinstalled = 24,
            [Description("Windows is still setting up this device")]
            Windowsisstillsettingupthisdevice = 25,
            [Description("Windows is still setting up this device")]
            Windowsisstilsettingupthisdevice = 26,

            [Description("This device does not have valid log configuration")]
            Thisdevicedoesnothavevalidlogconfiguration = 27,
            [Description("The drivers for this device are not installed")]
            Thedriversforthisdevicearenotinstalled = 28,
            [Description("This device is disabled because the firmware of the device did not give it the required resources")]
            Thisdeviceisdisabledbecausethefirmwareofthedevicedidnotgivittherequiredresources = 29,
            [Description(" This device is using an Interrupt Request(IRQ) resource that another device is using")]
            ThideviceisusinganInterruptRequestIRQresourcethatanotherdeviceis = 30,
            [Description("This device is not working properly because Windows cannot load the drivers required for this device")]
            ThisdeviceisnotworkingproperlbecauseWindowscannoloadthedriversrequiredforthisdevice = 31,

        }

        enum PowerManagementCapabilitiesValues
        {

            [Description("Unknown ")]
            Unknown = 0,
            [Description("Not Supported")]
            NotSupported = 1,
            [Description("Disabled ")]
            Disabled = 2,
            [Description("Enabled")]
            Enabled = 3,
            [Description("Power Saving Modes Entered Automatically")]
            PowerSavingModesEnteredAutomatically = 4,
            [Description("Power State Settable")]
            PowerStateSettable = 5,
            [Description("Power Cycling Supported")]
            PowerCyclingSupported = 6,
            [Description("Timed Power On Supported ")]
            TimedPowerOnSupported = 7
        }
        public string Availability { get; set; }
        public string Caption { get; set; }
        public string ConfigManagerErrorCode { get; set; }
        public string ConfigManagerUserConfig { get; set; }
        public string Description { get; set; }
        public string DeviceID { get; set; }
        public string InstallDate { get; set; }
        public string Name { get; set; }
        public string PowerManagementCapabilities { get; set; }
        public string PowerManagementSupported { get; set; }
        public string PrimaryBusType { get; set; }
        public string RevisionNumber { get; set; }
        public string SecondaryBusType { get; set; }
        public string Status { get; set; }

        public List<string> ConfigOptions { get; set; } = new List<string>();
        public string Depth { get; set; }
        public string Height { get; private set; }
        public string HostingBoard { get; private set; }
        public string HotSwappable { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string PartNumber { get; private set; }
        public string PoweredOn { get; private set; }
        public string Product { get; private set; }
        public string Removable { get; private set; }
        public string RequirementsDescription { get; private set; }
        public string RequiresDaughterBoard { get; private set; }
        public string SerialNumber { get; private set; }
        public string SKU { get; private set; }
        public string SlotLayout { get; private set; }
        public string Tag { get; private set; }
        public string Version { get; private set; }
        public string Weight { get; private set; }
        public string Width { get; private set; }

        public void Read()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_MotherboardDevice");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                this.Availability = mo["Availability"] == null ? "" : GetEnumDescription((AvailabilityValues)Convert.ToInt32(mo["Availability"]));
                this.Caption = mo["Caption"] == null ? "" : mo["Caption"].ToString();
                this.ConfigManagerErrorCode = mo["ConfigManagerErrorCode"] == null ? "" : GetEnumDescription((ConfigManagerErrorCodeValues)Convert.ToInt32(mo["ConfigManagerErrorCode"]));
                this.ConfigManagerUserConfig = mo["ConfigManagerUserConfig"] == null ? "" : mo["ConfigManagerUserConfig"].ToString();
                this.Description = mo["Description"] == null ? "" : mo["Description"].ToString();
                this.DeviceID = mo["DeviceID"] == null ? "" : mo["DeviceID"].ToString();
                this.InstallDate = mo["InstallDate"] == null ? "" : mo["InstallDate"].ToString();
                this.Name = mo["Name"] == null ? "" : mo["Name"].ToString();
                this.PowerManagementCapabilities = mo["PowerManagementCapabilities"] == null ? "" : GetEnumDescription((PowerManagementCapabilitiesValues)Convert.ToInt32(mo["PowerManagementCapabilities"]));
                this.PowerManagementSupported = mo["PowerManagementSupported"] == null ? "" : mo["PowerManagementSupported"].ToString();
                this.PrimaryBusType = mo["PrimaryBusType"] == null ? "" : mo["PrimaryBusType"].ToString();
                this.RevisionNumber = mo["RevisionNumber"] == null ? "" : mo["RevisionNumber"].ToString();
                this.SecondaryBusType = mo["SecondaryBusType"] == null ? "" : mo["SecondaryBusType"].ToString();
                this.Status = mo["Status"] == null ? "" : mo["Status"].ToString();



            }
        }


        public MotherboardInfo ReadMotherBoardDetails()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_MotherboardDevice");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                this.Availability = mo["Availability"] == null ? "" : GetEnumDescription((AvailabilityValues)Convert.ToInt32(mo["Availability"]));
                this.Caption = mo["Caption"] == null ? "" : mo["Caption"].ToString();
                this.ConfigManagerErrorCode = mo["ConfigManagerErrorCode"] == null ? "" : GetEnumDescription((ConfigManagerErrorCodeValues)Convert.ToInt32(mo["ConfigManagerErrorCode"]));
                this.ConfigManagerUserConfig = mo["ConfigManagerUserConfig"] == null ? "" : mo["ConfigManagerUserConfig"].ToString();
                this.Description = mo["Description"] == null ? "" : mo["Description"].ToString();
                this.DeviceID = mo["DeviceID"] == null ? "" : mo["DeviceID"].ToString();
                this.InstallDate = mo["InstallDate"] == null ? "" : mo["InstallDate"].ToString();
                this.Name = mo["Name"] == null ? "" : mo["Name"].ToString();
                this.PowerManagementCapabilities = mo["PowerManagementCapabilities"] == null ? "" : GetEnumDescription((PowerManagementCapabilitiesValues)Convert.ToInt32(mo["PowerManagementCapabilities"]));
                this.PowerManagementSupported = mo["PowerManagementSupported"] == null ? "" : mo["PowerManagementSupported"].ToString();
                this.PrimaryBusType = mo["PrimaryBusType"] == null ? "" : mo["PrimaryBusType"].ToString();
                this.RevisionNumber = mo["RevisionNumber"] == null ? "" : mo["RevisionNumber"].ToString();
                this.SecondaryBusType = mo["SecondaryBusType"] == null ? "" : mo["SecondaryBusType"].ToString();
                this.Status = mo["Status"] == null ? "" : mo["Status"].ToString();

            }
            ManagementObjectCollection mbsList1 = null;
            ManagementObjectSearcher mbs1 = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            mbsList1 = mbs1.Get();
            foreach (ManagementObject mo in mbsList1)
            {
                if (mo["ConfigOptions"] != null)
                {
                    foreach (string str in mo["ConfigOptions"] as string[])
                    {
                        this.ConfigOptions.Add(str);
                    }
                }

                this.Depth = mo["Depth"] == null ? "" : mo["Depth"].ToString();
                this.Height = mo["Height"] == null ? "" : mo["Height"].ToString();
                this.HostingBoard = mo["HostingBoard"] == null ? "" : mo["HostingBoard"].ToString();
                this.HotSwappable = mo["HotSwappable"] == null ? "" : mo["HotSwappable"].ToString();
                this.Manufacturer = mo["Manufacturer"] == null ? "" : mo["Manufacturer"].ToString();
                this.Model = mo["Model"] == null ? "" : mo["Model"].ToString();
                this.PartNumber = mo["PartNumber"] == null ? "" : mo["PartNumber"].ToString();
                this.PoweredOn = mo["PoweredOn"] == null ? "" : mo["PoweredOn"].ToString();
                this.Product = mo["Product"] == null ? "" : mo["Product"].ToString();
                this.Removable = mo["Removable"] == null ? "" : mo["Removable"].ToString();
                this.RequirementsDescription = mo["RequirementsDescription"] == null ? "" : mo["RequirementsDescription"].ToString();
                this.RequiresDaughterBoard = mo["RequiresDaughterBoard"] == null ? "" : mo["RequiresDaughterBoard"].ToString();
                this.SerialNumber = mo["SerialNumber"] == null ? "" : mo["SerialNumber"].ToString();
                this.SKU = mo["SKU"] == null ? "" : mo["SKU"].ToString();
                this.SlotLayout = mo["SlotLayout"] == null ? "" : mo["SlotLayout"].ToString();
                this.Tag = mo["Tag"] == null ? "" : mo["Tag"].ToString();
                this.Version = mo["Version"] == null ? "" : mo["Version"].ToString();
                this.Weight = mo["Weight"] == null ? "" : mo["Weight"].ToString();
                this.Width = mo["Width"] == null ? "" : mo["Width"].ToString();

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
