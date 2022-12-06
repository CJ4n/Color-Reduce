using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    static internal class Class1
    {

        static (double H, double S, double V) RgbToHsv(int r, int g, int b)
        {
            double M = Math.Max(r, Math.Max(g, b));
            double m = Math.Min(r, Math.Min(g, b));
            double V = M / 255;
            double S = 0;
            if (M > 0)
            {
                S = 1 - m / M;
            }
            double H = 0;
            if (g > b)
            {
                double arg = (r - g / 2 - b / 2) / (Math.Sqrt(r * r + g * g + b * b - r * g - r * b - g * b));
                H = Math.Acos(arg);
            }
            else
            {
                double arg = (r - g / 2 - b / 2) / (Math.Sqrt(r * r + g * g + b * b - r * g - r * b - g * b));
                H = 360 - Math.Acos(arg);
            }
            return (H, S, V);
        }

        static Color HsvToRgb(double H, double S, double V)
        {
            double M = 255.0 * V;
            double m = M * (1.0 - S);
            double z = (M - m) * (1 - Math.Abs((H / 60) % 2 - 1.0));

            int r, g, b;
            if (H < 60)
            {
                r = (int)M;
                g = (int)(z + m);
                b = (int)m;
            }
            else if (H < 120)
            {
                r = (int)(z + m);
                g = (int)M;
                b = (int)m;
            }
            else if (H < 180)
            {
                r = (int)m;
                g = (int)M;
                b = (int)(z + m);
            }
            else if (H < 240)
            {
                r = (int)m;
                g = (int)(z + m);
                b = (int)M;
            }
            else if (H < 300)
            {
                r = (int)(z + m);
                g = (int)m;
                b = (int)M;
            }
            else
            {
                r = (int)M;
                g = (int)m;
                b = (int)(z + m);
            }

            return Color.FromArgb(255, r, g, b);

        }

        public static Bitmap DrawStrips(double V,int numStrips)
        {
            Bitmap bitmap = new Bitmap(numStrips * 30+2*30, 360+30);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.Dispose();
            int padding = 30;
            int quanta = 0;
            for (int x = padding; x < bitmap.Width-padding; x++)
            {
                
                double S = (double)quanta* 30.0/bitmap.Width;
                for (int y = padding; y < bitmap.Height-padding; y++)
                {
                    float H = y;
                    Color color = HsvToRgb(H, S, V);
                    bitmap.SetPixel(x, y, color);
                }
                if (x % 30==0) quanta++;
            }
            return bitmap;
        }
    }
    }
