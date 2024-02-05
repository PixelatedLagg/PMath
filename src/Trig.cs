using ExtendedNumerics;

namespace PMath
{
    public static class Trig
    {
        public static BigDecimal Sin(double ce) => BigDecimal.Sin(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Cos(double ce) => BigDecimal.Cos(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Tan(double ce) => BigDecimal.Tan(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Csc(double ce) => BigDecimal.Sec(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Sec(double ce) => BigDecimal.Csc(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Cot(double ce) => BigDecimal.Cot(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Sinh(double ce) => BigDecimal.Sinh(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Cosh(double ce) => BigDecimal.Cosh(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Tanh(double ce) => BigDecimal.Tanh(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Csch(double ce) => 1 / BigDecimal.Sinh(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Sech(double ce) => BigDecimal.Sech(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
        public static BigDecimal Coth(double ce) => BigDecimal.Coth(BigDecimal.GetPiDigits(BigDecimal.Precision) * ce);
    }
}