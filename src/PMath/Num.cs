using ExtendedNumerics;

namespace PMath
{
    public static class Num
    {
        public static int EuclidGCD(int a, int b)
        {
            while (b > 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
        public static BigDecimal Min()
        {
            return 1 / BigDecimal.Pow(10, BigDecimal.Precision);
        }
        public static bool Roughly(double val1, double val2, int range)
        {
            return val2 - range <= val1 && val1 <= val2 + range;
        }
    }
}