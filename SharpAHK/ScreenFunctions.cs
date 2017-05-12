using System.Windows.Forms;

namespace SharpAHK
{
    /// <summary>
    /// Right now this is just for A_ScreenWidth/Height, but eventually
    /// it should include ImageSearch, PixelSearch, PixelGetColor etc.
    /// </summary>
    internal class ScreenFunctions
    {
        public static int Width()
        {
            return Screen.PrimaryScreen.Bounds.Right;
        }

        public static int Height()
        {
            return Screen.PrimaryScreen.Bounds.Bottom;
        }
    }
}
