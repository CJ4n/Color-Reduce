namespace WinFormsApp1
{
    public static class Utils
    {
        public static int GetNearestMultiple(int n, int multiple)
        {
            n = n + multiple / 2;
            n = n - (n % multiple);
            return n;
        }
    }
}
