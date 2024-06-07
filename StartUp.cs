using Microsoft.Win32;
using RDPClientApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{ 
    public partial class StartUp : Form
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern void BlockInput([In, MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        public static Client client = new Client();
        static string serverprocessorid = null;
        static string uacValueSetByUser = null;
        private static bool isReadingRequestedData = false;
        KeyboardInput keyInput = null;
        public static bool isKeyboardLocked = false;
        private NotifyIcon trayIcon;
        private static List<Software> blockSoftwares = new List<Software>();
        private static string lastProcessStart = "";
        ManagementEventWatcher startWatch = new ManagementEventWatcher(
      new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
        public StartUp()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

            


            //process file watcher
           
            startWatch.EventArrived
                                += new EventArrivedEventHandler(startWatch_EventArrived);
           
            startWatch.Start();

           
            trayIcon = new NotifyIcon()
            {
                
                Icon = new Icon("maco-icon.ico") ,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Minimize", Minimize), new MenuItem("Maximize", Maximize)
            }),
                Visible = true
            };
            //change uac
            ChangeUACForEleveationPrompt();

            label2.SendToBack();
            client = client.AddNewClient();
            if(client != null)
            {
                lableclientid.Text = client.clientId;
                labeldekstopname.Text = client.name;
                txtDesktopName.Text = client.name;
                txtClientId.Text = client.clientId;
                txtProcessorId.Text = client.processorId;
                txtAgentStatus.Text = client.agentStatus;
                Image img = tickIconPictureBox.ErrorImage;

                tickIconPictureBox.Image = ResizeImage(img, tickIconPictureBox.Size);
            }

            //start storing images
            RemoteControl remoteControl = new RemoteControl(client.processorId);
            RemoteControl.doInsertImage = true;
            Thread task = new Thread(remoteControl.CaptureScreen);
            task.IsBackground = true;
            task.Start();


        }
        static void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            //get list of unauthorized software install
            bool showMessageBox = false;
            List<string> unauthorizedSoftwareList = DatabaseConnection.ReadUnauthorizedInstallSoftware();
            if(unauthorizedSoftwareList.Count > 0)
            {
                int processId = int.Parse(e.NewEvent.Properties["ProcessId"].Value.ToString());
                string processorname = e.NewEvent.Properties["ProcessName"].Value.ToString();
                try
                {
                    Process proc = Process.GetProcessById(processId);
                    string fullPath = proc.MainModule.FileName;
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(fullPath);
                    
                    if (unauthorizedSoftwareList.Contains(myFileVersionInfo.FileDescription))
                    {
                        DatabaseConnection.SaveUnauthorizedSoftwareInstallCount(client.processorId, myFileVersionInfo.FileDescription);
                        if (lastProcessStart.Equals(myFileVersionInfo.FileDescription))
                        {
                            proc.Kill();
                        }
                        else
                        {
                            
                            proc.Kill();
                            var thread = new Thread(() =>
                            {
                               
                                MessageBox.Show("You don't have permission to access " + myFileVersionInfo.FileDescription, "Windows Installer", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });
                            thread.IsBackground = true;
                            thread.Start();
                            lastProcessStart = myFileVersionInfo.FileDescription;
                        }
                       
                    }
                   
                   
                }
                catch (Exception ex)
                {

                }
            }
            
            

        }
        void Minimize(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
           this.WindowState = FormWindowState.Minimized;
          //  trayIcon.Visible = false;

           // Application.Exit();
        }

        void Maximize(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            this.WindowState = FormWindowState.Normal;
            //  trayIcon.Visible = false;

            // Application.Exit();
        }
        //updates the last active time after every 2 secondsd
        private void timer_Tick(object sender, EventArgs e)
        {
            if (client.processorId != "")
            {
                ClientUpdates updates = DatabaseConnection.InsertOrUpdateClient(client.processorId, client.name, client.ipaddress);
                if (updates.insatllationRequestSoftwares.Count > 0)
                {
                    DatabaseConnection.SoftwareInstallationRequestSuccessful("in progress");
                    Software.SoftwareInstallationRequest(updates.insatllationRequestSoftwares);
                }
               

                Software.BlockSoftwareAuthorization(updates.unauthorizedSoftwares);
                Thread taskToBlockSoftware = new Thread(()=>Software.BlockSoftwareAuthorization(updates.unauthorizedSoftwares));
                taskToBlockSoftware.IsBackground = true;
                taskToBlockSoftware.Start();
            }

            
        }


        //check any server request is came or not - check using server processorid field
            //if yes - then start inserting images, reading keyboard and mouse inputs, disable timer
        private void timerForAnyServerRequest_Tick(object sender, EventArgs e)
        {
            
            if (client.processorId != "")
            {
                //check any request to lock client
                bool status = DatabaseConnection.CheckSystemLock(client.processorId);
                if (status)
                {
                    //lock the system
                    if (isKeyboardLocked == false)
                    {
                        keyInput = new KeyboardInput();
                        // BlockInput(true);
                        LockWorkStation();
                        isKeyboardLocked = true;
                    }                     
                }
                else
                {
                    //unlock the system
                    if (isKeyboardLocked == true && keyInput!=null)
                    {
                      //  BlockInput(false);
                        LockWorkStation();
                        keyInput.disposeInput();
                        isKeyboardLocked = false;
                    }
                   
                }

                List<string> serverdetails = DatabaseConnection.IsAnyServerRequestAvailable(client.processorId);
                ControlPanel com = new ControlPanel() ; 
                if (serverdetails != null)
                {
                    this.Hide();
                    com = new ControlPanel(serverdetails[1]);
                    serverprocessorid = serverdetails[1];
                    RemoteControl.serverprocessorid = serverdetails[1];
                    label3.Visible = true;
                    labelservername.Visible = true;
                    txtServerName.Text = serverdetails[0];
                    labelservername.Text = serverdetails[0];
                    Image img = RDPClientApplication.Properties.Resources.tick_icon;

                    tickIconPictureBox.Image = ResizeImage(img, tickIconPictureBox.Size);
                    if(Application.OpenForms["ControlPanel"] == null)
                    {
                        
                        com.ShowDialog();
                    }

                }
                else
                {
                   
                        
                        this.Show();
                   
                    
                    serverprocessorid = null;
                    RemoteControl.serverprocessorid = null;
                    txtServerName.Text = "Blank";
                    label3.Visible = false;
                    labelservername.Visible = false;
                    labelservername.Text = "";

                    Image img = tickIconPictureBox.ErrorImage;
                    tickIconPictureBox.Image = ResizeImage(img, tickIconPictureBox.Size);

                }
            }
           
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        public  static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            // Get the image current width

            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void StartUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetUACForElevationPromptBackToUsersValue();
            DatabaseConnection.StopClient(client.processorId, serverprocessorid);
            startWatch.Stop();
        }

        public void ChangeUACForEleveationPrompt()
        {
            RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);


            RegistryKey uac = localMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            uacValueSetByUser = uac.GetValue("ConsentPromptBehaviorAdmin").ToString();
            Console.WriteLine("value received = " + uac.GetValue("ConsentPromptBehaviorAdmin").ToString());
            if (uac.GetValue("ConsentPromptBehaviorAdmin").ToString() != "0")
            {
                uac.SetValue("ConsentPromptBehaviorAdmin", 0);
            }     
            uac.Close();
        }

        public void SetUACForElevationPromptBackToUsersValue()
        {
            RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);


            RegistryKey uac = localMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            if (uacValueSetByUser != null)
            {
                uac.SetValue("ConsentPromptBehaviorAdmin", Convert.ToInt32(uacValueSetByUser));
            }
            
            
            uac.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var com = new ServerSoftwares();
            com.ShowDialog();
        }

        private void timerForUnauthorizedSoftware_Tick(object sender, EventArgs e)
        {
            Thread taskToBlockSoftware = new Thread(BlockSoftwareAuthorization);
            taskToBlockSoftware.IsBackground = true;
            taskToBlockSoftware.Start();
        }
        private void BlockSoftwareAuthorization()
        {
            List<Software> softwares = DatabaseConnection.ReadUnauthorizedSoftwares();
            if (blockSoftwares.Count == softwares.Count)
            {
                //check list equal or not
                var list1 = blockSoftwares.OrderBy(item => item.softwareExe).Select(item => item.softwareExe);
                var list2 = softwares.OrderBy(item => item.softwareExe).Select(item => item.softwareExe);
                blockSoftwares = softwares;
                //list is equal
                if (Enumerable.SequenceEqual(list1, list2))
                {

                }
                else
                {
                    var list3 = softwares.Except(blockSoftwares, new NameComparer()).ToList();
                    foreach (Software sft in list3)
                    {
                        AddBlockSoftwareInRegistry(sft.name, sft.softwareExe);
                    }
                    blockSoftwares = softwares;
                }

            }
            else if (blockSoftwares.Count > softwares.Count)
            {
                var list3 = blockSoftwares.Except(softwares, new NameComparer()).ToList();
                foreach (Software sft in list3)
                {
                    RemoveBlockSoftwareInRegistry(sft.name);
                }
                blockSoftwares = softwares;
            }
            else
            {
                var list3 = softwares.Except(blockSoftwares, new NameComparer()).ToList();
                foreach (Software sft in list3)
                {
                    AddBlockSoftwareInRegistry(sft.name, sft.softwareExe);
                }
                blockSoftwares = softwares;
            }



        }

        private void AddBlockSoftwareInRegistry(string name, string exe)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "DisallowRun", 1);

                Microsoft.Win32.RegistryKey rkey;
                rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun");
                rkey.SetValue(name, exe);
                rkey.Close();
            }
            catch
            {

            }
        }

        private void RemoveBlockSoftwareInRegistry(string name)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "DisallowRun", 1);

                Microsoft.Win32.RegistryKey rkey;
                rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun");
                rkey.DeleteValue(name);
                rkey.Close();
            }
            catch
            {

            }
        }

        private void timerForSoftwareInstallation_Tick(object sender, EventArgs e)
        {
          
            List<Software> requestedSoftwares = DatabaseConnection.ReadSoftwareInstallationRequest();
           
            if(requestedSoftwares.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Software Installation Request from server", "Installation Request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    DatabaseConnection.SoftwareInstallationRequestSuccessful("done");
                    var com = new ServerSoftwares(requestedSoftwares);
                    com.ShowDialog();
                }
            }
        }

        private void StartUp_Deactivate(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
