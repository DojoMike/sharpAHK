using System;
using SharpAHK;

namespace Tests
{
    /// <summary>
    /// This project is for testing new stuff as I build it.  It inherits from
    /// the AHK class, so it can call all AHK functions we've ported to it.
    /// </summary>
    class Program : AHK
    {
        static void Main(string[] args)
        {
            // This doesn't do much yet, but:
            CoordMode.Mouse.Client();
            Console.WriteLine(A_CoordModeMouse);

            // Testing Sleep and A_ScreenWidth/Height
            Console.Write("Screen resolution: ");
            Sleep(1000);
            Console.WriteLine(A_ScreenWidth + " x " + A_ScreenHeight);
            Sleep(3000);        // Just long enough for me to see it worked :)
        }
    }
}
