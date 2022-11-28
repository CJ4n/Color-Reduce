namespace WinFormsApp1
{
    public abstract class Algorithm
    {
        protected Bitmap image;

        public Algorithm(Bitmap image)
        {
            this.image = (Bitmap)image.Clone();
        }

        public void UpdateBitmap(Bitmap newBitmap)
        {
            image = newBitmap;
        }
        public Bitmap ApplayColorReduce(int Kr, int Kg, int Kb)
        {
            Bitmap copy = (Bitmap)image.Clone();
            using (var bitmap = new BmpPixelSnoop(copy))
            {
                ReduceColors(bitmap, Kr, Kg, Kb);
            }
            return copy;
        }

        protected abstract void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb);
    }
}
