namespace WinFormsApp1
{
    public abstract class Algorithm
    {
        protected Bitmap image;

        public Algorithm(Bitmap image)
        {
            this.image = (Bitmap)image.Clone();
        }
        // Algorithm operates on cope of the original image and returns modified image
        public abstract Bitmap ApplayColorReduce(int Kr, int Kg, int Kb);
    }
}
