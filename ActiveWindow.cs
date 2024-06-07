using SHDocVw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RDPClientApplication
{
    class ActiveWindow
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static bool ApplicationIsActivated()
        {
            var activatedHandle = GetForegroundWindow();
            if (activatedHandle == IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            var procId = Process.GetCurrentProcess().Id;
            int activeProcId;
            GetWindowThreadProcessId(activatedHandle, out activeProcId);

            return activeProcId == procId;
        }

        public static string GetActiveExplorerPath()
        {
            IntPtr handle = GetForegroundWindow();
            int handle1 = (int)handle;
            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindows();
            try
            {
                //SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindows();
                var explorer = shellWindows.Cast<InternetExplorer>().Where(hwnd => hwnd.HWND == handle1).FirstOrDefault();
                if (explorer != null)
                {
                    string path = new Uri(explorer.LocationURL).LocalPath;
                    return path;
                    Console.WriteLine("name={0}, path={1}", explorer.LocationName, path);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
