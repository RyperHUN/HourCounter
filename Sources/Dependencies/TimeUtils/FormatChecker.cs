using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class FormatChecker
    {
        static private Color OriginalTextBackground = Color.White;
        static private Color WrongInputColor        = Color.LightPink;
        public static bool SetInputColor (TextBox box, bool isValid)
        {
            if (isValid)
                box.BackColor = OriginalTextBackground;
            else
                box.BackColor = WrongInputColor;

            return isValid;
        }
        public static bool SetInputColor (TextBox box, Func<bool> predicate)
        {
            return SetInputColor (box, predicate());
        }
    }
}
