using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class ShowUSBDevices : Form
    {
        
        public ShowUSBDevices()
        {
            InitializeComponent();
            USBDevicesInfo.ReadPortableDisksDetails();
        }

        private void ShowUSBDevices_Load(object sender, EventArgs e)
        {
            pictureBox1.Text = "";
            myListView.Visible = false;



        }

        private void ShowMouseProperties()
        {
            Process p;
            p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("control.exe mouse");
            p.StandardInput.Flush();
            p.StandardInput.Close();
            Console.WriteLine(p.StandardOutput.ReadToEnd());
        }

        private void ShowKeyBoardProperties()
        {
            Process p;
            p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("control.exe keyboard");
            p.StandardInput.Flush();
            p.StandardInput.Close();
            Console.WriteLine(p.StandardOutput.ReadToEnd());
        }

       

        private void myListView_ItemActivate(object sender, EventArgs e)
        {
            var itemName = myListView.FocusedItem.Name;
            if (itemName.ToLower().Contains("keyboard"))
            {
                ShowKeyBoardProperties();
                return;
            }
            if (itemName.ToLower().Contains("mouse"))
            {
                ShowMouseProperties();
                return;
            }
            if (itemName.ToLower().Contains("printer"))
            {
                ShowPrinterProperties(myListView.FocusedItem.Text);
            }
        }

        private void ShowPrinterProperties(string printername)
        {
            string printerName = printername; // Change this with your printer name 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new
            System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C rundll32 printui.dll,PrintUIEntry /p /n \"" + printerName + "\"";
            process.StartInfo = startInfo;
            process.Start();
        }

        private async void ShowUSBDevices_Shown(object sender, EventArgs e)
        {
            
            System.Windows.Forms.ImageList imageListDevices = new ImageList();
            imageListDevices.ImageSize = new Size(64, 64);
            System.Windows.Forms.ImageList imageListPrinters = new ImageList();
            imageListPrinters.ImageSize = new Size(64, 64);

            ListViewGroup lvGroupDevices = new ListViewGroup("Devices", HorizontalAlignment.Left);

            ListViewGroup lvGroupPrinters = new ListViewGroup("Printers", HorizontalAlignment.Left);

            ListViewGroup lvGroupPortableDisks = new ListViewGroup("Portable Disks", HorizontalAlignment.Left);

            myListView.Groups.AddRange(new ListViewGroup[] { lvGroupDevices, lvGroupPrinters });

            //read keyboard details
            List<string> keyboardFriendlyName = USBDevicesInfo.ReadKeyboardDetails();

            //read mouse details
            List<string> mouseFriendlyNames = USBDevicesInfo.ReadMouseDetails();

            //read printer details
            List<string> printerFriendlyNames = USBDevicesInfo.ReadPrinterDetails();

            //show keyboard details
            int indexDevices = 0;
            if (keyboardFriendlyName.Count > 0)
            {
                foreach (string name in keyboardFriendlyName)
                {
                    imageListDevices.Images.Add("keyboard", Properties.Resources.keyboard_icon);

                    ListViewItem listViewItem = myListView.Items.Add(name, indexDevices);
                    listViewItem.Name = "keyboard";

                    indexDevices++;
                }
            }

            //show mouse details

            if (mouseFriendlyNames.Count > 0)
            {
                myListView.Groups.Add(lvGroupPortableDisks);
                foreach (string name in mouseFriendlyNames)
                {
                    imageListDevices.Images.Add(Properties.Resources.mouse_icon);

                    ListViewItem listViewItem = myListView.Items.Add(name, indexDevices);
                    listViewItem.Name = "mouse";
                    indexDevices++;
                }
            }

            //show printer details
            int indexPrinters = indexDevices;

            for (int a = 0; a < indexDevices; a++)
            {
                myListView.Items[a].Group = myListView.Groups[0];
            }

            if (printerFriendlyNames.Count > 0)
            {
                foreach (string name in printerFriendlyNames)
                {
                    imageListDevices.Images.Add(Properties.Resources.printer_icon);
                    ListViewItem listViewItem = myListView.Items.Add(name, indexDevices);
                    listViewItem.Name = "printer";
                    indexDevices++;
                }
            }

            myListView.LargeImageList = imageListDevices;


            for (int a = indexPrinters; a < indexDevices; a++)
            {
                myListView.Items[a].Group = myListView.Groups[1];
            }

            int indexProtableDevices = indexDevices;
            List<string> portableDisksName = USBDevicesInfo.ReadPortableDisksDetails();

            if (portableDisksName.Count > 0)
            {
                foreach (string name in portableDisksName)
                {
                    imageListDevices.Images.Add(Properties.Resources.disk_icon);
                    ListViewItem listViewItem = myListView.Items.Add(name, indexDevices);
                    listViewItem.Name = "disks";
                    indexDevices++;
                }
            }

            for (int a = indexProtableDevices; a < indexDevices; a++)
            {
                myListView.Items[a].Group = myListView.Groups[2];
            }
            pictureBox1.Visible = false;
            myListView.Visible = true;
        }

        private void btnViewProperties_Click(object sender, EventArgs e)
        {
            var itemName = myListView.FocusedItem.Name;
            if (itemName.ToLower().Contains("keyboard"))
            {
                ShowKeyBoardProperties();
                return;
            }
            if (itemName.ToLower().Contains("mouse"))
            {
                ShowMouseProperties();
                return;
            }
            if (itemName.ToLower().Contains("printer"))
            {
                ShowPrinterProperties(myListView.FocusedItem.Text);
            }
        }

        private void btnDriverUpdate_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void btnRenoveDevice_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDisableUSBPorts_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to changes USB Ports ?", "Disable USB Ports", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string key = @"Software\\Policies\\Microsoft\\Windows\\RemovableStorageDevices";

                try
                {
                    RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                    RegistryKey registry = localMachine.OpenSubKey(key, true);
                    Console.WriteLine(registry);
                    if (registry != null)
                    {
                        if (btnDisableUSBPorts.Text == "Disable USB Ports")
                        {
                            registry.SetValue("Deny_All", 1);
                            btnDisableUSBPorts.Text = "Enable USB Ports";
                            DatabaseConnection.SaveUSBStatus(1, StartUp.client.processorId);
                        }
                        else if (btnDisableUSBPorts.Text == "Enable USB Ports")
                        {
                            registry.SetValue("Deny_All", 0);
                            btnDisableUSBPorts.Text = "Disable USB Ports";
                            DatabaseConnection.SaveUSBStatus(0, StartUp.client.processorId);
                        }




                    }
                    else
                    {


                        RegistryKey registryCreate = localMachine.CreateSubKey(key);

                        if (btnDisableUSBPorts.Text == "Disable USB Ports")
                        {
                            registry.SetValue("Deny_All", 1);
                            btnDisableUSBPorts.Text = "Enable USB Ports";
                            DatabaseConnection.SaveUSBStatus(1, StartUp.client.processorId);
                        }
                        if (btnDisableUSBPorts.Text == "Enable USB Ports")
                        {
                            registry.SetValue("Deny_All", 0);
                            btnDisableUSBPorts.Text = "Disable USB Ports";
                            DatabaseConnection.SaveUSBStatus(0, StartUp.client.processorId);
                        }



                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadLine();
                }
            }
            else
            {

            }
        }
    }
}
