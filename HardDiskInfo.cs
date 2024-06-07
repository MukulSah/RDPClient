using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDPClientApplication
{
    class HardDiskInfo
    {
        public string Name { get; private set; }
        public string DriveFormat { get; private set; }
        public string RootDirectory { get; private set; }
        public string TotalSize { get; private set; }
        public string TotalFreeSpace { get; private set; }
        public string VolumeLabel { get; private set; }
        public string AvailableFreeSpace { get; private set; }

        public List<HardDiskInfo> ReadHardDiskInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<HardDiskInfo> details = new List<HardDiskInfo>();
            foreach (DriveInfo drive in drives)
            {
                HardDiskInfo info = new HardDiskInfo();
                info.Name = drive.Name == null ? "" :drive.Name;
                info.DriveFormat = drive.DriveFormat == null ? "" : drive.DriveFormat;
                info.RootDirectory = drive.RootDirectory == null ? "" : drive.RootDirectory.ToString() ;

                info.TotalSize = drive.TotalSize == null ? "" : FormatBytes(drive.TotalSize);
                info.TotalFreeSpace = drive.TotalFreeSpace == null ? "" : FormatBytes(drive.TotalFreeSpace);
                info.VolumeLabel = drive.VolumeLabel == null ? "" : drive.VolumeLabel;
                info.AvailableFreeSpace = drive.AvailableFreeSpace == null ? "" : FormatBytes(drive.AvailableFreeSpace);
                details.Add(info);
            }
            return details;
        }

        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
