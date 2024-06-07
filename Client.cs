using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RDPClientApplication
{
    public class Client
    {
        public string clientId { get; set; }
        public string processorId { get; set; }
        public string name { get; set; }
        public string ipaddress { get; set; }
        public string agentStatus { get; set; }

        public string GetProcessorId()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;
        }

        public string GetDesktopName()
        {
            return System.Environment.MachineName;
        }

        [Obsolete]
        public  string GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }


        public Client AddNewClient()
        {
            string processorid = GetProcessorId();
            string name = GetDesktopName();
            string ipaddress = GetIPAddress();
            Client client = null;
            if (processorid!="" && name != "")
            {
                client = DatabaseConnection.InsertOrUpdateClient(processorid, name,ipaddress).client;
                
            }
            return client;
            
        }
    }
}
