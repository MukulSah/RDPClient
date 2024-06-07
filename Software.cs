using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public class Software
    {
        public string name { get; set; }
        public string description { get; set; }
        public string installationDate { get; set; }
        public string installationLocation { get; set; }

        public string vendor { get; set; }
       // public string version { get; set; }
        public string productId { get; set; }
        public string processorId { get; set; }
        public string desktopName { get; set; }
        public string expiryDate { get; set; }
        public string time { get; set; }

        public string licenseKey { get; set; }
        public int totalusers { get; set; }
        public int usersleft { get; set; }

        public int licenseValidatedFor { get; set; }
        public DateTime installDate { get; set; }
        public DateTime licenseExpireDate { get; set; }

        public string downloadLink { get; set; }
        public string targetMachine { get; set; }
        public string licenseVersion { get; set; }
        public string softwareVersion { get; set; }

        public int licenseId { get; set; }
        public string serverProcessorId { get; set; }

        public int softwareId { get; set; }

        public string softwareDownloadLocation { get; set; }
        internal string softwareExe;
        internal DateTime lastUse;

        public string softwarePublisher { get; set; }

        public string installationSource { get; set; }
        public string softwareSize { get; set; }

        public string language { get; set; }

        public string displayIcon { get; set; }
        public string uninstallString { get; set; }

        public Image icon { get; set; }


        private static List<Software> blockSoftwares = new List<Software>();
        public static void SoftwareInstallationRequest(List<Software> requestedSoftwares)
        {
            if (requestedSoftwares.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Software Installation Request from server", "Installation Request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
                if (dialogResult == DialogResult.OK)
                {
                    DatabaseConnection.SoftwareInstallationRequestSuccessful("done");
                    var com = new ServerSoftwares(requestedSoftwares);
                    com.ShowDialog();
                }
                else
                {
                    DatabaseConnection.SoftwareInstallationRequestSuccessful("no");
                }
            }
        }

        public static void BlockSoftwareAuthorization(List<Software> softwares)
        {
            //List<Software> softwares = DatabaseConnection.ReadUnauthorizedSoftwares();
            if (blockSoftwares.Count == softwares.Count)
            {
                //check list equal or not
                var list1 = blockSoftwares.OrderBy(item => item.softwareExe).Select(item => item.softwareExe);
                var list2 = softwares.OrderBy(item => item.softwareExe).Select(item => item.softwareExe);
                blockSoftwares = softwares;
                //list is equal
                if (Enumerable.SequenceEqual(list1, list2))
                {

                }
                else
                {
                    var list3 = softwares.Except(blockSoftwares, new NameComparer()).ToList();
                    foreach (Software sft in list3)
                    {
                        AddBlockSoftwareInRegistry(sft.name, sft.softwareExe);
                    }
                    blockSoftwares = softwares;
                }

            }
            else if (blockSoftwares.Count > softwares.Count)
            {
                var list3 = blockSoftwares.Except(softwares, new NameComparer()).ToList();
                foreach (Software sft in list3)
                {
                    RemoveBlockSoftwareInRegistry(sft.name);
                }
                blockSoftwares = softwares;
            }
            else
            {
                var list3 = softwares.Except(blockSoftwares, new NameComparer()).ToList();
                foreach (Software sft in list3)
                {
                    AddBlockSoftwareInRegistry(sft.name, sft.softwareExe);
                }
                blockSoftwares = softwares;
            }



        }

        private static void AddBlockSoftwareInRegistry(string name, string exe)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "DisallowRun", 1);

                Microsoft.Win32.RegistryKey rkey;
                rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun");
                rkey.SetValue(name, exe);
                rkey.Close();
            }
            catch
            {

            }
        }

        private static void RemoveBlockSoftwareInRegistry(string name)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "DisallowRun", 1);

                Microsoft.Win32.RegistryKey rkey;
                rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun");
                rkey.DeleteValue(name);
                rkey.Close();
            }
            catch
            {

            }
        }
    }
    public class NameComparer : IEqualityComparer<Software>
    {
        public int GetHashCode(Software co)
        {
            if (co == null)
            {
                return 0;
            }
            return co.name.GetHashCode();
        }

        public bool Equals(Software x1, Software x2)
        {
            if (object.ReferenceEquals(x1, x2))
            {
                return true;
            }
            if (object.ReferenceEquals(x1, null) ||
                object.ReferenceEquals(x2, null))
            {
                return false;
            }
            return x1.name == x2.name;
        }

       
    }
}
