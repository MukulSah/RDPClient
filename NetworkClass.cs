using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RDPClientApplication
{
    internal class NetworkClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public OperationalStatus Status { get; set; }
        public long Speed { get; set; } // Speed in Mbps
        public string MacAddress { get; set; }
        public string IPv4Address { get; set; }
        public string IPv4SubnetMask { get; set; }
        public string IPv6Address { get; set; }
    }
}
