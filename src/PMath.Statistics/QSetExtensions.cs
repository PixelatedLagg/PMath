using System.Numerics;
using ExtendedNumerics;
using ExtendedNumerics.Helpers;

namespace PMath.Statistics
{
    public static class QSetExtensions
    {
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
        public static double Median(this IEnumerable<int> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (double)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static double Median(this IEnumerable<double> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (double)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static decimal Median(this IEnumerable<decimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (decimal)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static float Median(this IEnumerable<float> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (float)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static BigDecimal Median(this IEnumerable<BigInteger> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (double)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static BigDecimal Median(this IEnumerable<BigDecimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 2 != 0) ? data.ElementAt(data.Count() / 2) : (double)(data.ElementAt(data.Count() / 2) + data.ElementAt(data.Count() / 2 - 1)) / 2;
        }
        public static double Q1(this IEnumerable<int> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (double)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static double Q1(this IEnumerable<double> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (double)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static decimal Q1(this IEnumerable<decimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (decimal)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static float Q1(this IEnumerable<float> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (float)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static BigDecimal Q1(this IEnumerable<BigInteger> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (double)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static BigDecimal Q1(this IEnumerable<BigDecimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() % 4 != 0) ? data.ElementAt(data.Count() / 4) : (double)(data.ElementAt(data.Count() / 4) + data.ElementAt(data.Count() / 4 - 1)) / 2;
        }
        public static double Q3(this IEnumerable<int> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (double)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static double Q3(this IEnumerable<double> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (double)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static decimal Q3(this IEnumerable<decimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (decimal)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static float Q3(this IEnumerable<float> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (float)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static BigDecimal Q3(this IEnumerable<BigInteger> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (double)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static BigDecimal Q3(this IEnumerable<BigDecimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return (data.Count() * 3 % 4 != 0) ? data.ElementAt(data.Count() * 3 / 4) : (double)(data.ElementAt(data.Count() * 3 / 4) + data.ElementAt(data.Count() * 3 / 4 - 1)) / 2;
        }
        public static double IQR(this IEnumerable<int> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static double IQR(this IEnumerable<double> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static decimal IQR(this IEnumerable<decimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static float IQR(this IEnumerable<float> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static BigDecimal IQR(this IEnumerable<BigInteger> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static BigDecimal IQR(this IEnumerable<BigDecimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            return data.Q3(false) - data.Q1(false);
        }
        public static int Range(this IEnumerable<int> data) => data.Max() - data.Min();
        public static double Range(this IEnumerable<double> data) => data.Max() - data.Min();
        public static decimal Range(this IEnumerable<decimal> data) => data.Max() - data.Min();
        public static float Range(this IEnumerable<float> data) => data.Max() - data.Min();
        public static BigInteger Range(this IEnumerable<BigInteger> data) => data.Max() - data.Min();
        public static BigDecimal Range(this IEnumerable<BigDecimal> data) => data.Max() - data.Min();
        public static int SumSquared(this IEnumerable<int> data) => data.Sum(x => x * x);
        public static double SumSquared(this IEnumerable<double> data) => data.Sum(x => x * x);
        public static decimal SumSquared(this IEnumerable<decimal> data) => data.Sum(x => x * x);
        public static float SumSquared(this IEnumerable<float> data) => data.Sum(x => x * x);
        public static BigInteger SumSquared(this IEnumerable<BigInteger> data)
        {
            BigInteger sum = 0;
            foreach (BigInteger i in data)
            {
                sum += i * i;
            }
            return sum;
        }
        public static BigDecimal SumSquared(this IEnumerable<BigDecimal> data)
        {
            BigDecimal sum = 0;
            foreach (BigDecimal d in data)
            {
                sum += d * d;
            }
            return sum;
        }
        public static int Variance(this IEnumerable<int> data) => (int)Math.Pow(data.StandardDeviation(), 2);
        public static double Variance(this IEnumerable<double> data) => Math.Pow(data.StandardDeviation(), 2);
        public static decimal Variance(this IEnumerable<decimal> data) => (decimal)Math.Pow((double)data.StandardDeviation(), 2);
        public static float Variance(this IEnumerable<float> data) => (float)Math.Pow(data.StandardDeviation(), 2);
        public static BigInteger Variance(this IEnumerable<BigInteger> data) => BigInteger.Pow(data.StandardDeviation(), 2);
        public static BigDecimal Variance(this IEnumerable<BigDecimal> data) => BigDecimal.Pow(data.StandardDeviation(), 2);
        public static int Mode(this IEnumerable<int> data)
        {
            IEnumerable<IGrouping<int, int>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static double Mode(this IEnumerable<double> data)
        {
            IEnumerable<IGrouping<double, double>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static decimal Mode(this IEnumerable<decimal> data)
        {
            IEnumerable<IGrouping<decimal, decimal>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static float Mode(this IEnumerable<float> data)
        {
            IEnumerable<IGrouping<float, float>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static BigInteger Mode(this IEnumerable<BigInteger> data)
        {
            IEnumerable<IGrouping<BigInteger, BigInteger>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static BigDecimal Mode(this IEnumerable<BigDecimal> data)
        {
            IEnumerable<IGrouping<BigDecimal, BigDecimal>> groups = data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static bool IsOutlierStdDev(this IEnumerable<int> data, int value) => Math.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierStdDev(this IEnumerable<double> data, double value) => Math.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierStdDev(this IEnumerable<decimal> data, decimal value) => Math.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierStdDev(this IEnumerable<float> data, float value) => Math.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierStdDev(this IEnumerable<BigInteger> data, BigInteger value) => BigInteger.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierStdDev(this IEnumerable<BigDecimal> data, BigDecimal value) => BigDecimal.Abs(value - data.Average()) / data.StandardDeviation() > 2;
        public static bool IsOutlierIQR(this IEnumerable<int> data, int value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            double iqr = data.IQR(false);
            return value > iqr * 1.5 + data.Q3(false) || value < iqr * 1.5 - data.Q1(false);
        }
        public static bool IsOutlierIQR(this IEnumerable<double> data, double value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            double iqr = data.IQR(false);
            return value > iqr * 1.5 + data.Q3(false) || value < iqr * 1.5 - data.Q1(false);
        }
        public static bool IsOutlierIQR(this IEnumerable<decimal> data, decimal value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            decimal iqr = data.IQR(false);
            return value > iqr * 1.5m + data.Q3(false) || value < iqr * 1.5m - data.Q1(false);
        }
        public static bool IsOutlierIQR(this IEnumerable<float> data, float value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            float iqr = data.IQR(false);
            return value > iqr * 1.5 + data.Q3(false) || value < iqr * 1.5 - data.Q1(false);
        }
        public static bool IsOutlierIQR(this IEnumerable<BigInteger> data, BigInteger value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            BigDecimal iqr = data.IQR(false);
            return value > iqr * 1.5 + data.Q3(false) || value < iqr * 1.5 - data.Q1(false);
        }
        public static bool IsOutlierIQR(this IEnumerable<BigDecimal> data, BigDecimal value, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            BigDecimal iqr = data.IQR(false);
            return value > iqr * 1.5 + data.Q3(false) || value < iqr * 1.5 - data.Q1(false);
        }
        public static bool IsOutlier(this IEnumerable<int> data, int value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static bool IsOutlier(this IEnumerable<double> data, double value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static bool IsOutlier(this IEnumerable<decimal> data, decimal value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static bool IsOutlier(this IEnumerable<float> data, float value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static bool IsOutlier(this IEnumerable<BigInteger> data, BigInteger value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static bool IsOutlier(this IEnumerable<BigDecimal> data, BigDecimal value, bool sort = true) => data.IsOutlierIQR(value, sort) || data.IsOutlierStdDev(value);
        public static int[] Outliers(this IEnumerable<int> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<int> outliers = new();
            foreach (int i in data)
            {
                if (data.IsOutlier(i, false))
                {
                    outliers.Add(i);
                }
            }
            return outliers.ToArray();
        }
        public static double[] Outliers(this IEnumerable<double> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<double> outliers = new();
            foreach (double d in data)
            {
                if (data.IsOutlier(d, false))
                {
                    outliers.Add(d);
                }
            }
            return outliers.ToArray();
        }
        public static decimal[] Outliers(this IEnumerable<decimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<decimal> outliers = new();
            foreach (decimal d in data)
            {
                if (data.IsOutlier(d, false))
                {
                    outliers.Add(d);
                }
            }
            return outliers.ToArray();
        }
        public static float[] Outliers(this IEnumerable<float> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<float> outliers = new();
            foreach (float f in data)
            {
                if (data.IsOutlier(f, false))
                {
                    outliers.Add(f);
                }
            }
            return outliers.ToArray();
        }
        public static BigInteger[] Outliers(this IEnumerable<BigInteger> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<BigInteger> outliers = new();
            foreach (BigInteger i in data)
            {
                if (data.IsOutlier(i, false))
                {
                    outliers.Add(i);
                }
            }
            return outliers.ToArray();
        }
        public static BigDecimal[] Outliers(this IEnumerable<BigDecimal> data, bool sort = true)
        {
            if (sort)
            {
                data = data.OrderBy(x => x);
            }
            List<BigDecimal> outliers = new();
            foreach (BigDecimal d in data)
            {
                if (data.IsOutlier(d, false))
                {
                    outliers.Add(d);
                }
            }
            return outliers.ToArray();
        }
        public static double SymmetricQ(this IEnumerable<int> data, bool sort = true) => (Math.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + Math.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static double SymmetricQ(this IEnumerable<double> data, bool sort = true) => (Math.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + Math.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static decimal SymmetricQ(this IEnumerable<decimal> data, bool sort = true) => (Math.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + Math.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static float SymmetricQ(this IEnumerable<float> data, bool sort = true) => (Math.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + Math.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static BigDecimal SymmetricQ(this IEnumerable<BigInteger> data, bool sort = true) => (BigDecimal.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + BigDecimal.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static BigDecimal SymmetricQ(this IEnumerable<BigDecimal> data, bool sort = true) => (BigDecimal.Abs(data.Q1(false) - data.Min() - data.Max() + data.Q3(false)) + BigDecimal.Abs(data.Median(false) - data.Q1(false) - data.Q3(false) + data.Median(false))) / 2;
        public static double SymmetricMean(this IEnumerable<int> data, bool sort = true) => Math.Abs(data.Average() - data.Median(false));
        public static double SymmetricMean(this IEnumerable<double> data, bool sort = true) => Math.Abs(data.Average() - data.Median(false));
        public static decimal SymmetricMean(this IEnumerable<decimal> data, bool sort = true) => Math.Abs(data.Average() - data.Median(false));
        public static float SymmetricMean(this IEnumerable<float> data, bool sort = true) => Math.Abs(data.Average() - data.Median(false));
        public static BigDecimal SymmetricMean(this IEnumerable<BigInteger> data, bool sort = true) => BigDecimal.Abs(data.Average() - data.Median(false));
        public static BigDecimal SymmetricMean(this IEnumerable<BigDecimal> data, bool sort = true) => BigDecimal.Abs(data.Average() - data.Median(false));
    }
}