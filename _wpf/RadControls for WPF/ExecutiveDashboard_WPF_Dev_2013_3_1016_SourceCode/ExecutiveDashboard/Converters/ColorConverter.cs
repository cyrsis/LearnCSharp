using System.Windows.Media;

namespace ExecutiveDashboard
{
    public class ColorConverter
    {
        public static Color HSLtoRGB(double hue, double saturation, double luminance)
        {
            int Max, Mid, Min;
            double q;

            Max = Round(luminance * 255);
            Min = Round((1.0 - saturation) * (luminance / 1.0) * 255);
            q = (double)(Max - Min) / 255;

            if (hue >= 0 && hue <= (double)1 / 6)
            {
                Mid = Round(((hue - 0) * q) * 1530 + Min);
                return Color.FromArgb(255, (byte)Max, (byte)Mid, (byte)Min);
            }
            else if (hue <= (double)1 / 3)
            {
                Mid = Round(-((hue - (double)1 / 6) * q) * 1530 + Max);
                return Color.FromArgb(255, (byte)Mid, (byte)Max, (byte)Min);
            }
            else if (hue <= 0.5)
            {
                Mid = Round(((hue - (double)1 / 3) * q) * 1530 + Min);
                return Color.FromArgb(255, (byte)Min, (byte)Max, (byte)Mid);
            }
            else if (hue <= (double)2 / 3)
            {
                Mid = Round(-((hue - 0.5) * q) * 1530 + Max);
                return Color.FromArgb(255, (byte)Min, (byte)Mid, (byte)Max);
            }
            else if (hue <= (double)5 / 6)
            {
                Mid = Round(((hue - (double)2 / 3) * q) * 1530 + Min);
                return Color.FromArgb(255, (byte)Mid, (byte)Min, (byte)Max);
            }
            else if (hue <= 1.0)
            {
                Mid = Round(-((hue - (double)5 / 6) * q) * 1530 + Max);
                return Color.FromArgb(255, (byte)Max, (byte)Min, (byte)Mid);
            }
            else
            {
                return Color.FromArgb(255, (byte)0, (byte)0, (byte)0);
            }
        }

        public static HSL RGBtoHSL(Color c)
        {
            HSL hsl = new HSL();

            int Max, Min, Diff, Sum;

            //	Of our RGB values, assign the highest value to Max, and the Smallest to Min
            if (c.R > c.G)
            {
                Max = c.R;
                Min = c.G;
            }
            else
            {
                Max = c.G;
                Min = c.R;
            }
            if (c.B > Max) Max = c.B;
            else if (c.B < Min) Min = c.B;

            Diff = Max - Min;
            Sum = Max + Min;

            //	Luminance - a.k.a. Brightness - Adobe photoshop uses the logic that the
            //	site VBspeed regards (regarded) as too primitive = superior decides the 
            //	level of brightness.
            hsl.L = (double)Max / 255;

            //	Saturation
            if (Max == 0) hsl.S = 0;	//	Protecting from the impossible operation of division by zero.
            else hsl.S = (double)Diff / Max;	//	The logic of Adobe Photoshops is this simple.

            //	Hue		R is situated at the angel of 360 eller noll degrees; 
            //			G vid 120 degrees
            //			B vid 240 degrees
            double q;
            if (Diff == 0) q = 0; // Protecting from the impossible operation of division by zero.
            else q = (double)60 / Diff;

            if (Max == c.R)
            {
                if (c.G < c.B) hsl.H = (360 + q * (c.G - c.B)) / 360;
                else hsl.H = (q * (c.G - c.B)) / 360;
            }
            else if (Max == c.G) hsl.H = (120 + q * (c.B - c.R)) / 360;
            else if (Max == c.B) hsl.H = (240 + q * (c.R - c.G)) / 360;
            else hsl.H = 0.0;

            return hsl;
        }

        private static int Round(double val)
        {
            int ret_val = (int)val;

            int temp = (int)(val * 100);

            if ((temp % 100) >= 50)
            {
                ret_val += 1;
            }

            return ret_val;
        }
    }
}