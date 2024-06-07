using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace RDPClientApplication
{
    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceId, string name, string description)
        {
            DeviceId = deviceId;
            Name = name;
            Description = description;
        }

        public string DeviceId { get; }
        public string Name { get; }
        public string Description { get; }

        public override string ToString()
        {
            return Name;
        }
    }
    public partial class USBDevices : Form
    {
        public USBDevices()
        {
            InitializeComponent();
        }

        private void USBDevices_Load(object sender, EventArgs e)
        {
            GetUSBDevices();

        }
        static List<USBDeviceInfo> GetUSBDevices()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_USBHub");
            mbsList = mbs.Get();

            foreach (ManagementObject mo in mbsList)
            {
                Console.WriteLine("USBHub device Friendly name:{0}", mo["Name"].ToString());
            }
            var devices = new List<USBDeviceInfo>();

            using (var mos = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity"))
            {
                using (ManagementObjectCollection collection = mos.Get())
                {
                    foreach (var device in collection)
                    {
                        var id = device.GetPropertyValue("DeviceId") == null ?"": device.GetPropertyValue("DeviceId").ToString();

                        //if (!id.StartsWith("USB", StringComparison.OrdinalIgnoreCase))
                        //    continue;

                        var name = device.GetPropertyValue("Name") == null ?"" : device.GetPropertyValue("Name").ToString();
                        var description = device.GetPropertyValue("Description") == null ? "" : device.GetPropertyValue("Description").ToString();
                        Console.WriteLine(id +" - " + name + " - " + description
                            );
                        devices.Add(new USBDeviceInfo(id.ToString(), name.ToString(), description.ToString()));
                    }
                }
            }

            return devices;
        }

        

    }
}
