namespace WinFormsApp1
{
    public static class Utils
    {
        public static int GetNearestMultiple(int n, int multiple)
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
