using Ionic.Zip;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;

namespace RDPClientApplication
{
    public class RemoteControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("User32.dll",
          EntryPoint = "mouse_event",
          CallingConvention = CallingConvention.Winapi)]
        internal static extern void Mouse_Event(int dwFlags,
                                      int dx,
                                      int dy,
                                      int dwData,
                                      int dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;


        [DllImport("User32.dll",
                    EntryPoint = "GetSystemMetrics",
                    CallingConvention = CallingConvention.Winapi)]
        internal static extern int InternalGetSystemMetrics(int
            value);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        static uint DOWN = 0x0002;
        static uint UP = 0x0004;
        static uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        static uint MOUSEEVENTF_MOVE = 0x0001;


        string previousClickX = "0";
        string previousClickY = "0";

        static int previousId = 0;
        static int previousMouseHoverId = 0;


        SqlConnection conn = DatabaseConnection.conn;
        AutoResetEvent autoReset = new AutoResetEvent(true);
        InputSimulator sim = new InputSimulator();


        string clientprocessorid;
        public static string serverprocessorid = null;
        public static bool doInsertImage = true;
        public static bool isScreenLocked = false;
        private static bool IsPasteCommand = false;
        public RemoteControl(string clientprocessorid, string serverprocessorid)
        {
            this.clientprocessorid = clientprocessorid;
            RemoteControl.serverprocessorid = serverprocessorid;
           
        }

        public RemoteControl(string clientprocessorid)
        {
            this.clientprocessorid = clientprocessorid;
           

        }

        

        public void CaptureScreen()
        {
          
            // autoReset.WaitOne();
           // Thread.Sleep(1000);
            
            while (doInsertImage)
            {
                if(StartUp.isKeyboardLocked == false)
                {
                    int screenLeft = SystemInformation.VirtualScreen.Left;
                    int screenTop = SystemInformation.VirtualScreen.Top;
                    int screenWidth = SystemInformation.VirtualScreen.Width;
                    int screenHeight = SystemInformation.VirtualScreen.Height;

                    // Create a bitmap of the appropriate size to receive the full-screen screenshot.
                    using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
                    {
                        // Draw the screenshot into our bitmap.
                        try
                        {
                            using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                        }

                        //Save the screenshot as a Jpg image
                        var uniqueFileName = "test.jpeg";
                        
                            bitmap.Save(uniqueFileName, ImageFormat.Jpeg);

                            using (Image image = Image.FromFile(uniqueFileName))
                            {
                                using (MemoryStream m = new MemoryStream())
                                {
                                    image.Save(m, image.RawFormat);
                                    byte[] imageBytes = m.ToArray();

                                    // Convert byte[] to Base64 String
                                    string base64String = Convert.ToBase64String(imageBytes);
                                    DatabaseConnection.SaveScreenToDatabase(base64String, clientprocessorid);


                                }
                            }

                        }
                        catch (Exception ex)
                        {
                        }
                    }

                    //click on screen according to coordinates
                    //ClickUsingMouseCoordinates();
                    if (serverprocessorid != null)
                    {
                        ReadMouseHover();
                    }
                    if (serverprocessorid != null)
                    {
                        ReadInputDevicesEvents();
                    }
                }
                 
                
                
               
                //autoReset.Set();
            }


        }

        private void ReadMouseHover()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select top 1 * from inputevents where serverprocessorid = '" + serverprocessorid + "' and keytype = 'hover' order by id desc";
            cmd.Connection = conn;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int id = (dr["id"] == DBNull.Value) ? 0 : (int)dr["id"];
                    if (id == previousMouseHoverId)
                    {
                        return;
                    }
                    else
                    {
                        string type = (dr["eventtype"] == DBNull.Value) ? "" : (string)dr["eventtype"];
                        previousMouseHoverId = id;
                        if (IsKeyboardInput(type))
                        {
                            string keycode = (dr["keycode"] == DBNull.Value) ? "" : (string)dr["keycode"];
                            string keyname = (dr["keyname"] == DBNull.Value) ? "" : (string)dr["keyname"];
                            int modifiersCount = (dr["modifierskeyscount"] == DBNull.Value) ? 0 : (int)dr["modifierskeyscount"];
                            PerformKeyboardOperation(keycode, keyname, modifiersCount);
                        }
                        if (IsMouseInput(type))
                        {
                            string coorx = (dr["coorx"] == DBNull.Value) ? "" : (string)dr["coorx"];
                            string coory = (dr["coory"] == DBNull.Value) ? "" : (string)dr["coory"];
                            string keytype = (dr["keytype"] == DBNull.Value) ? "" : (string)dr["keytype"];
                            int delta = (dr["mousewheeldelta"] == DBNull.Value) ? 0 : (int)dr["mousewheeldelta"];
                            PerformMouseoperation(coorx, coory, keytype, delta);
                        }

                    }

                }
            }
        }

        private void ReadInputDevicesEvents()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select top 1 * from inputevents where serverprocessorid = '"+serverprocessorid+ "' and keytype!='hover' or keytype is null order by id desc";
            cmd.Connection = conn;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int id = (dr["id"] == DBNull.Value) ? 0 : (int)dr["id"];
                    if (id == previousId)
                    {
                        return;
                    }
                    else
                    {
                        string type = (dr["eventtype"] == DBNull.Value) ? "" : (string)dr["eventtype"];
                        previousId = id;
                        if (IsKeyboardInput(type))
                        {
                            string keycode = (dr["keycode"] == DBNull.Value) ? "" : (string)dr["keycode"];
                            string keyname = (dr["keyname"] == DBNull.Value) ? "" : (string)dr["keyname"];
                            int modifiersCount = (dr["modifierskeyscount"] == DBNull.Value) ? 0 : (int)dr["modifierskeyscount"];
                            PerformKeyboardOperation(keycode, keyname, modifiersCount);
                        }
                        if (IsMouseInput(type))  
                        {
                            string coorx = (dr["coorx"] == DBNull.Value) ? "" : (string)dr["coorx"];
                            string coory = (dr["coory"] == DBNull.Value) ? "" : (string)dr["coory"];
                            string keytype =(dr["keytype"] == DBNull.Value) ? "" : (string)dr["keytype"];
                            int delta = (dr["mousewheeldelta"] == DBNull.Value) ? 0 : (int)dr["mousewheeldelta"];
                            PerformMouseoperation(coorx, coory,keytype,delta);
                        }

                    }

                }
            }
        }

        private void PerformMouseoperation(string coorx, string coory, string keytype, int delta)
        {
            if(keytype == "Delta")
            {
                Mouse_Event(0x0800, 0, 0, delta, 0);
                return;
            }
            float to_x = (float)Convert.ToDecimal(coorx);
            float to_y = (float)Convert.ToDecimal(coory);

            int screenWidth = InternalGetSystemMetrics(0);
            int screenHeight = InternalGetSystemMetrics(1);

            //// Mickey X coordinate
            // int mic_x = (int)System.Math.Round(to_x * 65536.0 / screenWidth);
            //// Mickey Y coordinate
           //  int mic_y = (int)System.Math.Round(to_y * 65536.0 / screenHeight);

            int mic_x = (int)(to_x * screenWidth);
            // Mickey Y coordinate
           int mic_y = (int)(to_y * screenHeight);

            // 0x0001 | 0x8000: Move + Absolute position
            // Mouse_Event(0x0001 | 0x8000, mic_x, mic_y, 0, 0);
            SetCursorPos(mic_x, mic_y);
            if (keytype == "Left")
            {
                // 0x0002: Left button down
                Mouse_Event(0x0002, mic_x, mic_y, 0, 0);
                // 0x0004: Left button up
                Mouse_Event(0x0004, mic_x, mic_y, 0, 0);
            }

            if (keytype == "Right")
            {
                // 0x0002: right button down
                Mouse_Event(0x08, mic_x, mic_y, 0, 0);
                // 0x0004: right button up
                Mouse_Event(0x10, mic_x, mic_y, 0, 0);
            }
            if(keytype == "hover")
            {
                
            }

        }

        private void PerformKeyboardOperation(string keycode, string keyname, int modifiersCount)
        {
            
            if (keycode.Contains("+"))
                {
                    PerformKeyboardCombinations(keycode, modifiersCount);
                }
                else
                {
                    int code = Convert.ToInt32(keycode);

                    int key = KeyInterop.VirtualKeyFromKey((Key)(Keys)code);

                    VirtualKeyCode vkey = (VirtualKeyCode)code;
                    //keybd_event(0x5B, 0x45, KEYEVENTF_KEYUP | 0, 0);aaa
                    sim.Keyboard.KeyPress(vkey);

                    }


                }

        private async void PerformKeyboardCombinations(string keycode, int modifiersCount)
        {
            
            string[] keyCodesList = keycode.Split('+');
            if (keyCodesList.Length == 3)
            {
                if(keyCodesList[1] == "162" || keyCodesList[1] == "163" && keyCodesList[2] == "86")
                {
                    IsPasteCommand = true;
                    //read from database
                    List<string> copyData = DatabaseConnection.ReadClipboardData(serverprocessorid, clientprocessorid);
                    if (copyData.Count > 0)
                    {

                        if (copyData[0] == "Text")
                        {
                            
                            Thread STAThread = new Thread(
            delegate ()
            {
                // Use a fully qualified name for Clipboard otherwise it
                // will end up calling itself.
                System.Windows.Forms.Clipboard.SetText(copyData[2]);
            });
                            STAThread.SetApartmentState(ApartmentState.STA);
                            STAThread.Start();
                            STAThread.Join();
                           
                        }
                        if (copyData[0] == "File")
                        {

                            string path = ActiveWindow.GetActiveExplorerPath();
                            WebClient client = new WebClient();
                            if (System.IO.File.Exists("ZippedCopy.zip"))
                            {
                                System.IO.File.Delete("ZippedCopy.zip");
                            }
                            string filename = copyData[3];
                            client.DownloadFile(copyData[1] + "& confirm=XWPY", path + "\\" + filename );
                           
                            
                            
                        }
                        DatabaseConnection.DeleteClipboardData(serverprocessorid, clientprocessorid);
                    }
                }
                else
                {
                    IsPasteCommand = false;
                }
            }
           
           
           
            List<VirtualKeyCode> modifiersCodes = new List<VirtualKeyCode>();
            List<VirtualKeyCode> keysCodes = new List<VirtualKeyCode>();
            for (int i=1;i< keyCodesList.Length; i++)
            {
                int modifiersCode = Convert.ToInt32(keyCodesList[i]);
                VirtualKeyCode vkey = (VirtualKeyCode)modifiersCode;
                sim.Keyboard.KeyDown(vkey);
                modifiersCodes.Add(vkey);
            }
           
            for (int i = keyCodesList.Length-1; i >=1; i--)
            {
                int modifiersCode = Convert.ToInt32(keyCodesList[i]);
                VirtualKeyCode vkey = (VirtualKeyCode)modifiersCode;
                sim.Keyboard.KeyUp(vkey);
                modifiersCodes.Add(vkey);
            }

            //if (IsPasteCommand)
            //{
            //    Clipboard.Clear();
            //}
          


        }

        

        private bool IsKeyboardInput(string type)
        {
            if (type == "keyboard")
            {
                return true;
            }
            return false;
        }

        private bool IsMouseInput(string type)
        {
            if (type == "mouse")
            {
                return true;
            }
            return false;
        }

      

       
    }
}
