using System.Threading;

namespace SharpAHK
{
    /// <summary>
    /// This class is the end-developer's main tool for using AHK functionality.
    /// Their "main" class can just extend this one.
    /// </summary>
    public class AHK
    {
        #region Built-in variables

        public static int A_ScreenWidth { get { return ScreenFunctions.Width(); } }
        public static int A_ScreenHeight { get { return ScreenFunctions.Height(); } }
        public static int A_CoordModeMouse { get { return CoordMode.Mouse.Value; } }

        #endregion

        public static void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}
