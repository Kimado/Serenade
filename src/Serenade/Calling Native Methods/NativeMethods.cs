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
    }
}
