using System.Numerics;

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

        public static BigInteger Factorial(this BigInteger x)
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

        public static int ReverseFactorial(this int x)
        {
            int i = 1, result = x;
            while((result / (i + 1)) >= 1)
            {
                result /= i;
                i++;
            }
            return result;
        }

        public static BigInteger ReverseFactorial(this BigInteger x)
        {
            BigInteger i = 1, result = x;
            while((result / (i + 1)) >= 1)
            {
                result /= i;
                i++;
            }
            return result;
        }
    }
}