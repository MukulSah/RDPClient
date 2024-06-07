using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class NetworkForm : Form
    {
        public NetworkForm()
        {
            InitializeComponent();
            GetNetworkDetails();
        }
        
        public void GetNetworkDetails()
        {
            try
            {
                var Desktopname = Environment.MachineName;
                textBox_Desktopname.Text = Desktopname;
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                if(networkInterfaces.Length > 0)
                {
                    NetworkInterface networkInterface = networkInterfaces[0];
                    NetworkClass networkClass = new NetworkClass
                    {
                        Name = networkInterface.Name,
                        Description = networkInterface.Description,
                        Id = networkInterface.Id,
                        Status = networkInterface.OperationalStatus,
                        Speed = networkInterface.Speed / 1000000, // Convert to Mbps
                        MacAddress = networkInterface.GetPhysicalAddress().ToString()
                    };

                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                    foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            networkClass.IPv4Address = ip.Address.ToString();
                            networkClass.IPv4SubnetMask = ip.IPv4Mask?.ToString();
                        }
                        else if (ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                        {
                            networkClass.IPv6Address = ip.Address.ToString();
                        }
                    }

                    //populate the fields
                    textBox_Name.Text = networkClass.Name;
                    textBox_Description.Text = networkClass.Description;
                    textBox_Id.Text = networkClass.Id;
                    textBox_Status.Text = networkClass.Status.ToString();
                    textBox_speed.Text = networkClass.Speed.ToString();
                    textBox_MacAddress.Text = networkClass.MacAddress;
                    textBox_Ipv4address.Text = networkClass.IPv4Address;
                    textBox_IPv6address.Text = networkClass.IPv6Address;
                    textBox_SubnetMask.Text = networkClass.IPv4SubnetMask;  

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something went wrong{ex.Message}");
            }
        }




    }
}
