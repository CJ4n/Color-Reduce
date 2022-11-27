namespace WinFormsApp1
{
    public class OrderedDitheringDeterministicAlgorithm : OrderedDitheringAlgorithm

    {
        public OrderedDitheringDeterministicAlgorithm(Bitmap bitmap) : base(bitmap) { }
        override protected (int, int) ComputeIndexes(int col, int row, int n)
        {
            return (col % n, row % n);
        }
    }
}
