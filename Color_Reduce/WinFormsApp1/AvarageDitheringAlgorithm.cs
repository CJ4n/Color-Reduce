namespace WinFormsApp1
{
    public class AvarageDitheringAlgorithm : Algorithm
    {

        public AvarageDitheringAlgorithm(Bitmap bitmap) : base(bitmap) { }

        protected override void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb)
        {
            int basicMultipleR = 255 / (Kr - 1);
            int basicMultipleG = 255 / (Kg - 1);
            int basicMultipleB = 255 / (Kb - 1);
            for (int row = 0; row < bitmap.Height; ++row)
            {
                for (int col = 0; col < bitmap.Width; ++col)
                {
                    Color color = bitmap.GetPixel(col, row);
                    int r = Utils.GetNearestMultiple(color.R, basicMultipleR);
                    int g = Utils.GetNearestMultiple(color.G, basicMultipleG);
                    int b = Utils.GetNearestMultiple(color.B, basicMultipleB);
                    Color newColor = Color.FromArgb(255, r, g, b);
                    bitmap.SetPixel(col, row, newColor);
                }
            }
        }
    }
}
