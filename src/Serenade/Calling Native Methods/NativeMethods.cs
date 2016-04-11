using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Serenade.Calling_Native_Methods
{
    class NativeMethods
    {
        // Importing "Kernel32.dll" To call AllocConsole();
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        // Importing "Kernels32.dll" to call FreeConsole();
        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        // Importing "user32.dll" to call FindWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        
        // Importing "user32.dll" to call GetWindowThreadProcessID();
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        
        // Importing "kernel32.dll" to call OpenProcess();
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        // Initializing some memory var;
        public static uint PROCESS_VM_OPERATION = 0x8;
        public static uint PROCESS_VM_READ = 0x10;
        public static uint PROCESS_VM_WRITE = 0x20;
        public static uint PROCESS_ALL_ACCESS = 0x1F0FFF;
        public static int INVALID_HANDLE_VALUE = -1;
    }
}
