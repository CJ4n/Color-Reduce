namespace WinFormsApp1
{
    public class PopulatiryAlgorithm : Algorithm
    {
        int[] hist = new int[256 * 256 * 256];
        int[] firstKMostCommonColorIndices;
        public PopulatiryAlgorithm(Bitmap bitmap) : base(bitmap)
        {

            for (int row = 0; row < bitmap.Height; row++)
            {
                for (int col = 0; col < bitmap.Height; col++)
                {
                    Color color = bitmap.GetPixel(col, row);
                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    int val = (r << 16 | g << 8 | b);
                    hist[val]++;
                }
            }
            int[] indices = Enumerable.Range(0, 256 * 256 * 256).ToArray();
            firstKMostCommonColorIndices = indices.OrderByDescending(i => hist[i]).ToArray();
        }

        // Only Kr is used, Kg,Kb are ignored (we take Kr of most common colors)
        protected override void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb)
        {
            Color[] newColors = new Color[Kr];
            int iter = 0;
            foreach (var index in firstKMostCommonColorIndices.Take(Kr))
            {
                int b = index & 0xFF;
                int g = index >> 8 & 0xFF;
                int r = index >> 16 & 0xFF;

                Color color = Color.FromArgb(255, r, g, b);
                newColors[iter++] = color;
            }

            for (int row = 0; row < bitmap.Height; row++)
            {
                for (int col = 0; col < bitmap.Height; col++)
                {
                    bitmap.SetPixel(col, row, GetNearesColor(newColors, bitmap.GetPixel(col, row)));
                }
            }
        }

        private double ColorDistanceMetric(Color c1, Color c2)
        {
            int r = c1.R - c2.R;
            int g = c1.G - c2.G;
            int b = c1.B - c2.B;
            return r * r + g * g + b * b;
        }

        private Color GetNearesColor(Color[] colors, Color color)
        {
            double minDist = double.MaxValue;
            int id = 0;
            int i = 0;
            foreach (var c in colors)
            {
                double dist = ColorDistanceMetric(c, color);
                if (minDist > dist)
                {

                    minDist = dist;
                    id = i;
                }
                i++;
            }
            return colors[id];
        }
    }
}
