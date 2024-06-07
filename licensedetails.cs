using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Management;
using System.Management.Automation;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class licensedetails : Form
    {
        private DataTable softwareTable;

        public licensedetails()
        {
            InitializeComponent();
            InitializeSoftwareTable();
        }

        private void licensedetails_Load(object sender, EventArgs e)
        {
            DisplaySoftwareLicenseDetails();
            DisplayAboutPC();
        }

        private void InitializeSoftwareTable()
        {
            softwareTable = new DataTable();
            softwareTable.Columns.Add("Software Name");
            softwareTable.Columns.Add("Version");
            softwareTable.Columns.Add("Vendor");
            softwareTable.Columns.Add("Install Date");
            softwareTable.Columns.Add("License Key");
        }

        private void DisplaySoftwareLicenseDetails()
        {
            softwareTable.Clear();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

                foreach (ManagementObject product in searcher.Get())
                {
                    string name = product["Name"]?.ToString();
                    string version = product["Version"]?.ToString();
                    string vendor = product["Vendor"]?.ToString();
                    string installDate = product["InstallDate"]?.ToString();

                    string licenseKey = GetLicenseKey(name);

                        softwareTable.Rows.Add(name, version, vendor,installDate, licenseKey);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving software license details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewSoftware.DataSource = softwareTable;
        }

        private void DisplayAboutPC()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach(ManagementObject os in searcher.Get())
            {
                // Extract device name
                string deviceName = Environment.MachineName;

                // Extract installed RAM
                ulong installedRAMBytes = Convert.ToUInt64(os["TotalVisibleMemorySize"]);
                ulong installedRAMMB = installedRAMBytes / (1024 * 1024); // Convert bytes to megabytes

                // Extract product ID
                string productID = os["SerialNumber"].ToString();

                // Extract Windows edition
                string windowsEdition = os["Caption"].ToString();

                // Extract Windows version
                string windowsVersion = os["Version"].ToString();

                // Extract license key (from registry)
                string licenseKey = GetWindowsProductKey();

                // Print extracted information
                textBox1_DeviceName.Text = deviceName.ToString();
                textBox_InstalledRam.Text = installedRAMMB.ToString();
                textBox_ProductID.Text = productID.ToString();
                textBox_Edition.Text = windowsEdition.ToString();
                textBox_Version.Text = windowsVersion.ToString();
                textBox_LicenseKey.Text = licenseKey;
            }
        }

        // Method to retrieve Windows product key from registry
        static string GetWindowsProductKey()
        {
            string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string keyName = "DigitalProductId";
            string productKey = "N/A";

            try
            {
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(keyPath))
                {
                    if (registryKey != null)
                    {
                        byte[] digitalProductId = (byte[])registryKey.GetValue(keyName);
                        if (digitalProductId != null)
                        {
                            productKey = DecodeProductKey(digitalProductId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the Windows product key: {ex.Message}");
            }

            return productKey;
        }

        static string DecodeProductKey(byte[] digitalProductId)
        {
            const int keyOffset = 52;
            const int keyLength = 15;
            string chars = "BCDFGHJKMPQRTVWXY2346789";
            char[] decodedChars = new char[keyLength];
            byte[] key = new byte[keyLength];

            for (int i = 0; i < keyLength; i++)
            {
                key[i] = digitalProductId[keyOffset + i];
            }

            for (int i = keyLength - 1; i >= 0; i--)
            {
                int value = 0;
                for (int j = keyLength - 1; j >= 0; j--)
                {
                    value = (value << 8) | key[j];
                    key[j] = (byte)(value / 24);
                    value %= 24;
                }
                decodedChars[i] = chars[value];
            }

            string productKey = new string(decodedChars);
            for (int i = 4; i < productKey.Length; i += 5)
            {
                productKey = productKey.Insert(i, "-");
            }

            return productKey;
        }
        private string GetLicenseKey(string softwareName)
        {
            string licenseKey = GetLicenseKeyFromRegistry(softwareName);

            if (licenseKey == "N/A")
            {
                licenseKey = SearchLicenseKeyInFiles(softwareName);
            }

            return licenseKey;
        }

        private string GetLicenseKeyFromRegistry(string softwareName)
        {
            string licenseKey = "N/A";

            try
            {
                string[] registryPaths = new string[]
                {
                    $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{softwareName}",
                    $@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\{softwareName}",
                    $@"SOFTWARE\{softwareName}"
                };

                foreach (string registryPath in registryPaths)
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
                    {
                        if (key != null)
                        {
                            string[] valueNames = new string[] { "LicenseKey", "Serial", "SerialNumber", "ProductKey" };

                            foreach (string valueName in valueNames)
                            {
                                object keyValue = key.GetValue(valueName);
                                if (keyValue != null)
                                {
                                    licenseKey = keyValue.ToString();
                                    return licenseKey;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the license key from the registry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return licenseKey;
        }

        private string SearchLicenseKeyInFiles(string softwareName)
        {
            string licenseKey = "N/A";
            string[] programFilesPaths = new string[]
            {
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
            };

            foreach (string programFilesPath in programFilesPaths)
            {
                string softwarePath = Path.Combine(programFilesPath, softwareName);

                if (Directory.Exists(softwarePath))
                {
                    string[] licenseFiles = Directory.GetFiles(softwarePath, "*.lic", SearchOption.AllDirectories)
                                                     .Concat(Directory.GetFiles(softwarePath, "*.key", SearchOption.AllDirectories))
                                                     .Concat(Directory.GetFiles(softwarePath, "*.cfg", SearchOption.AllDirectories))
                                                     .Concat(Directory.GetFiles(softwarePath, "*.conf", SearchOption.AllDirectories))
                                                     .ToArray();

                    foreach (string licenseFile in licenseFiles)
                    {
                        licenseKey = File.ReadAllText(licenseFile);
                        if (!string.IsNullOrEmpty(licenseKey))
                        {
                            return licenseKey;
                        }
                    }
                }
            }

            return licenseKey;
        }




        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_Search.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataRow[] foundRows = softwareTable.Select($"[Software Name] LIKE '%{searchTerm}%'");

                if (foundRows.Length > 0)
                {
                    DataTable searchResultTable = foundRows.CopyToDataTable();
                    dataGridViewSoftware.DataSource = searchResultTable;
                }
                else
                {
                    MessageBox.Show("No software found with the specified name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Display all software when search term is empty
                dataGridViewSoftware.DataSource = softwareTable;
            }
        }



        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
