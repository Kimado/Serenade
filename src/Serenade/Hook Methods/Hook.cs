using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenade.HookMethods
{
    class Hook
    {
        public static IntPtr GameWindowHandle;
        public static IntPtr GameProcessHandle;
        public static void HookWindow()
        {
            // Simple Hook Functions...
            ConsoleMethods.setConsole.hookloop();

            // Next step will be to get the process ID from the game and a read permissions.
            // Wait me before starting (: 
        }
    }
}
