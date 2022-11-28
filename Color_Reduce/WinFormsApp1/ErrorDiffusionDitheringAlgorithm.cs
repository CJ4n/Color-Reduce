namespace WinFormsApp1
{
    public class ErrorDiffusionDitheringAlgorithm : Algorithm
    {
        private double[,] _diffusionMatrix = { { 0, 0, 0 }, { 0, 0, 7.0 / 16.0 }, { 3.0 / 16.0, 5.0 / 16.0, 1.0 / 16.0 } };
        public ErrorDiffusionDitheringAlgorithm(Bitmap image) : base(image) { }

        protected override void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb)
        {
            int basicMultipleR = 255 / (Kr - 1);
            int basicMultipleG = 255 / (Kg - 1);
            int basicMultipleB = 255 / (Kb - 1);
            double[,] channelR = new double[bitmap.Width, bitmap.Height];
            double[,] channelG = new double[bitmap.Width, bitmap.Height];
            double[,] channelB = new double[bitmap.Width, bitmap.Height];

            for (int row = 0; row < bitmap.Height; ++row)
            {
                for (int col = 0; col < bitmap.Width; ++col)
                {
                    Color color = bitmap.GetPixel(col, row);
                    channelR[col, row] += color.R;
                    channelG[col, row] += color.G;
                    channelB[col, row] += color.B;

                    var retR = CalculatePixelAndeError(channelR[col, row], basicMultipleR);
                    var retG = CalculatePixelAndeError(channelG[col, row], basicMultipleG);
                    var retB = CalculatePixelAndeError(channelB[col, row], basicMultipleB);

                    Color newColor = Color.FromArgb(255, retR.K, retG.K, retB.K);
                    bitmap.SetPixel(col, row, newColor);

                    DiffuseError(channelR, channelG, channelB, col, row, retR.error, retG.error, retB.error);
                }
            }
        }

        // (new pixel value,error)
        private (int K, double error) CalculatePixelAndeError(double color, int basicMultiple)
        {
            int K = Utils.GetNearestMultiple((int)Math.Round(color), basicMultiple);
            double error = color - K;
            return (K, error);
        }

        // TODO: optimize applaying kernel: many zeros!!!
        private void DiffuseError(double[,] channelR, double[,] channelG, double[,] channelB, int col, int row, double errorR, double errorG, double errorB)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (col + i >= channelR.GetLength(0) || col + i < 0 || row + j >= channelR.GetLength(1) || row + j < 0)
                    {
                        continue;
                    }

                    double r = errorR * _diffusionMatrix[1 + i, 1 + j];
                    double g = errorG * _diffusionMatrix[1 + i, 1 + j];
                    double b = errorB * _diffusionMatrix[1 + i, 1 + j];
                    channelR[col + i, row + j] += r;
                    channelG[col + i, row + j] += g;
                    channelB[col + i, row + j] += b;
                }
            }
        }
    }
}
