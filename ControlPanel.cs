using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput.Native;
using WindowsInput;
namespace RDPClientApplication
{
    public partial class ControlPanel : Form
    {
        //[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //internal static extern int InternalGetSystemMetrics(int value);
        //Mouse actions
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
        internal static extern int InternalGetSystemMetrics(int value);
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

        int previousId = 0;


        SqlConnection conn = DatabaseConnection.conn;
        AutoResetEvent autoReset = new AutoResetEvent(true);
        InputSimulator sim = new InputSimulator();
        public ControlPanel()
        {
            InitializeComponent();
            Hardware.Image = StartUp.ResizeImage(Hardware.Image, Hardware.Size);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(new Action(CaptureScreen));
            task.Start();

        }

        private void CaptureScreen()
        {

            autoReset.WaitOne();
            while (true)
            {
                int screenLeft = SystemInformation.VirtualScreen.Left;
                int screenTop = SystemInformation.VirtualScreen.Top;
                int screenWidth = SystemInformation.VirtualScreen.Width;
                int screenHeight = SystemInformation.VirtualScreen.Height;

                // Create a bitmap of the appropriate size to receive the full-screen screenshot.
                using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
                {
                    // Draw the screenshot into our bitmap.
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                    }

                    //Save the screenshot as a Jpg image
                    var uniqueFileName = "test.jpeg";
                    try
                    {
                        bitmap.Save(uniqueFileName, ImageFormat.Jpeg);

                        using (Image image = Image.FromFile(uniqueFileName))
                        {
                            using (MemoryStream m = new MemoryStream())
                            {
                                image.Save(m, image.RawFormat);
                                byte[] imageBytes = m.ToArray();

                                // Convert byte[] to Base64 String
                                string base64String = Convert.ToBase64String(imageBytes);
                                SaveScreenToDatabase(base64String);

                                
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                    }
                }

                //click on screen according to coordinates
                //ClickUsingMouseCoordinates();
                ReadInputDevicesEvents();
                autoReset.Set();
            }


        }

        private void SaveScreenToDatabase(string encodedImage)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "Insert into SystemDetails(image1)Values(@image)";
                command.Parameters.AddWithValue("@image", encodedImage);
                command.Connection = conn;
                command.ExecuteNonQuery();

            }
        }

        private void ClickUsingMouseCoordinates()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select top 1 * from mousepointer order by id desc";
            cmd.Connection = conn;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int id = (dr["id"] == DBNull.Value) ? 0 : (int)dr["id"];
                    string coorx = (dr["coorx"] == DBNull.Value) ? "" : (string)dr["coorx"];
                    string coory = (dr["coory"] == DBNull.Value) ? "" : (string)dr["coory"];

                    if (id == previousId)
                    {
                        return;
                    }
                    else
                    {
                        previousId = id;
                        int to_x = Convert.ToInt32(coorx);
                        int to_y = Convert.ToInt32(coory);

                        int screenWidth = InternalGetSystemMetrics(0);
                        int screenHeight = InternalGetSystemMetrics(1);

                        // Mickey X coordinate
                        int mic_x = (int)System.Math.Round(to_x * 65536.0 / screenWidth);
                        // Mickey Y coordinate
                        int mic_y = (int)System.Math.Round(to_y * 65536.0 / screenHeight);

                        // 0x0001 | 0x8000: Move + Absolute position
                        Mouse_Event(0x0001 | 0x8000, mic_x, mic_y, 0, 0);
                        // 0x0002: Left button down
                        Mouse_Event(0x0002, mic_x, mic_y, 0, 0);
                        // 0x0004: Left button up
                        Mouse_Event(0x0004, mic_x, mic_y, 0, 0);


                        //previousId = id;
                        //uint X = Convert.ToUInt32(coorx);
                        //uint Y = Convert.ToUInt32(coory);
                        //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE , X, Y, 0, 0);
                        //Thread.Sleep(100);
                        //mouse_event(UP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                        //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE, X, Y, 0, 0);
                        MessageBox.Show("clicked happens");
                    }
                    
                    
                }
            }
        }

        private void ReadInputDevicesEvents()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select top 1 * from inputevents order by id desc";
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
                            PerformKeyboardOperation(keycode, keyname);
                        }
                        if (IsMouseInput(type))
                        {
                            string coorx = (dr["coorx"] == DBNull.Value) ? "" : (string)dr["coorx"];
                            string coory = (dr["coory"] == DBNull.Value) ? "" : (string)dr["coory"];
                            PerformMouseoperation(coorx, coory);
                        }
                       
                    }

                }
            }
        }

        private void PerformMouseoperation(string coorx, string coory)
        {
            int to_x = Convert.ToInt32(coorx);
            int to_y = Convert.ToInt32(coory);

            int screenWidth = InternalGetSystemMetrics(0);
            int screenHeight = InternalGetSystemMetrics(1);

            // Mickey X coordinate
            int mic_x = (int)System.Math.Round(to_x * 65536.0 / screenWidth);
            // Mickey Y coordinate
            int mic_y = (int)System.Math.Round(to_y * 65536.0 / screenHeight);

            // 0x0001 | 0x8000: Move + Absolute position
            Mouse_Event(0x0001 | 0x8000, mic_x, mic_y, 0, 0);
            // 0x0002: Left button down
            Mouse_Event(0x0002, mic_x, mic_y, 0, 0);
            // 0x0004: Left button up
            Mouse_Event(0x0004, mic_x, mic_y, 0, 0);
        }

        private void PerformKeyboardOperation(string keycode, string keyname)
        {
            int code = Convert.ToInt32(keycode);

            int key = KeyInterop.VirtualKeyFromKey((Key)code);

            VirtualKeyCode vkey = (VirtualKeyCode)key;
            //keybd_event(0x5B, 0x45, KEYEVENTF_KEYUP | 0, 0);
            sim.Keyboard.KeyPress(vkey);

        }

        private bool IsKeyboardInput(string type)
        {
            if(type == "keyboard")
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
