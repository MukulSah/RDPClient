using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDPClientApplication
{
    class License
    {
        public string softwareName { get; set; }
        public string key { get; set; }
        public string version { get; set; }
        public DateTime installDate { get; set; }
        public string totalUsers { get; set; }
        public string usersAssigned { get; set; }
        public string usersLeft { get; set; }
        public DateTime expireDate { get; set; }
        public string timeActivated { get; set; }
        public string processorid { get; set; }
    }
}
