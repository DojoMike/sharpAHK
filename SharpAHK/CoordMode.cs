using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpAHK
{
    /// <summary>
    /// This class doesn't actually affect anything yet, but will be very important down the road (as CoordModes
    /// affect just about everything coordinate-related in AHK).  Syntactiaclly, they use nested classes so the
    /// end-developer can just do i.e. CoordMode.Mouse.Client();
    /// </summary>
    public class CoordMode
    {
        // These properties are used to get and set the different CoordModes.
        public static readonly int Screen = 0;
        public static readonly int Window = 1;
        public static readonly int Client = 2;

        /// <summary>
        /// Once we get this working, similar classes will be used for CoordMode Pixel, ToolTip etc.
        /// </summary>
        public static class Mouse
        {
            private static int _value = 0;
            public static int Value
            {
                get { return _value; }
                set
                {
                    if (value == CoordMode.Screen || value == CoordMode.Window || value == CoordMode.Client)
                        _value = value;
                    else
                        throw new AHKException();
                }
            }

            public static void Screen()
            {
                _value = CoordMode.Screen;
            }
            public static void Window()
            {
                _value = CoordMode.Window;
            }
            public static void Client()
            {
                _value = CoordMode.Client;
            }
        }
    }
}
