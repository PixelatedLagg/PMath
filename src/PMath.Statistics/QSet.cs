using System.Numerics;
using ExtendedNumerics;
using ExtendedNumerics.Helpers;

namespace PMath.Statistics
{
    public static class QSetExtensions
    {
        public static double Mean(this IEnumerable<int> data) => data.Sum() / data.Count();
        public static double Mean(this IEnumerable<double> data) => data.Sum() / data.Count();
        public static decimal Mean(this IEnumerable<decimal> data) => data.Sum() / data.Count();
        public static float Mean(this IEnumerable<float> data) => data.Sum() / data.Count();
        public static BigInteger Average(this IEnumerable<BigInteger> data)
        {
            BigInteger sum = 0;
            foreach (BigInteger num in data)
            {
                sum += num;
            }
            return sum / data.Count();
        }
        public static BigDecimal Average(this IEnumerable<BigDecimal> data)
        {
            BigDecimal sum = 0;
            foreach (BigDecimal num in data)
            {
                sum += num;
            }
            return sum / data.Count();
        }
        public static double StandardDeviation(this IEnumerable<int> data)
        {
            double avg = data.Average();
            double sum = 0;
            foreach (int i in data)
            {
                sum += (avg - i) * (avg - i);
            }
            return Math.Sqrt(sum / data.Count());
        }
        public static double StandardDeviation(this IEnumerable<double> data)
        {
            double avg = data.Average();
            double sum = 0;
            foreach (double d in data)
            {
                sum += (avg - d) * (avg - d);
            }
            return Math.Sqrt(sum / data.Count());
        }
        public static decimal StandardDeviation(this IEnumerable<decimal> data)
        {
            decimal avg = data.Average();
            decimal sum = 0;
            foreach (decimal d in data)
            {
                sum += (avg - d) * (avg - d);
            }
            return (decimal)Math.Sqrt((double)(sum / data.Count()));
        }
        public static float StandardDeviation(this IEnumerable<float> data)
        {
            float avg = data.Average();
            float sum = 0;
            foreach (float f in data)
            {
                sum += (avg - f) * (avg - f);
            }
            return (float)Math.Sqrt((double)(sum / data.Count()));
        }
        public static BigInteger StandardDeviation(this IEnumerable<BigInteger> data)
        {
            BigInteger avg = data.Average();
            BigInteger sum = 0;
            foreach (BigInteger i in data)
            {
                sum += (avg - i) * (avg - i);
            }
            return (sum / data.Count()).SquareRoot();
        }
        public static BigDecimal StandardDeviation(this IEnumerable<BigDecimal> data)
        {
            BigDecimal avg = data.Average();
            BigDecimal sum = 0;
            foreach (BigDecimal d in data)
            {
                sum += (avg - d) * (avg - d);
            }
            return BigDecimal.SquareRoot(sum / data.Count(), BigDecimal.Precision);
        }
    }
}