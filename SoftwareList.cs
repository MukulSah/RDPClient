using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class SoftwareList : Form
    {
        List<Software> softwareList = new List<Software>();
        public SoftwareList()
        {
            InitializeComponent();
        }

        private void SoftwareList_Load(object sender, EventArgs e)
        {
            sftDetails.Visible = false;
            pictureBox1.Image = Constant.ResizeImage(Properties.Resources.Loading_icon, pictureBox1.Size);
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;
        }

        private async void SoftwareList_Shown(object sender, EventArgs e)
        {
            bool success = await Task.Factory.StartNew(() => ReadSoftwareDetails());
            if (success)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Description", typeof(string)));
                dt.Columns.Add(new DataColumn("InstalDate", typeof(string)));
                dt.Columns.Add(new DataColumn("InstallLocation", typeof(string)));
                dt.Columns.Add(new DataColumn("Language", typeof(string)));
                dt.Columns.Add(new DataColumn("Vendor", typeof(string)));
                dt.Columns.Add(new DataColumn("Version", typeof(string)));
                dt.Columns.Add(new DataColumn("ProductID", typeof(string)));
                dt.Columns.Add(new DataColumn("LastUse", typeof(string)));
                foreach (Software sft in softwareList)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = sft.name;
                    dr["Description"] = sft.description;
                    dr["InstallLocation"] = sft.installationLocation;

                    dr["InstalDate"] = sft.productId;
                    dr["Vendor"] = sft.vendor;
                    dr["Version"] = sft.softwareVersion;
                    dr["LastUse"] = sft.lastUse;


                    dt.Rows.Add(dr);
                }
                sftDetails.DataSource = dt;
                sftDetails.RowHeadersVisible = false;
                sftDetails.AllowUserToAddRows = false;
                pictureBox1.Visible = false;
                sftDetails.Visible = true;
            }

           
            


        }

        public bool ReadSoftwareDetails()
        {
            try
            {
                SelectQuery Sq = new SelectQuery("Win32_Product");
                ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
                ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                foreach (ManagementObject MO in osDetailsCollection)
                {
                    Software sft = new Software();
                    sft.name = MO["Name"] == null ? "" : MO["Name"].ToString();
                    
                    sft.description = MO["Description"] == null ? "" : MO["Description"].ToString();
                    sft.installationLocation = MO["InstallLocation"] == null ? " " : MO["InstallLocation"].ToString();
                    var newDate = MO["InstallDate"] == null ? DateTime.Now : DateTime.ParseExact(MO["InstallDate"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
                    // var date2 = MO["InstallDate"].ToString("dd-MM-yyyy");
                    sft.installationDate = newDate.ToString("MM/dd/yyyy");
                    sft.productId = MO["ProductID"] == null ? " " : MO["ProductID"].ToString();
                   // GetIconForRoot(sft.productId);
                    sft.vendor = MO["Vendor"] == null ? "" : MO["Vendor"].ToString();
                    sft.softwareVersion = MO["Version"] == null ? "" : MO["Version"].ToString();
                    var installoc = MO["InstallLocation"];
                    if (installoc != null)
                    {
                        DateTime lastModified = System.IO.File.GetLastWriteTime(@"" + sft.installationLocation + "");
                        sft.lastUse = lastModified;
                    }

                    sft.expiryDate = "";
                    sft.desktopName = StartUp.client.name;
                    sft.processorId = StartUp.client.processorId;
                    DatabaseConnection.SaveSoftwareDetails(sft);
                    softwareList.Add(sft);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        private Icon GetIconForRoot(string productName)
        {
            string producticon = "";
            string InstallerKey = @"Installer\Products\" + productName;
            using (RegistryKey installkeys = Registry.ClassesRoot.OpenSubKey(InstallerKey))
            {
               
                    using (RegistryKey product = installkeys.OpenSubKey(InstallerKey))
                    {
                        if (product.GetValue("ProductName") != null)
                        {
                            if (productName == product.GetValue("ProductName").ToString())
                            {
                                if (product.GetValue("ProductIcon") != null)
                                {
                                    producticon = product.GetValue("ProductIcon").ToString();
                                    Console.WriteLine("inside icon");
                                    Console.WriteLine(producticon);

                                }
                            }
                        }
                    
                }
            }
            if (Icon.ExtractAssociatedIcon(producticon) != null)
                return Icon.ExtractAssociatedIcon(producticon);
            else
                return null;
        }
    }
}
