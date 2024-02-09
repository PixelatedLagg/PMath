using System.Numerics;
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
        public static BigDecimal Arctan(BigInteger i)
        {
            BigDecimal pi = 0.0;

            for (BigInteger k = 0; k < i; ++k)
            {
                BigDecimal term = (k % 2 == 0 ? 1.0 : -1.0) / (2 * k + (BigDecimal)1);
                pi += term;
            }

            return pi * 4;
        }

        public static BigDecimal Taylor(BigInteger i)
        {
            double tanPiOver4 = 1.0;

            for (int n = 1; n < i; ++n)
            {
                double term = Math.Pow(-1, n) * (Math.Pow(2, 2 * n - 1) * Factorial(2 * n - 1)) / (2 * n - 1);
                tanPiOver4 += term;
            }

            return 4 * tanPiOver4;
        }

        static double Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            double result = 1;
            for (int i = 2; i <= n; ++i)
            {
                result *= i;
            }

            return result;
        }


    }
}