using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace RDPClientApplication
{
    class KeyboardInput
    {
        // Structure contain information about low-level keyboard input event
        [StructLayout(LayoutKind.Sequential)]
        public struct KBDLLHOOKSTRUCT
        {
           
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        //System level functions to be used for hook and unhook keyboard input
        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern short GetAsyncKeyState(Keys key);

        private const int WM_KEYDOWN = 0x0100;

        //public string serverProcessorid = "";
        


        //Declaring Global objects
        public IntPtr ptrHook;
        public LowLevelKeyboardProc objKeyboardProcess;

        public KeyboardInput()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule; //Get Current Modul
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey); //Assign callback function each time keyboard process
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0); //Setting Hook of Keyboard Process for current module

           // serverProcessorid = serverprocessorid;
        }

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            //check window is active or not
            
                if (nCode >= 0)
                {
                   
                        KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
                        int a = objKeyInfo.scanCode;

                        //save keyboard input key to database
                        //DatabaseConnection.insertKeyboardInput((int)objKeyInfo.key, objKeyInfo.key.ToString(), serverProcessorid);
                        return (IntPtr)1;
                    
                   
                    //if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin) // Disabling /Windows keys
                    //{

                    //}
                
            }
            
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        public void disposeInput()
        {
            if (ptrHook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(ptrHook);
                ptrHook = IntPtr.Zero;
               
            }
        }


    }
}
