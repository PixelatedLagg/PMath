using ExtendedNumerics;

namespace PMath
{
    public static class Number
    {
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