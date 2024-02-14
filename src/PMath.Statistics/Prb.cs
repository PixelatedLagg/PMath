using System.Numerics;

namespace PMath.Statistics
{
    public static class Prb
    {
        public static int NCR(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        public static BigInteger NCR(BigInteger n, BigInteger r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        public static int Factorial(int x)
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

        public static BigInteger BigFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            BigInteger res = 1;
            for (int i = 2; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }

        public static BigInteger Factorial(BigInteger x)
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

        public static int ReverseFactorial(int x)
        {
            int i = 1, result = x;
            while((result / (i + 1)) >= 1)
            {
                result /= i;
                i++;
            }
            return result;
        }

        public static BigInteger ReverseFactorial(BigInteger x)
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