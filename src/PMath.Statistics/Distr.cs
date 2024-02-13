using ExtendedNumerics;

namespace PMath.Statistics
{
    public static class Distr
    {
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
    }
}