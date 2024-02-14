using ExtendedNumerics;

namespace PMath.Statistics
{
    public static class Distr
    {
        public static BigDecimal A1 =  0.254829592;
        public static BigDecimal A2 = -0.284496736;
        public static BigDecimal A3 =  1.421413741;
        public static BigDecimal A4 = -1.453152027;
        public static BigDecimal A5 =  1.061405429;
        public static BigDecimal P  =  0.3275911;

        public static BigDecimal BinomCDF(int trials, BigDecimal p, int x)
        {
            BigDecimal result = 0;
            for (; x >= 0; x--)
            {
                result += Prb.NCR(trials, x) * BigDecimal.Pow(p, x) * BigDecimal.Pow(1 - p, trials - x);
                Console.WriteLine(result);
            }
            return result;
        }

        public static BigDecimal BinomPDF(int trials, BigDecimal p, int x)
        {
            return Prb.NCR(trials, x) * BigDecimal.Pow(p, x) * BigDecimal.Pow(1 - p, trials - x);
        }

        public static BigDecimal GeometPDF(BigDecimal p, int x)
        {
            if (x <= 0)
            {
                return 0;
            }
            return BigDecimal.Pow(1 - p, x - 1) * p;
        }

        public static BigDecimal GeometCDF(BigDecimal p, int x)
        {
            if (x <= 0)
            {
                return 0;
            }
            BigDecimal result = 0;
            for (; x > 0; x--)
            {
                result += BigDecimal.Pow(1 - p, x - 1) * p;
            }
            return result;
        }
        public static BigDecimal NormalCDF(double lowerBound, double upperBound, double mean, double stdDev)
        {
            BigDecimal zLower = (lowerBound - mean) / (BigDecimal)stdDev;
            BigDecimal zUpper = (upperBound - mean) / (BigDecimal)stdDev;

            BigDecimal cdfLower = 0.5 * (1.0 + Erf(zLower / BigDecimal.SquareRoot(2, BigDecimal.Precision)));
            BigDecimal cdfUpper = 0.5 * (1.0 + Erf(zUpper / BigDecimal.SquareRoot(2, BigDecimal.Precision)));

            return cdfUpper - cdfLower;
        }

        // Numerical approximation of the error function (Erf)
        private static BigDecimal Erf(BigDecimal x)
        {
            // Save the sign of x
            int sign = x < 0 ? -1 : 1;
            x = BigDecimal.Abs(x);

            // A&S formula 7.1.26
            BigDecimal t = 1.0 / (1.0 + P * x);
            BigDecimal y = 1.0 - (((((A5 * t + A4) * t) + A3) * t + A2) * t + A1) * t * BigDecimal.Exp(-x * x);

            return sign * y;
        }
    }
}