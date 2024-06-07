using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RDPClientApplication
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isSuccessful = DatabaseConnection.connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BIOSInfo p = new BIOSInfo();
           // p.ReadBIOSDetails();
           // BIOSInfo.ReadBIOSDetails();
            if (isSuccessful)
            {
                Application.Run(new StartUp());
            }
            else
            {
                MessageBox.Show("Passoword changes for sql");
            }
            
        }
    }
}
