

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace RDPClientApplication
{
    class USBDevicesInfo
    {

        public string deviceFriendlyName { get; set; }
        public static void ReadUSBDevices()
        {
           


            using (var mos = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity"))
            {
                
                using (ManagementObjectCollection collection = mos.Get())
                {
                    foreach (var device in collection)
                    {
                        var id = device.GetPropertyValue("PNPDeviceID") == null ? "" : device.GetPropertyValue("PNPDeviceID").ToString();

                        //if (!id.StartsWith("USB", StringComparison.OrdinalIgnoreCase))
                        //    continue;

                        var name = device.GetPropertyValue("Name") == null ? "" : device.GetPropertyValue("Name").ToString();
                        var description = device.GetPropertyValue("Description") == null ? "" : device.GetPropertyValue("Description").ToString();
                        
                      
                    }
                }
            }
        }

        public static List<string> ReadKeyboardDetails()
        {

            List<string> keyboardFriendlyNames = new List<string>();
            foreach (var mo in new ManagementObjectSearcher(null, "select * from win32_pnpentity").Get().OfType<ManagementObject>())
            {
                // ask for 2 properties

                var args = new object[] { new string[] { "DEVPKEY_Device_BusReportedDeviceDesc", "DEVPKEY_DEVICE_Manufacturer" }, null };
                // or this works too using the PK's value formatted as string
                //var args = new object[] { new string[] { "DEVPKEY_Device_FriendlyName", "{83DA6326-97A6-4088-9453-A1923F573B29} 10" }, null };

                // call Win32_PnPEntity.GetDeviceProperties
                mo.InvokeMethod("GetDeviceProperties", args);

                var mbos = (ManagementBaseObject[])args[1]; // one mbo for each device property key

                var name = mbos[0].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;

                if (name != null)
                {

                    if (name.ToString().ToLower().Contains(("keyboard")))
                    {
                        
                        var parent = mbos[1].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;
                        if (parent.ToString().Contains("USB"))
                        {
                           
                            keyboardFriendlyNames.Add(name.ToString()); 
                        }
                      
                    }

                }
            }
            return keyboardFriendlyNames;
        }

        public static List<string> ReadMouseDetails()
        {

            List<string> mouseFriendlyNames = new List<string>();
            foreach (var mo in new ManagementObjectSearcher(null, "select * from win32_pnpentity").Get().OfType<ManagementObject>())
            {
                // ask for 2 properties

                var args = new object[] { new string[] { "DEVPKEY_Device_BusReportedDeviceDesc", "DEVPKEY_DEVICE_Manufacturer" }, null };
                // or this works too using the PK's value formatted as string
                //var args = new object[] { new string[] { "DEVPKEY_Device_FriendlyName", "{83DA6326-97A6-4088-9453-A1923F573B29} 10" }, null };

                // call Win32_PnPEntity.GetDeviceProperties
                mo.InvokeMethod("GetDeviceProperties", args);

                var mbos = (ManagementBaseObject[])args[1]; // one mbo for each device property key

                var name = mbos[0].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;

                if (name != null)
                {
                    string str = name.ToString().ToLower();
                    if (str.Contains("mouse"))
                    {
                        
                       
                        var parent = mbos[1].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;
                     if (parent.ToString().ToLower().Contains("system"))
                        {
                           
                            mouseFriendlyNames.Add(name.ToString());
                        }

                    }

                }
            }
            return mouseFriendlyNames;
        }

        public static List<string> ReadPrinterDetails()
        {

            List<string> printerFriendlyNames = new List<string>();
            string query = string.Format("SELECT * from Win32_Printer ");

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            using (ManagementObjectCollection coll = searcher.Get())
            {
                try
                {
                    foreach (ManagementObject printer in coll)
                    {
                       
                        foreach (PropertyData property in printer.Properties)
                        {
                            if(property.Name == "Name")
                            {
                                printerFriendlyNames.Add(property.Value.ToString()) ;
                            }
                           
                        }

                    }
                }
                catch (ManagementException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return printerFriendlyNames;
        }

        public static List<string> ReadPortableDisksDetails()
        {
            List<string> disksFriendlyNames = new List<string>();
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");
            mbsList = mbs.Get();
            string deviceid = "";
            foreach (ManagementObject mo1 in mbsList)
            {
                               
                foreach (PropertyData property in mo1.Properties)
                {
                    Console.WriteLine(property.Name + " - " + property.Value);
                    if (property.Name.ToString() == "Model")
                    {
                        disksFriendlyNames.Add(property.Value.ToString());
                    }
                }

                //Console.WriteLine(deviceid);
                //deviceid = deviceid.Replace(@"\", @"\\");
                //foreach (var mo in new ManagementObjectSearcher(null, @"select * from Win32_Pnpentity where DeviceID like '%" + deviceid + "%'").Get().OfType<ManagementObject>())
                //{
                //    var args = new object[] { new string[] { "DEVPKEY_Device_BusReportedDeviceDesc", "DEVPKEY_Device_Characteristics" }, null };


                //    mo.InvokeMethod("GetDeviceProperties", args);

                //    var mbos = (ManagementBaseObject[])args[1]; // one

                //    var name = mbos[0].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;
                //    if (name != null)
                //    {
                //        Console.WriteLine(name);
                //        var parent = mbos[1].Properties.OfType<PropertyData>().FirstOrDefault(p => p.Name == "Data")?.Value;

                //        if (parent != null)
                //        {
                //            Console.WriteLine(parent.ToString());
                //        }
                        
                //    }
                //    else
                //    {
                //        Console.WriteLine("none");
                //    }
                //}
            }
            return disksFriendlyNames;
        }
    }
}
