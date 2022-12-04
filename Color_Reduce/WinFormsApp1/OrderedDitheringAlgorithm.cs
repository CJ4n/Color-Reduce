namespace WinFormsApp1
{
    public abstract class OrderedDitheringAlgorithm : Algorithm
    {
        private Dictionary<int, int[,]> matrixes;
        private int[] matrixSizes = { 2, 3, 4, 6, 8, 12, 16 };
        public OrderedDitheringAlgorithm(Bitmap bitmap) : base(bitmap)
        {
            matrixes = new Dictionary<int, int[,]>(matrixSizes.Length);
            CreateMatrixes();
        }

        private void CreateMatrixes()
        {
            matrixes[2] = new int[,] { { 0, 2 }, { 3, 1 } };
            matrixes[3] = new int[,] { { 6, 8, 4 }, { 1, 0, 3 }, { 5, 2, 7 } };

            for (int idx = 2; idx < matrixSizes.Length; idx++)
            {
                int size = matrixSizes[idx];
                matrixes[size] = new int[size, size];
                for (int row = 0; row < size / 2; ++row)
                {
                    for (int col = 0; col < size / 2; ++col)
                    {
                        matrixes[size][row, col] = matrixes[size / 2][row, col] * 4;
                    }
                    for (int col = size / 2; col < size; ++col)
                    {
                        matrixes[size][row, col] = matrixes[size / 2][row, col - size / 2] * 4 + 2;
                    }
                }

                for (int row = size / 2; row < size; ++row)
                {
                    for (int col = 0; col < size / 2; ++col)
                    {
                        matrixes[size][row, col] = matrixes[size / 2][row - size / 2, col] * 4 + 3;
                    }
                    for (int col = size / 2; col < size; ++col)
                    {
                        matrixes[size][row, col] = matrixes[size / 2][row - size / 2, col - size / 2] * 4 + 1;
                    }
                }
            }
        }

        private int ComputeN(int k)
        {
            int n = (int)(16 / Math.Sqrt(k - 1));
            for (int idx = 0; idx < matrixSizes.Length; idx++)
            {

                if (matrixSizes[idx] == n)
                {
                    return matrixSizes[idx];
                }
                if (matrixSizes[idx] < n && matrixSizes[idx + 1] > n)
                {
                    return matrixSizes[idx + 1];
                }
            }
            if (n < matrixSizes[0])
            {
                return matrixSizes[0];
            }
            throw new Exception("n not found!!!");  // it should never occur
        }

        abstract protected (int, int) ComputeIndexes(int col, int row, int n);

        private int ComputePixel(int k, int n, int Ii, int x, int y, int[,] Dn)
        {
            int col = (int)((float)Ii / (float)(n * n));
            int re = Ii % (n * n);
            (int i, int j) = ComputeIndexes(x, y, n);
            if (re > Dn[i, j])
                col++;
            return 255 / (k - 1) * col;
        }

        protected override void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb)
        {
            int Nr = ComputeN(Kr);
            int[,] Dr = matrixes[Nr];

            int Ng = ComputeN(Kr);
            int[,] Dg = matrixes[Ng];

            int Nb = ComputeN(Kb);
            int[,] Db = matrixes[Nb];

            for (int row = 0; row < bitmap.Height; ++row)
            {
                for (int col = 0; col < bitmap.Width; ++col)
                {
                    Color Ii = bitmap.GetPixel(col, row);

                    int r = ComputePixel(Kr, Nr, Ii.R, col, row, Dr);
                    int g = ComputePixel(Kg, Ng, Ii.G, col, row, Dg);
                    int b = ComputePixel(Kb, Nb, Ii.B, col, row, Db);

                    Color newColor = Color.FromArgb(255, r & 0xFF, g & 0xFF, b & 0xFF);
                    bitmap.SetPixel(col, row, newColor);
                }
            }
        }
    }
}
