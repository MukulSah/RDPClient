using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using SharpAvi;
using SharpAvi.Output;
using SharpAvi.Codecs;
using System.Runtime.InteropServices;


namespace RDPClientApplication
{
    public partial class ControlPanel : Form
    {

        string serverprocessorid;
        public ControlPanel()
        {
            InitializeComponent();

            this.serverprocessorid = serverprocessorid;
            // this.ShowInTaskbar = false;
            Screen rightmost = Screen.AllScreens[0];
            this.Left = (rightmost.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = 0;
            btnHardware.Image = StartUp.ResizeImage(Properties.Resources.hardware_icon1, btnHardware.Size);
        }

        //for recoding esckey
      
        public ControlPanel(string serverprocessorid)
        {
            InitializeComponent();
            this.serverprocessorid = serverprocessorid;
           // this.ShowInTaskbar = false;
            Screen rightmost = Screen.AllScreens[0];
            this.Left = (rightmost.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = 0;
            btnHardware.Image = StartUp.ResizeImage(Properties.Resources.hardware_icon1, btnHardware.Size);
            //Set status of all menu strip items
          //  SetMenuStripValues();
           
        }

    

        //private void SetMenuStripValues()
        //{
        //    //read usb status
        //    Dictionary<string, int> clientStatus = DatabaseConnection.ReadUsbPortsStatus(StartUp.client.processorId);
        //    if (clientStatus["usb"] == 0)
        //    {
        //       // menuStripHardware.Items[2].Text = "Disable USB Ports";
        //    }
        //    else
        //    {
        //        menuStripHardware.Items[2].Text = "Enable USB Ports";
        //    }
        //}
       
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btnSoftware_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSoftware_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rc = btnSoftware.Bounds;
            menuStripSoftware.Show(new Point(this.Left + rc.X,  rc.Y + btnSoftware.Height));
        }

        private void btnSoftware_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void menuStripSoftware_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DatabaseConnection.StopClient(StartUp.client.processorId, serverprocessorid);
            Application.Exit();
        }

        private void btnHardware_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rc = btnHardware.Bounds;
            menuStripHardware.Show(new Point(this.Left + rc.X, rc.Y + btnHardware.Height));
        }

