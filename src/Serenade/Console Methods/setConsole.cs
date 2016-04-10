using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

// Changed the console folder to ConsoleMethods\ to make it easier to know where stuff are.
namespace Serenade.ConsoleMethods
{
    // I also switched ConsoleDo to setConsole because it more professional. 
    class setConsole
    {
        public static void Write(ConsoleColor color, string message)
        {
            // set ForegroundColor to the console.
            Console.ForegroundColor = color;

            // Added DateTime for logs... 
            Console.WriteLine("[ " + DateTime.Now + "] - " + message);
            Console.ResetColor();
        }
    }
}
