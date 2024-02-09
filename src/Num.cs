using ExtendedNumerics;

namespace PMath
{
    public static class Num
    {
        public static BigDecimal Min()
        {
            return 1 / BigDecimal.Pow(10, BigDecimal.Precision);
        }
    }
}