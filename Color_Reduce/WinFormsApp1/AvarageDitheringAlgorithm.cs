namespace WinFormsApp1
{
    public class AvarageDitheringAlgorithm : Algorithm
    {

        public AvarageDitheringAlgorithm(Bitmap bitmap) : base(bitmap)
        {
        }

        override public Bitmap ApplayColorReduce(int Kr, int Kg, int Kb)
        {
            int basicMultipleR = 255 / (Kr - 1);
            int basicMultipleG = 255 / (Kg - 1);
            int basicMultipleB = 255 / (Kb - 1);

            Bitmap copy = (Bitmap)image.Clone();

            using (var bitmap = new BmpPixelSnoop(copy))
            {
                // Now use the faster GetPixel() and SetPixel(), e.g.

                for (int row = 0; row < bitmap.Height; ++row)
                    for (int col = 0; col < bitmap.Width; ++col)
                    {
                        Color color = bitmap.GetPixel(col, row);
                        int r = GetNearestMultiple(color.R, basicMultipleR);
                        int g = GetNearestMultiple(color.G, basicMultipleG);
                        int b = GetNearestMultiple(color.B, basicMultipleB);
                        Color newColor = Color.FromArgb(255, r, g, b);
                        bitmap.SetPixel(col, row, newColor);
                    }
            }
            return copy;
        }

        private int GetNearestMultiple(int n, int multiple)
        {
            //if (multiple > n)
            //    return multiple;

            n = n + multiple / 2;
            n = n - (n % multiple);
            if (n != (int)(((n + multiple / 2) / multiple) * multiple))
            {
                int aasd = 343;
            }
            return n;
        }

    }
}
