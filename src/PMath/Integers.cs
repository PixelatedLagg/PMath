using System.Numerics;

namespace PMath
{
    public static class Integers
    {
        public static int EuclidGCD32(int a, int b)
        {
            while (b > 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}