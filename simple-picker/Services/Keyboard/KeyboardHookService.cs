using System.Diagnostics;
using System.Runtime.InteropServices;
using simple_picker.Services.Values;

namespace simple_picker.Services.Keyboard
{
    public class KeyboardHookService
    {
        /* https://docs.microsoft.com/en-us/archive/blogs/toub/low-level-keyboard-hook-in-c */

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallBack;
        private static IntPtr _hookID = IntPtr.Zero;

        private static MainForm _mainForm;
        private static ValuesService _valuesService;

        public KeyboardHookService(MainForm mainForm, ValuesService valuesService)
        {
            _hookID = SetHook(_proc);
            _mainForm = mainForm;
            _valuesService = valuesService;
        }

        private static void UpdateValues()
        {
            _mainForm.rgbTextBox.Text = _valuesService.ValueRgb();
            _mainForm.hexTextBox.Text = _valuesService.ValueHex();
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr) WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if (vkCode == 33)
                {
                    UpdateValues();
                }

                if (vkCode == 34)
                {
                    UnhookWindowsHookEx(_hookID);
                    Application.Exit();
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
            int idHook,
            LowLevelKeyboardProc lpfn
            , IntPtr hMod,
            uint dwThreadId
            );

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(
            IntPtr hhk, 
            int nCode, 
            IntPtr wParam, 
            IntPtr lParam
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