        private void hardwareDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fetch hardware details and save it to database
            //show it on UI
            var com = new HardwareDetails();
            com.ShowDialog();
        }

        private void uSBDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  var com = new ShowUSBDevices();
          //  com.ShowDialog();
        }

        private void upDateLicenseMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void menuStripSoftware_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void menuStripUsers_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rc = btnUsers.Bounds;
            menuStripUsers.Show(new Point(this.Left + rc.X, rc.Y + btnUsers.Height));
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            menuStripUsers.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            DatabaseConnection.MinimizeScreen(serverprocessorid);
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHardware_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rc = btnHardware.Bounds;
            menuStripHardware.Show(new Point(this.Left + rc.X, rc.Y + btnHardware.Height));
        }

        private void btnHardware_MouseLeave(object sender, EventArgs e)
        {
          //  menuStripHardware.Hide();
        }

        private void btnSoftware_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rc = btnSoftware.Bounds;
            menuStripSoftware.Show(new Point(this.Left + rc.X, rc.Y + btnSoftware.Height));
        }

        private void btnSoftware_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void menuStripHardware_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;


            switch (itemText)
            {
                case "Hardware Details":
                    //do stuff
                    
                    break;

                case "USB Devices":
                    // do stuff
                   
                    break;
                case "Uninstall Software":
                    // do stuff
                    break;
            }
        }

        private void menuStripHardware_MouseLeave(object sender, EventArgs e)
        {
            menuStripHardware.Hide();
        }

        private void usbDevicesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //usbdevicesdialog = new ShowUSBDevices(); old form
            var usbdevicesdialog = new USBHubForm();
            usbdevicesdialog.ShowDialog();
        }
        
        private void hardwareDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var com = new HardwareAllDetails();
            com.ShowDialog();
        }

        private void softwareListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var com = new ListSoftwares();
            com.ShowDialog();
        }

        private void addNewSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var com = new ServerSoftwares();
            com.ShowDialog();
        }

        private void viewLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showlicenses = new licensedetails();
            showlicenses.ShowDialog();
        }

        private void addNewSoftwareToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void uninstallSoftwareMenuItem_Click(object sender, EventArgs e)
        {
            var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            System.Diagnostics.Process.Start(cplPath, "/name Microsoft.ProgramsAndFeatures");
        }

        private void menuStripSoftware_MouseLeave(object sender, EventArgs e)
        {
            menuStripSoftware.Hide();
        }

        private void licenseUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var com = new LicenseUpdate();
            com.ShowDialog();
        }

        private void diableInstallationUninstallationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            Console.WriteLine(user);


            string key = @"Software\\Policies\\Microsoft\\Windows\\Installer";

            try
            {
                RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                RegistryKey registry = localMachine.OpenSubKey(key, true);
                Console.WriteLine(registry);
                if (registry != null)
                {
                    Console.WriteLine(registry.GetValue("DisableMSI").ToString());
                    if (registry.GetValue("DisableMSI").ToString() == "0")
                    {
                        registry.SetValue("DisableMSI", 2);
                        Console.WriteLine($"You don't have perminssions to install software. - {registry.GetValue("DisableMSI").ToString()}");
                    }
                    else if (registry.GetValue("DisableMSI").ToString() == "2")
                    {
                        registry.SetValue("DisableMSI", 0);
                        Console.WriteLine($"You have perminssions to install software. - {registry.GetValue("DisableMSI").ToString()}");
                    }
                    Console.WriteLine(registry.GetValue("DisableMSI").ToString());
                    registry.Close();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Regsitry key doesn't exists");
                    Console.ReadLine();


                    RegistryKey registryCreate = localMachine.CreateSubKey(key);

                    registryCreate.SetValue("DisableMSI", 2, RegistryValueKind.DWord);
                    Console.WriteLine($"You don't have perminssions to intsall software. - {registryCreate.GetValue("DisableMSI").ToString()}");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }

        private void disableUSBPortsToolStripMenuItem_Click(object sender, EventArgs e)
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
                        if (menuStripHardware.Items[2].Text == "Disable USB Ports")
                        {
                            registry.SetValue("Deny_All", 1);
                            menuStripHardware.Items[2].Text = "Enable USB Ports";
                            DatabaseConnection.SaveUSBStatus(1, StartUp.client.processorId);
                        }
                        else if (menuStripHardware.Items[2].Text == "Enable USB Ports")
                        {
                            registry.SetValue("Deny_All", 0);
                            menuStripHardware.Items[2].Text = "Disable USB Ports";
                            DatabaseConnection.SaveUSBStatus(0, StartUp.client.processorId);
                        }


                       

                    }
                    else
                    {


                        RegistryKey registryCreate = localMachine.CreateSubKey(key);

                        if (menuStripHardware.Items[2].Text == "Disable USB Ports")
                        {
                            registry.SetValue("Deny_All", 1);
                            menuStripHardware.Items[2].Text = "Enable USB Ports";
                            DatabaseConnection.SaveUSBStatus(1, StartUp.client.processorId);
                        }
                        if (menuStripHardware.Items[2].Text == "Enable USB Ports")
                        {
                            registry.SetValue("Deny_All", 0);
                            menuStripHardware.Items[2].Text = "Disable USB Ports";
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


        //btnNetworkToolstrip
        private void btnNetwork_Click(object sender, EventArgs e)
        {
            var ShownetworkForm = new NetworkForm();
            ShownetworkForm.ShowDialog();
        }


        //btnTool
        private void btnTools_Click(object sender, EventArgs e)
        {
            Rectangle rc = btnTools.Bounds;
           // Tool_MenuStrip.Show();
            Tool_MenuStrip.Show(new Point(this.Left + rc.X, rc.Y + btnTools.Height));
        }

        private void takeScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a directory name "snapshot" in the Pictures Folder
                string picturePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string snapshotFolderpath = Path.Combine(picturePath, "SnapShot");

                if(!Directory.Exists(snapshotFolderpath))
                {
                    Directory.CreateDirectory(snapshotFolderpath);
                }

                //Generate a unique filename for the snapshot;
                string filename = $"MacoInfotech_SS_{DateTime.Now:yyyyMMdd_HHmm}.png";
                string filepath = Path.Combine(snapshotFolderpath, filename);

                //Capture the screen
                Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                Graphics graphics = Graphics.FromImage(screenshot);
                graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

                //Save the screenshot
                screenshot.Save(filepath, ImageFormat.Png);

                //Notify
                MessageBox.Show($"Screenshot saved to: {filepath}", "Screenshot Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while taking the screenshot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var videoControlForm = new videoplayback_controlform();
            videoControlForm.Show();
        }

    }
}
