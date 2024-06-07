using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class USBHubForm : Form   //Author: MukulKumarSah
    {
        string machinename = Environment.MachineName;

        public USBHubForm()
        {
            InitializeComponent();
        }

          

        //Form load
        private void USBHubForm_Load(object sender, EventArgs e)
        {
            textBox_Machinename.Text = machinename;
            listBoxUSBDevice.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxUSBDevice.DrawItem += listBoxUSBDevices_DrawItem;
            ListUSBDevices();
        }

        //Referesh button
        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            while (true)
            {
                ListUSBDevices();
                await Task.Delay(20000); //20seconds
            }
        }


        
        // Dictionary to store device informations
        Dictionary<string, string> deviceDictionary = new Dictionary<string, string>();

        //List usb devices
        private void ListUSBDevices()
        {
            listBoxUSBDevice.Items.Clear();
            listBox_USBOtherDetails.Items.Clear();
            deviceDictionary.Clear();
            int count = 0;
            int enabledCount = 0;
            int disabledCount = 0;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Mouse' OR PNPClass = 'Keyboard' OR PNPClass = 'USB'");

                foreach (ManagementObject device in searcher.Get())
                {
                    string deviceId = device["PNPDeviceID"]?.ToString();
                    string description = device["Description"]?.ToString();
                    string deviceClass = device["ClassGuid"]?.ToString();

                    if (deviceId != null && (deviceId.Contains("USB") || deviceClass != null))
                    {
                        string category = "Other USB Device";

                        if (deviceClass != null)
                        {
                            switch (deviceClass.ToUpper())
                            {
                                case "{4D36E96B-E325-11CE-BFC1-08002BE10318}":
                                    category = "Keyboard";
                                    break;
                                case "{4D36E96F-E325-11CE-BFC1-08002BE10318}":
                                    category = "Mouse or Pointing Device";
                                    break;
                                case "{745A17A0-74D3-11D0-B6FE-00A0C90F57DA}":
                                    category = "HID Device";
                                    break;
                            }
                        }

                        bool isEnabled = CheckIfDeviceEnabled(deviceId);
                        if(isEnabled)
                        {
                            enabledCount++;
                        }
                        else
                        {
                            disabledCount++;
                        }

                        listBoxUSBDevice.Items.Add(new ListBoxItem { Description = $"USB {++count}: {description} - {category}", IsEnabled = isEnabled }); //adding data in listbox
                       
                        deviceDictionary.Add($"USB {count}", deviceId);
                    }
                }

                // Adding summary information to listBox_USBOtherDetails
                listBox_USBOtherDetails.Items.Add($"Total USB Devices Found: {count}");
                listBox_USBOtherDetails.Items.Add($"Enabled Devices: {enabledCount}");
                listBox_USBOtherDetails.Items.Add($"Disabled Devices: {disabledCount}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while listing USB devices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void USB_taskdetail()
        {
            listBox_USBOtherDetails.Items.Clear();

            try
            {

            }
            catch
            {

            }
        }

        //to check if devices are enabled or not
        private bool CheckIfDeviceEnabled(string deviceId)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPDeviceID = '" + deviceId.Replace("\\", "\\\\") + "'"); // query getting PNPDEviceid and check
                foreach (ManagementObject device in searcher.Get())
                {
                    var statusObject = device["ConfigManagerErrorCode"];
                    if (statusObject != null)
                    {
                        if (int.TryParse(statusObject.ToString(), out int status))
                        {
                            return status == 0; // 0 means the device is working properly
                        }
                        else
                        {
                            // Handle if the value is not an integer
                            MessageBox.Show("ConfigManagerErrorCode is not an integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        // Handle if the property is null
                        MessageBox.Show("ConfigManagerErrorCode is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking device status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        // drawing a green and red dot
        private void listBoxUSBDevices_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            ListBoxItem item = (ListBoxItem)listBoxUSBDevice.Items[e.Index];
            Brush textBrush = Brushes.Black;
            e.Graphics.DrawString(item.Description, e.Font, textBrush, e.Bounds.Left + 20, e.Bounds.Top);

            // Draw the status circle
            Brush circleBrush = item.IsEnabled ? Brushes.Green : Brushes.Red;
            e.Graphics.FillEllipse(circleBrush, e.Bounds.Left + 5, e.Bounds.Top + 5, 14, 14);

            e.DrawFocusRectangle();
        }

        //event trigger for enable usb
        private void button_Enable_Click(object sender, EventArgs e)
        {
            if (listBoxUSBDevice.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)listBoxUSBDevice.SelectedItem;
                string deviceKey = selectedItem.Description.Split(':')[0].Trim();
                if (deviceDictionary.TryGetValue(deviceKey, out string pnpDeviceId))
                {
                    ExecutePowerShellCommand($"Enable-PnpDevice -InstanceId \"{pnpDeviceId}\" -Confirm:$false");
                    ListUSBDevices(); // Refresh the list to update the status
                }
            }
        }

        //event trigger for disable usb
        private void button_Disable_Click(object sender, EventArgs e)
        {
            if (listBoxUSBDevice.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)listBoxUSBDevice.SelectedItem;
                string deviceKey = selectedItem.Description.Split(':')[0].Trim();
                if (deviceDictionary.TryGetValue(deviceKey, out string pnpDeviceId))
                {
                    ExecutePowerShellCommand($"Disable-PnpDevice -InstanceId \"{pnpDeviceId}\" -Confirm:$false");
                    ListUSBDevices(); // Refresh the list to update the status
                }
            }
        }

        //execute powershell for enabling and disabling command 
        private void ExecutePowerShellCommand(string command)
        {
            try
            {
                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(command);
                    powerShell.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing PowerShell command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // class is added for more prop defined
        class ListBoxItem
        {
            public string Description { get; set; }
            public bool IsEnabled { get; set; }
        }


    }
}

