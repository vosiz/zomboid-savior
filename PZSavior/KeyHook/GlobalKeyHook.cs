﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PZSavior.KeyHook
{
    public class GlobalKeyHook
    {

        private const int WH_KEYBOARD_LL = 13;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookUd = IntPtr.Zero;
        private LowLevelKeyboardProc Process;
        private Action Callback;
        public bool Enabled = false;

        public GlobalKeyHook(Action callback)
        {
            Process = HookCallback;
            Callback = callback;
            HookUd = SetHook(Process);
            Enabled = true;
        }

        public void Dispose()
        {
            UnhookWindowsHookEx(HookUd);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {

            if (nCode >= 0 && Enabled)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                bool ctrl = (Control.ModifierKeys & Keys.Control) != 0;
                Keys key = (Keys)vkCode;

                if (ctrl && key == Keys.S)
                {
                    Callback?.Invoke();
                }
            }
            return CallNextHookEx(HookUd, nCode, wParam, lParam);
        }

        
    }
}
