namespace WinFormsApp1
{
    public class None : Algorithm
    {
        public None(Bitmap bitmap) : base(bitmap) { }

        protected override void ReduceColors(BmpPixelSnoop bitmap, int Kr, int Kg, int Kb)
        {
            // Do nothing
        }
    }
}
