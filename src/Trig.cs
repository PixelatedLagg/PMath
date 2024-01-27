using ExtendedNumerics;

namespace PMath
{
    public static class Trig
    {
        public static BigDecimal Sin(double ce) => BigDecimal.Sin(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
    }
}