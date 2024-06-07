using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDPClientApplication
{
    class ClientUpdates
    {
        public Client client { get; set; } = new Client();
        public List<Software> unauthorizedSoftwares { get; set; } = new List<Software>();
        public List<Software> insatllationRequestSoftwares { get; set; } = new List<Software>();
    }
}
