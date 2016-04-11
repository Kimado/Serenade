using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* Warning, my code structure suck so you'll get lost. have fun... */
/* @Kimado 

░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄░░░░▄░░░░█░░░░░░░
░░░░░░█▀░░░░░░░░░░░░░▀▀█▄░░░▀░░░░░░░░░▄░
░░░░▄▀░░░░░░░░░░░░░░░░░▀██░░░▄▀▀▀▄▄░░▀░░
░░▄█▀▄█▀▀▀▀▄░░░░░░▄▀▀█▄░▀█▄░░█▄░░░▀█░░░░
░▄█░▄▀░░▄▄▄░█░░░▄▀▄█▄░▀█░░█▄░░▀█░░░░█░░░
▄█░░█░░░▀▀▀░█░░▄█░▀▀▀░░█░░░█▄░░█░░░░█░░░
██░░░▀▄░░░▄█▀░░░▀▄▄▄▄▄█▀░░░▀█░░█▄░░░█░░░
██░░░░░▀▀▀░░░░░░░░░░░░░░░░░░█░▄█░░░░█░░░
██░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░░░█▄░░░
██░░░░░░░░░░░░░░░░░░░░░█░░░░█░░░░░░░▀▀█▄
██░░░░░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░▄▄██
░██░░░░░░░░░░░░░░░░░░▄▀░░░░░█░░░░░░░▀▀█▄
░▀█░░░░░░█░░░░░░░░░▄█▀░░░░░░█░░░░░░░▄▄██
░▄██▄░░░░░▀▀▀▄▄▄▄▀▀░░░░░░░░░█░░░░░░░▀▀█▄
░░▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░█▄▄▄▄▄▄▄▄▄██
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ */

// Changed the console folder to ConsoleMethods\ so we know where stuff are.
namespace Serenade.ConsoleMethods
{
    // I also switched ConsoleDo to setConsole because it more professional
    // and wrote 2 write function ( writeline and write ) because both method are different. 
    class setConsole
    {
        
        public static void WriteLine(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("[ " + DateTime.Now + "] - " + message);
            Console.ResetColor();
        }
        public static void Write(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        // I wrote a simple loop /-\| for the hook function and I ended up putting it in the setConsole class.
        public static void hookloop()
        {
            // Initialized waittime to 34 so it doesn't "lag".
            int waittime = 34;
            
            // Writing default Time & Message before enabling the loop because I removed it from the Write function by default. 
            Write(ConsoleColor.Yellow, "[ " + DateTime.Now + "] - " +  "Waiting for call of duty 4... ");

            // Ok Uh, it a simple FindWindow searching method combined with a console loop. Nothing really complex. 
            while ((HookMethods.Hook.GameWindowHandle = Calling_Native_Methods.NativeMethods.FindWindow(null, "Call of Duty 4")) == IntPtr.Zero)
            {
                /* Kinda pointless to comment dis no? */ 
                Write(ConsoleColor.Yellow, "/");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Write(ConsoleColor.Yellow, "-");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Write(ConsoleColor.Yellow, "\\");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Write(ConsoleColor.Yellow, "|");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
            }
            /* The setCursorPosition used for the loop fuck up a bit the line so we created a new blackline empty space before writing more text. */
            WriteLine(ConsoleColor.Black, " ");
            WriteLine(ConsoleColor.Green, "\"Call of duty 4\" window initialized... ");
        }
    }
}
