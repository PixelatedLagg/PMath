using System.Numerics;

namespace PMath
{
    public static class Integers
    {
        public static BigInteger EuclidGCD(BigInteger a, BigInteger b)
        {
            while (b > 0)
            {
                BigInteger remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}