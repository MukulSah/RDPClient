using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RDPClientApplication
{
    public partial class HardwareAllDetails : Form
    {
        public HardwareAllDetails()
        {
            InitializeComponent();
            
            

        }

        private void HardwareAllDetails_Load(object sender, EventArgs e)
        {

            label1.Text = "";
            listViewHardware.Visible = false;

        }

        private void BIOSDetails()
        {
            BIOSInfo info = new BIOSInfo();
            info = info.ReadBIOSDetails();
            DatabaseConnection.SaveBiosDetails(info);
            ListViewGroup lvg = listViewHardware.Groups["BIOS"];
            if (lvg == null)
                lvg = listViewHardware.Groups.Add("listViewGroupBios", "BIOS");

            var BiosCharactersticsListItem = new ListViewItem(new[] { "BiosCharacterstics", info.BiosCharactersticsList[0] });
            BiosCharactersticsListItem.Group = lvg;
            listViewHardware.Items.Add(BiosCharactersticsListItem);

            for(int i = 1; i < info.BiosCharactersticsList.Count; i++)
            {
                var BiosCharactersticsItem = new ListViewItem(new[] { "", info.BiosCharactersticsList[i] });
                BiosCharactersticsItem.Group = lvg;
                listViewHardware.Items.Add(BiosCharactersticsItem);

            }


            var BuildNumberItem = new ListViewItem(new[] { "Build Number", info.BuildNumber });
            BuildNumberItem.Group = lvg;
            listViewHardware.Items.Add(BuildNumberItem);

            var CaptionItem = new ListViewItem(new[] { "Caption", info.Caption });
            CaptionItem.Group = lvg;
            listViewHardware.Items.Add(CaptionItem);

            var CodeSetItem = new ListViewItem(new[] { "Code Set", info.CodeSet });
            CodeSetItem.Group = lvg;
            listViewHardware.Items.Add(CodeSetItem);

            var CurrentLanguageItem = new ListViewItem(new[] { "Current Language", info.CurrentLanguage });
            CurrentLanguageItem.Group = lvg;
            listViewHardware.Items.Add(CurrentLanguageItem);

            var DescriptionItem = new ListViewItem(new[] { "Description", info.Description });
            DescriptionItem.Group = lvg;
            listViewHardware.Items.Add(DescriptionItem);

            var EmbeddedControllerMajorVersionItem = new ListViewItem(new[] { "Embedded Controller Major Version", info.EmbeddedControllerMajorVersion });
            EmbeddedControllerMajorVersionItem.Group = lvg;
            listViewHardware.Items.Add(EmbeddedControllerMajorVersionItem);

            var EmbeddedControllerMinorVersionItem = new ListViewItem(new[] { "Embedded Controller Major Version", info.EmbeddedControllerMinorVersion });
            EmbeddedControllerMinorVersionItem.Group = lvg;
            listViewHardware.Items.Add(EmbeddedControllerMinorVersionItem);

            var IdentificationCodeItem = new ListViewItem(new[] { "Identification Code", info.IdentificationCode });
            IdentificationCodeItem.Group = lvg;
            listViewHardware.Items.Add(IdentificationCodeItem);

            var InstallableLanguagesItem = new ListViewItem(new[] { "Installable Languages", info.InstallableLanguages });
            InstallableLanguagesItem.Group = lvg;
            listViewHardware.Items.Add(InstallableLanguagesItem);

            var InstallDateItem = new ListViewItem(new[] { "Install Date", info.InstallDate });
            InstallDateItem.Group = lvg;
            listViewHardware.Items.Add(InstallDateItem);

            var LanguageEditionItem = new ListViewItem(new[] { "Language Edition", info.LanguageEdition });
            LanguageEditionItem.Group = lvg;
            listViewHardware.Items.Add(LanguageEditionItem);

            var ManufacturerItem = new ListViewItem(new[] { "Manufacturer", info.Manufacturer });
            ManufacturerItem.Group = lvg;
            listViewHardware.Items.Add(ManufacturerItem);

            var NameItem = new ListViewItem(new[] { "Name", info.Name });
            NameItem.Group = lvg;
            listViewHardware.Items.Add(NameItem);

            var PrimaryBIOSItem = new ListViewItem(new[] { "Primary BIOS", info.PrimaryBIOS });
            PrimaryBIOSItem.Group = lvg;
            listViewHardware.Items.Add(PrimaryBIOSItem);

            var SerialNumberItem = new ListViewItem(new[] { "Serial Number", info.SerialNumber });
            SerialNumberItem.Group = lvg;
            listViewHardware.Items.Add(SerialNumberItem);

            var SMBIOSBIOSVersionItem = new ListViewItem(new[] { "SMBIOS BIOSVersion", info.SMBIOSBIOSVersion });
            SMBIOSBIOSVersionItem.Group = lvg;
            listViewHardware.Items.Add(SMBIOSBIOSVersionItem);

            var SMBIOSMajorVersionItem = new ListViewItem(new[] { "SMBIOS MajorVersion", info.SMBIOSMajorVersion });
            SMBIOSMajorVersionItem.Group = lvg;
            listViewHardware.Items.Add(SMBIOSMajorVersionItem);

            var SMBIOSMinorVersionItem = new ListViewItem(new[] { "SMBIOS MinorVersion", info.SMBIOSMinorVersion });
            SMBIOSMinorVersionItem.Group = lvg;
            listViewHardware.Items.Add(SMBIOSMinorVersionItem);

            var SMBIOSPresentItem = new ListViewItem(new[] { "SMBIOS Present", info.SMBIOSPresent });
            SMBIOSPresentItem.Group = lvg;
            listViewHardware.Items.Add(SMBIOSPresentItem);

            var StatusItem = new ListViewItem(new[] { "Status", info.Status });
            StatusItem.Group = lvg;
            listViewHardware.Items.Add(StatusItem);

            var SystemBiosMajorVersionItem = new ListViewItem(new[] { "System Bios Major Version", info.SystemBiosMajorVersion });
            SystemBiosMajorVersionItem.Group = lvg;
            listViewHardware.Items.Add(SystemBiosMajorVersionItem);

            var SystemBiosMinorVersionItem = new ListViewItem(new[] { "System Bios Minor Version", info.SystemBiosMinorVersion });
            SystemBiosMinorVersionItem.Group = lvg;
            listViewHardware.Items.Add(SystemBiosMinorVersionItem);

            var TargetOperatingSystemItem = new ListViewItem(new[] { "Target Operating System", info.TargetOperatingSystem });
            TargetOperatingSystemItem.Group = lvg;
            listViewHardware.Items.Add(TargetOperatingSystemItem);
        }

        private void ProcessorDetails()
        {
            ProcessorInfo info = new ProcessorInfo();
            info = info.ReadProcessorDetails();
            DatabaseConnection.SaveProcessorDetails(info);
            ListViewGroup lvg = listViewHardware.Groups["Processor"];
            if (lvg == null)
                lvg = listViewHardware.Groups.Add("listViewGroupProcessor", "Processor");

            var AddressWidthItem = new ListViewItem(new[] { "Address Width", info.AddressWidth });
            AddressWidthItem.Group = lvg;
            listViewHardware.Items.Add(AddressWidthItem);

            var ArchitechureItem = new ListViewItem(new[] { "Architechure ", info.Architechure });
            ArchitechureItem.Group = lvg;
            listViewHardware.Items.Add(ArchitechureItem);

            var AssetTagItem = new ListViewItem(new[] { "Asset Tag ", info.AssetTag });
            AssetTagItem.Group = lvg;
            listViewHardware.Items.Add(AssetTagItem);

            var AvailabilityItem = new ListViewItem(new[] { "Availability ", info.Availability });
            AvailabilityItem.Group = lvg;
            listViewHardware.Items.Add(AvailabilityItem);

            var CaptionItem = new ListViewItem(new[] { "Caption ", info.Caption });
            CaptionItem.Group = lvg;
            listViewHardware.Items.Add(CaptionItem);

            var CPUStatusItem = new ListViewItem(new[] { "CPU Status ", info.CPUStatus });
            CPUStatusItem.Group = lvg;
            listViewHardware.Items.Add(CPUStatusItem);

            var CurrentClockSpeedItem = new ListViewItem(new[] { "CurrentClockSpeed ", info.CurrentClockSpeed });
            CurrentClockSpeedItem.Group = lvg;
            listViewHardware.Items.Add(CurrentClockSpeedItem);

            var DeviceIDItem = new ListViewItem(new[] { "DeviceID ", info.DeviceID });
            DeviceIDItem.Group = lvg;
            listViewHardware.Items.Add(DeviceIDItem);

            var CurrentVoltageItem = new ListViewItem(new[] { "CurrentVoltage ", info.CurrentVoltage });
            CurrentVoltageItem.Group = lvg;
            listViewHardware.Items.Add(CurrentVoltageItem);

            var InstallDateItem = new ListViewItem(new[] { "InstallDate ", info.InstallDate });
            InstallDateItem.Group = lvg;
            listViewHardware.Items.Add(InstallDateItem);

            var L2CacheSizeItem = new ListViewItem(new[] { "L2CacheSize ", info.L2CacheSize });
            L2CacheSizeItem.Group = lvg;
            listViewHardware.Items.Add(L2CacheSizeItem);

            var L2CacheSpeedItem = new ListViewItem(new[] { "L2CacheSpeed ", info.L2CacheSpeed });
            L2CacheSpeedItem.Group = lvg;
            listViewHardware.Items.Add(L2CacheSpeedItem);

            var L3CacheSizeItem = new ListViewItem(new[] { "L3CacheSize ", info.L3CacheSize });
            L3CacheSizeItem.Group = lvg;
            listViewHardware.Items.Add(L3CacheSizeItem);

            var L3CacheSpeedItem = new ListViewItem(new[] { "L3CacheSpeed ", info.L3CacheSpeed });
            L3CacheSpeedItem.Group = lvg;
            listViewHardware.Items.Add(L3CacheSpeedItem);

            var ManufacturerItem = new ListViewItem(new[] { "Manufacturer", info.Manufacturer });
            ManufacturerItem.Group = lvg;
            listViewHardware.Items.Add(ManufacturerItem);

            var MaxClockSpeedItem = new ListViewItem(new[] { "MaxClockSpeed", info.MaxClockSpeed });
            MaxClockSpeedItem.Group = lvg;
            listViewHardware.Items.Add(MaxClockSpeedItem);

            var NameItem = new ListViewItem(new[] { "Processor Name", info.Name });
            NameItem.Group = lvg;
            listViewHardware.Items.Add(NameItem);

            var NumberOfCoresItem = new ListViewItem(new[] { "NumberOfCores", info.NumberOfCores });
            NumberOfCoresItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfCoresItem);

            var NumberOfEnabledCoreItem = new ListViewItem(new[] { "NumberOfEnabledCore", info.NumberOfEnabledCore });
            NumberOfEnabledCoreItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfEnabledCoreItem);

            var NumberOfLogicalProcessorsItem = new ListViewItem(new[] { "NumberOfLogicalProcessors", info.NumberOfLogicalProcessors });
            NumberOfLogicalProcessorsItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfLogicalProcessorsItem);

            var idItem = new ListViewItem(new[] { "ID", info.ProcessorId, });
            idItem.Group = lvg;
            listViewHardware.Items.Add(idItem);

            var typeItem = new ListViewItem(new[] { "Type", info.ProcessorType  });
            typeItem.Group = lvg;
            listViewHardware.Items.Add(typeItem);                

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewHardware.SetGroupState(ListViewGroupState.Collapsible);
        }

        private void SetGroupStateCollapsible()
        {
            listViewHardware.SetGroupState(ListViewGroupState.Collapsible);
        }

        private void HardwareAllDetails_Paint(object sender, PaintEventArgs e)
        {
              if (VisualStyleRenderer.IsElementDefined(
        VisualStyleElement.ListView.Group.Normal))
    {
        VisualStyleRenderer renderer =
             new VisualStyleRenderer(VisualStyleElement.ListView.Group.Normal);
        Rectangle rectangle1 = new Rectangle(10, 50, 50, 50);
        renderer.DrawBackground(e.Graphics, rectangle1);
        e.Graphics.DrawString("VisualStyleElement.ListView.Group.Normal",
             this.Font, Brushes.Black, new Point(10, 10));
    }
            else { }
        //e.Graphics.DrawString("This element is not defined in the current visual style.",
        //     this.Font, Brushes.Black, new Point(10, 10));
        }

        private void HardwareAllDetails_Shown(object sender, EventArgs e)
        {

            //show processor Details
            ProcessorDetails();

            //show Bios details
            BIOSDetails();
            MotherboardDetails();
            OperatingSystemDetails();
            HardDiskDetails();
            SetGroupStateCollapsible();
            listViewHardware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            label1.Visible = false;
            listViewHardware.Visible = true;
        }

        private void HardDiskDetails()
        {

            HardDiskInfo info = new HardDiskInfo();
            List<HardDiskInfo> details= info.ReadHardDiskInfo();
           
            ListViewGroup lvg = listViewHardware.Groups["Hard Disk"];
            if (lvg == null)
                lvg = listViewHardware.Groups.Add("listViewGroupHardDisk", "HardDisk");

            foreach(HardDiskInfo hardDisk in details)
            {
                var NameItem = new ListViewItem(new[] { "Hard disk " + hardDisk.Name, "Name" });
                NameItem.Group = lvg;
                NameItem.SubItems.Add(hardDisk.Name);
                listViewHardware.Items.Add(NameItem);

                var DriveFormatItem = new ListViewItem(new[] { "", "Drive Format" });
                DriveFormatItem.Group = lvg;
                DriveFormatItem.SubItems.Add(hardDisk.DriveFormat);
                listViewHardware.Items.Add(DriveFormatItem);

                var RootDirectoryItem = new ListViewItem(new[] { "", "Root Directory" });
                RootDirectoryItem.Group = lvg;
                RootDirectoryItem.SubItems.Add(hardDisk.RootDirectory);
                listViewHardware.Items.Add(RootDirectoryItem);

                var VolumeLabelItem = new ListViewItem(new[] { "", "Volume Label" });
                VolumeLabelItem.Group = lvg;
                VolumeLabelItem.SubItems.Add(hardDisk.VolumeLabel);
                listViewHardware.Items.Add(VolumeLabelItem);

                var TotalSizeItem = new ListViewItem(new[] { "", "Total Size" });
                TotalSizeItem.Group = lvg;
                TotalSizeItem.SubItems.Add(hardDisk.TotalSize);
                listViewHardware.Items.Add(TotalSizeItem);

                var TotalFreeSpaceItem = new ListViewItem(new[] { "", "Total Free Space" });
                TotalFreeSpaceItem.Group = lvg;
                TotalFreeSpaceItem.SubItems.Add(hardDisk.TotalFreeSpace);
                listViewHardware.Items.Add(TotalFreeSpaceItem);

                var AvailableFreeSpaceItem = new ListViewItem(new[] { "", "Available Free Space" });
                AvailableFreeSpaceItem.Group = lvg;
                AvailableFreeSpaceItem.SubItems.Add(hardDisk.AvailableFreeSpace);
                listViewHardware.Items.Add(AvailableFreeSpaceItem);

                var BlankItem = new ListViewItem(new[] { "", "" });
                BlankItem.Group = lvg;
                BlankItem.SubItems.Add("");
                listViewHardware.Items.Add(BlankItem);
            }
           
        }

        private void MotherboardDetails()
        {
            MotherboardInfo info = new MotherboardInfo();
            info = info.ReadMotherBoardDetails();
            DatabaseConnection.SaveMotherboardDetails(info);
            ListViewGroup lvg = listViewHardware.Groups["Motherboard"];
            if (lvg == null)
                lvg = listViewHardware.Groups.Add("listViewGroupMotherboard", "Motherboard");

            var AvailabilityItem = new ListViewItem(new[] { "Availability", info.Availability });
            AvailabilityItem.Group = lvg;
            listViewHardware.Items.Add(AvailabilityItem);

            var CaptionItem = new ListViewItem(new[] { "Caption", info.Caption });
            CaptionItem.Group = lvg;
            listViewHardware.Items.Add(CaptionItem);

            var ConfigManagerErrorCodeItem = new ListViewItem(new[] { "Config Manager Error Code", info.ConfigManagerErrorCode });
            ConfigManagerErrorCodeItem.Group = lvg;
            listViewHardware.Items.Add(ConfigManagerErrorCodeItem);

            var ConfigManagerUserConfigItem = new ListViewItem(new[] { "Config Manager User Config", info.ConfigManagerUserConfig });
            ConfigManagerUserConfigItem.Group = lvg;
            listViewHardware.Items.Add(ConfigManagerUserConfigItem);

            var DescriptionItem = new ListViewItem(new[] { "Description", info.Description });
            DescriptionItem.Group = lvg;
            listViewHardware.Items.Add(DescriptionItem);

            var DeviceIDItem = new ListViewItem(new[] { "Device ID", info.DeviceID });
            DeviceIDItem.Group = lvg;
            listViewHardware.Items.Add(DeviceIDItem);

            var InstallDateItem = new ListViewItem(new[] { "Install Date", info.InstallDate });
            InstallDateItem.Group = lvg;
            listViewHardware.Items.Add(InstallDateItem);

            var NameItem = new ListViewItem(new[] { "Name", info.Name });
            NameItem.Group = lvg;
            listViewHardware.Items.Add(NameItem);

            var PowerManagementCapabilitiesItem = new ListViewItem(new[] { "Power Management Capabilities", info.PowerManagementCapabilities });
            PowerManagementCapabilitiesItem.Group = lvg;
            listViewHardware.Items.Add(PowerManagementCapabilitiesItem);

            var PowerManagementSupportedItem = new ListViewItem(new[] { "Power Management Supported", info.PowerManagementSupported });
            PowerManagementSupportedItem.Group = lvg;
            listViewHardware.Items.Add(PowerManagementSupportedItem);

            var PrimaryBusTypeItem = new ListViewItem(new[] { "Primary Bus Type", info.PrimaryBusType });
            PrimaryBusTypeItem.Group = lvg;
            listViewHardware.Items.Add(PrimaryBusTypeItem);

            var RevisionNumberItem = new ListViewItem(new[] { "Revision Number", info.RevisionNumber });
            RevisionNumberItem.Group = lvg;
            listViewHardware.Items.Add(RevisionNumberItem);

            var SecondaryBusTypeItem = new ListViewItem(new[] { "Secondary Bus Type", info.SecondaryBusType });
            SecondaryBusTypeItem.Group = lvg;
            listViewHardware.Items.Add(SecondaryBusTypeItem);

            var StatusItem = new ListViewItem(new[] { "Status", info.Status });
            StatusItem.Group = lvg;
            listViewHardware.Items.Add(StatusItem);

            if (info.ConfigOptions != null && info.ConfigOptions.Count > 0)
            {
                var ConfigOptionsItem = new ListViewItem(new[] { "Config Options", info.ConfigOptions[0] });
                ConfigOptionsItem.Group = lvg;
                listViewHardware.Items.Add(ConfigOptionsItem);

                for (int i = 1; i < info.ConfigOptions.Count; i++)
                {
                    if (info.ConfigOptions[i] == null)
                    {
                        continue;
                    }

                    var ConfigOptions = new ListViewItem(new[] { "", info.ConfigOptions[i] });
                    ConfigOptions.Group = lvg;
                    listViewHardware.Items.Add(ConfigOptions);

                }
            }
            else { }
            

            var DepthItem = new ListViewItem(new[] { "Depth", info.Depth });
            DepthItem.Group = lvg;
            listViewHardware.Items.Add(DepthItem);

            var HeightItem = new ListViewItem(new[] { "Height", info.Height });
            HeightItem.Group = lvg;
            listViewHardware.Items.Add(HeightItem);

            var HostingBoardItem = new ListViewItem(new[] { "Hosting Board", info.HostingBoard });
            HostingBoardItem.Group = lvg;
            listViewHardware.Items.Add(HostingBoardItem);

            var HotSwappableItem = new ListViewItem(new[] { "Hot Swappable", info.HotSwappable });
            HotSwappableItem.Group = lvg;
            listViewHardware.Items.Add(HotSwappableItem);

            var ManufacturerItem = new ListViewItem(new[] { "Manufacturer", info.Manufacturer });
            ManufacturerItem.Group = lvg;
            listViewHardware.Items.Add(ManufacturerItem);

            var ModelItem = new ListViewItem(new[] { "Model", info.Model });
            ModelItem.Group = lvg;
            listViewHardware.Items.Add(ModelItem);

            var PartNumberItem = new ListViewItem(new[] { "Part Number", info.PartNumber });
            PartNumberItem.Group = lvg;
            listViewHardware.Items.Add(PartNumberItem);

            var PoweredOnItem = new ListViewItem(new[] { "Powered On", info.PoweredOn });
            PoweredOnItem.Group = lvg;
            listViewHardware.Items.Add(PoweredOnItem);

            var ProductItem = new ListViewItem(new[] { "Product", info.Product });
            ProductItem.Group = lvg;
            listViewHardware.Items.Add(ProductItem);

            var RemovableItem = new ListViewItem(new[] { "Removable", info.Removable });
            RemovableItem.Group = lvg;
            listViewHardware.Items.Add(RemovableItem);

            var RequirementsDescriptionItem = new ListViewItem(new[] { "Requirements Description", info.RequirementsDescription });
            RequirementsDescriptionItem.Group = lvg;
            listViewHardware.Items.Add(RequirementsDescriptionItem);

            var RequiresDaughterBoardItem = new ListViewItem(new[] { "Requires Daughter Board", info.RequiresDaughterBoard });
            RequiresDaughterBoardItem.Group = lvg;
            listViewHardware.Items.Add(RequiresDaughterBoardItem);

            var SerialNumberItem = new ListViewItem(new[] { "Serial Number", info.SerialNumber });
            SerialNumberItem.Group = lvg;
            listViewHardware.Items.Add(SerialNumberItem);

            var SKUItem = new ListViewItem(new[] { "SKU", info.SKU });
            SKUItem.Group = lvg;
            listViewHardware.Items.Add(SKUItem);

            var SlotLayoutItem = new ListViewItem(new[] { "Slot Layout", info.SlotLayout });
            SlotLayoutItem.Group = lvg;
            listViewHardware.Items.Add(SlotLayoutItem);

            var TagItem = new ListViewItem(new[] { "Tag", info.Tag });
            TagItem.Group = lvg;
            listViewHardware.Items.Add(TagItem);

            var WeightItem = new ListViewItem(new[] { "Weight", info.Weight });
            WeightItem.Group = lvg;
            listViewHardware.Items.Add(WeightItem);

            var WidthItem = new ListViewItem(new[] { "Width", info.Width });
            WidthItem.Group = lvg;
            listViewHardware.Items.Add(WidthItem);
        }

        private void OperatingSystemDetails()
        {
            OperatingSystemInfo info = new OperatingSystemInfo();
            info = info.ReadRAMDetails();

            ListViewGroup lvg = listViewHardware.Groups["OPerating System"];
            if (lvg == null)
                lvg = listViewHardware.Groups.Add("listViewGroupOperatingSystem", "OperatingSystem");

            var BootDeviceItem = new ListViewItem(new[] { "Boot Device", info.BootDevice });
            BootDeviceItem.Group = lvg;
            listViewHardware.Items.Add(BootDeviceItem);

            var BuildNumberItem = new ListViewItem(new[] { "Build Number", info.BuildNumber });
            BuildNumberItem.Group = lvg;
            listViewHardware.Items.Add(BuildNumberItem);

            var BuildTypeItem = new ListViewItem(new[] { "Build Type", info.BuildType });
            BuildTypeItem.Group = lvg;
            listViewHardware.Items.Add(BuildTypeItem);

            var CaptionItem = new ListViewItem(new[] { "Caption", info.Caption });
            CaptionItem.Group = lvg;
            listViewHardware.Items.Add(CaptionItem);

            var CodeSetItem = new ListViewItem(new[] { "Code Set", info.CodeSet });
            CodeSetItem.Group = lvg;
            listViewHardware.Items.Add(CodeSetItem);

            var CountryCodeItem = new ListViewItem(new[] { "Country Code", info.CountryCode });
            CountryCodeItem.Group = lvg;
            listViewHardware.Items.Add(CountryCodeItem);

            var CurrentTimeZoneItem = new ListViewItem(new[] { "Current Time Zone", info.CurrentTimeZone });
            CurrentTimeZoneItem.Group = lvg;
            listViewHardware.Items.Add(CurrentTimeZoneItem);

            var DataExecutionPrevention_32BitApplicationsItem = new ListViewItem(new[] { "Data Execution Prevention_32Bit Applications", info.DataExecutionPrevention_32BitApplications });
            DataExecutionPrevention_32BitApplicationsItem.Group = lvg;
            listViewHardware.Items.Add(DataExecutionPrevention_32BitApplicationsItem);

            var DataExecutionPrevention_AvailableItem = new ListViewItem(new[] { "Data Execution Prevention_Available", info.DataExecutionPrevention_Available });
            DataExecutionPrevention_AvailableItem.Group = lvg;
            listViewHardware.Items.Add(DataExecutionPrevention_AvailableItem);

            var DataExecutionPrevention_DriversItem = new ListViewItem(new[] { "Data Execution Prevention_Drivers", info.DataExecutionPrevention_Drivers });
            DataExecutionPrevention_DriversItem.Group = lvg;
            listViewHardware.Items.Add(DataExecutionPrevention_DriversItem);

            var DataExecutionPrevention_SupportPolicyItem = new ListViewItem(new[] { "Data Execution Prevention_Support Policy", info.DataExecutionPrevention_SupportPolicy });
            DataExecutionPrevention_SupportPolicyItem.Group = lvg;
            listViewHardware.Items.Add(DataExecutionPrevention_SupportPolicyItem);

            var DebugItem = new ListViewItem(new[] { "Debug", info.Debug });
            DebugItem.Group = lvg;
            listViewHardware.Items.Add(DebugItem);

            var DescriptionItem = new ListViewItem(new[] { "Description", info.Description });
            DescriptionItem.Group = lvg;
            listViewHardware.Items.Add(DescriptionItem);

            var DistributedItem = new ListViewItem(new[] { "Distributed", info.Distributed });
            DistributedItem.Group = lvg;
            listViewHardware.Items.Add(DistributedItem);

            var EncryptionLevelItem = new ListViewItem(new[] { "Encryption Level", info.EncryptionLevel });
            EncryptionLevelItem.Group = lvg;
            listViewHardware.Items.Add(EncryptionLevelItem);

            var ForegroundApplicationBoostItem = new ListViewItem(new[] { "Foreground Application Boost", info.ForegroundApplicationBoost });
            ForegroundApplicationBoostItem.Group = lvg;
            listViewHardware.Items.Add(ForegroundApplicationBoostItem);

            var FreePhysicalMemoryItem = new ListViewItem(new[] { "Free Physical Memory", info.FreePhysicalMemory });
            FreePhysicalMemoryItem.Group = lvg;
            listViewHardware.Items.Add(FreePhysicalMemoryItem);

            var FreeSpaceInPagingFilesItem = new ListViewItem(new[] { "Free Space In Paging Files", info.FreeSpaceInPagingFiles });
            FreeSpaceInPagingFilesItem.Group = lvg;
            listViewHardware.Items.Add(FreeSpaceInPagingFilesItem);

            var FreeVirtualMemoryItem = new ListViewItem(new[] { "Free Virtual Memory", info.FreeVirtualMemory });
            FreeVirtualMemoryItem.Group = lvg;
            listViewHardware.Items.Add(FreeVirtualMemoryItem);

            var InstallDateItem = new ListViewItem(new[] { "Install Date", info.InstallDate });
            InstallDateItem.Group = lvg;
            listViewHardware.Items.Add(InstallDateItem);

            var LargeSystemCacheItem = new ListViewItem(new[] { "Large System Cache", info.LargeSystemCache });
            LargeSystemCacheItem.Group = lvg;
            listViewHardware.Items.Add(LargeSystemCacheItem);

            var LastBootUpTimeItem = new ListViewItem(new[] { "Last Boot Up Time", info.LastBootUpTime });
            LastBootUpTimeItem.Group = lvg;
            listViewHardware.Items.Add(LastBootUpTimeItem);

            var LocalDateTimeItem = new ListViewItem(new[] { "Local Date Time", info.LocalDateTime });
            LocalDateTimeItem.Group = lvg;
            listViewHardware.Items.Add(LocalDateTimeItem);

            var LocaleItem = new ListViewItem(new[] { "Locale", info.Locale });
            LocaleItem.Group = lvg;
            listViewHardware.Items.Add(LocaleItem);

            var ManufacturerItem = new ListViewItem(new[] { "Manufacturer", info.Manufacturer });
            ManufacturerItem.Group = lvg;
            listViewHardware.Items.Add(ManufacturerItem);

            var MaxNumberOfProcessesItem = new ListViewItem(new[] { "Max Number Of Processes", info.MaxNumberOfProcesses });
            MaxNumberOfProcessesItem.Group = lvg;
            listViewHardware.Items.Add(MaxNumberOfProcessesItem);

            var MaxProcessMemorySizeItem = new ListViewItem(new[] { "Max Process Memory Size", info.MaxProcessMemorySize });
            MaxProcessMemorySizeItem.Group = lvg;
            listViewHardware.Items.Add(MaxProcessMemorySizeItem);

            //var MUILanguagesItem = new ListViewItem(new[] { "MUI Languages", info.MUILanguages });
            //MUILanguagesItem.Group = lvg;
            //listViewHardware.Items.Add(MUILanguagesItem);

            var NameItem = new ListViewItem(new[] { "Name", info.Name });
            NameItem.Group = lvg;
            listViewHardware.Items.Add(NameItem);

            var NumberOfLicensedUsersItem = new ListViewItem(new[] { "Number Of Licensed Users", info.NumberOfLicensedUsers });
            NumberOfLicensedUsersItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfLicensedUsersItem);


            var NumberOfProcessesItem = new ListViewItem(new[] { "Number Of Processes", info.NumberOfProcesses });
            NumberOfProcessesItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfProcessesItem);

            var NumberOfUsersItem = new ListViewItem(new[] { "Number Of Users", info.NumberOfUsers });
            NumberOfUsersItem.Group = lvg;
            listViewHardware.Items.Add(NumberOfUsersItem);

            var OrganizationItem = new ListViewItem(new[] { "Organization", info.Organization });
            OrganizationItem.Group = lvg;
            listViewHardware.Items.Add(OrganizationItem);

            var OSArchitectureItem = new ListViewItem(new[] { "OS Architecture", info.OSArchitecture });
            OSArchitectureItem.Group = lvg;
            listViewHardware.Items.Add(OSArchitectureItem);

            var OSLanguageItem = new ListViewItem(new[] { "OS Language", info.OSLanguage });
            OSLanguageItem.Group = lvg;
            listViewHardware.Items.Add(OSLanguageItem);

            var OSTypeItem = new ListViewItem(new[] { "OS Type", info.OSType });
            OSTypeItem.Group = lvg;
            listViewHardware.Items.Add(OSTypeItem);

            var PAEEnabledItem = new ListViewItem(new[] { "PAE Enabled", info.PAEEnabled });
            PAEEnabledItem.Group = lvg;
            listViewHardware.Items.Add(PAEEnabledItem);

            var PlusProductIDItem = new ListViewItem(new[] { "Plus Product ID", info.PlusProductID });
            PlusProductIDItem.Group = lvg;
            listViewHardware.Items.Add(PlusProductIDItem);

            var PlusVersionNumberItem = new ListViewItem(new[] { "Plus Version Number", info.PlusVersionNumber });
            PlusVersionNumberItem.Group = lvg;
            listViewHardware.Items.Add(PlusVersionNumberItem);

            var PortableOperatingSystemItem = new ListViewItem(new[] { "Portable Operating System", info.PortableOperatingSystem });
            PortableOperatingSystemItem.Group = lvg;
            listViewHardware.Items.Add(PortableOperatingSystemItem);

            var PrimaryItem = new ListViewItem(new[] { "Primary", info.Primary });
            PrimaryItem.Group = lvg;
            listViewHardware.Items.Add(PrimaryItem);

            var ProductTypeItem = new ListViewItem(new[] { "Product Type", info.ProductType });
            ProductTypeItem.Group = lvg;
            listViewHardware.Items.Add(ProductTypeItem);


            var SerialNumberItem = new ListViewItem(new[] { "SerialNumber", info.SerialNumber });
            SerialNumberItem.Group = lvg;
            listViewHardware.Items.Add(SerialNumberItem);

            var StatusItem = new ListViewItem(new[] { "Status", info.Status });
            StatusItem.Group = lvg;
            listViewHardware.Items.Add(StatusItem);

            var SystemDeviceItem = new ListViewItem(new[] { "System Device", info.SystemDevice });
            SystemDeviceItem.Group = lvg;
            listViewHardware.Items.Add(SystemDeviceItem);

            var SystemDriveItem = new ListViewItem(new[] { "System Drive", info.SystemDrive });
            SystemDriveItem.Group = lvg;
            listViewHardware.Items.Add(SystemDriveItem);

            var TotalVirtualMemorySizeItem = new ListViewItem(new[] { "Total Virtual Memory Size", info.TotalVirtualMemorySize });
            TotalVirtualMemorySizeItem.Group = lvg;
            listViewHardware.Items.Add(TotalVirtualMemorySizeItem);

            var TotalVisibleMemorySizeItem = new ListViewItem(new[] { "Total Visible Memory Size", info.TotalVisibleMemorySize });
            TotalVisibleMemorySizeItem.Group = lvg;
            listViewHardware.Items.Add(TotalVisibleMemorySizeItem);

            var VersionItem = new ListViewItem(new[] { "Version", info.Version });
            VersionItem.Group = lvg;
            listViewHardware.Items.Add(VersionItem);

            var WindowsDirectoryItem = new ListViewItem(new[] { "Windows Directory", info.WindowsDirectory });
            WindowsDirectoryItem.Group = lvg;
            listViewHardware.Items.Add(WindowsDirectoryItem);
        }

        private void btnDiskParition_Click(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");
        }
    }
}
