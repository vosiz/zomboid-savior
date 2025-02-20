using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

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

        // Modifier and key combinations to be matched
        private Keys[] ModifierKeysArray;
        private Keys[] TargetKeysArray;

        // Constructor that accepts modifier and key combinations
        public GlobalKeyHook(Action callback, Keys[] modifiers, Keys[] targetKeys)
        {
            Process = HookCallback;
            Callback = callback;
            ModifierKeysArray = modifiers;
            TargetKeysArray = targetKeys;
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
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && Enabled)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                bool matchedModifiers = true;

                // Check if all modifiers are pressed
                foreach (var modifier in ModifierKeysArray)
                {
                    if ((Control.ModifierKeys & modifier) == 0)
                    {
                        matchedModifiers = false;
                        break;
                    }
                }

                // Check if one of the target keys is pressed
                Keys key = (Keys)vkCode;
                bool matchedKey = TargetKeysArray.Contains(key);

                // Trigger callback if both conditions are met
                if (matchedModifiers && matchedKey)
                {
                    Callback?.Invoke();
                }
            }
            return CallNextHookEx(HookUd, nCode, wParam, lParam);
        }
    }
}
