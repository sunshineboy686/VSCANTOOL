using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANTOOL
{
    public static class ColorTheme
    {
        public static Color leftNavColor;
        public static Color headTitleColor;

        static ColorTheme()
        {
            leftNavColor= Color.FromArgb(100, 38, 59, 83);
            headTitleColor= Color.FromArgb(100, 107, 142, 185);
        }

        public static Color Change_Color_Brightness(Color tColor, double correctionFactor)
        {
            double red = tColor.R;
            double green = tColor.G;
            double blue = tColor.B;
            //if correction factor is less than 0,darken color
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //if correction factor is greater than zero , lighten color
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(tColor.A,(byte)red,(byte)green,(byte)blue);
        }
    }
}
