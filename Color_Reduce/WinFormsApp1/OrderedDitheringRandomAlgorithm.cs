namespace WinFormsApp1
{
    public class OrderedDitheringRandomAlgorithm : OrderedDitheringAlgorithm
    {
        Random random;
        public OrderedDitheringRandomAlgorithm(Bitmap bitmap) : base(bitmap)
        {
            random = new Random();
        }
        override protected (int, int) ComputeIndexes(int col, int row, int n)
        {
            return (random.Next(0, n), random.Next(0, n));
        }
    }
}
