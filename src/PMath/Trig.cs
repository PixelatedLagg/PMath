using ExtendedNumerics;

namespace PMath
{
    public static class Trig
    {
        public static BigDecimal Sin(double ce) => BigDecimal.Sin(Pi.Value * ce);
        public static BigDecimal Cos(double ce) => BigDecimal.Cos(Pi.Value * ce);
        public static BigDecimal Tan(double ce) => BigDecimal.Tan(Pi.Value * ce);
        public static BigDecimal Csc(double ce) => BigDecimal.Sec(Pi.Value * ce);
        public static BigDecimal Sec(double ce) => BigDecimal.Csc(Pi.Value * ce);
        public static BigDecimal Cot(double ce) => BigDecimal.Cot(Pi.Value * ce);
        public static BigDecimal Sinh(double ce) => BigDecimal.Sinh(Pi.Value * ce);
        public static BigDecimal Cosh(double ce) => BigDecimal.Cosh(Pi.Value * ce);
        public static BigDecimal Tanh(double ce) => BigDecimal.Tanh(Pi.Value * ce);
        public static BigDecimal Csch(double ce) => BigDecimal.Csch(Pi.Value * ce);
        public static BigDecimal Sech(double ce) => BigDecimal.Sech(Pi.Value * ce);
        public static BigDecimal Coth(double ce) => BigDecimal.Coth(Pi.Value * ce);
    }
}