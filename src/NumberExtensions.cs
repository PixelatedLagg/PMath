namespace PMath
{
    public static class NumberExtensions
    {
        public static int Factorial(this int x)
        {
            if (x == 0)
            {
                return 1;
            }
            int res = 1;
            for (int i = 2; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}