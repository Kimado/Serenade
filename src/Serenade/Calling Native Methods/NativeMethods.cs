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
    }
}
