namespace PMath.Statistics
{
    public class QSet32
    {
        private readonly List<int> Data = new();
        public int Count => Data.Count;
        public int[] ToArray => Data.ToArray();
        public string Name;

        public QSet32(string name, params int[] data)
        {
            Name = name;
            Array.Sort(data);
            Data.AddRange(data);
        }

        public double Mean()
        {
            int total = 0;
            foreach (int i in Data)
            {
                total += i;
            }
            return total / (double)Data.Count;
        }

        public double Median()
        {
            if (Data.Count % 2 != 0)
            {
                return Data[Data.Count / 2];
            }
            return (Data[(Data.Count - 1) / 2] + Data[Data.Count / 2]) / 2.0;
        }

        public double Q1()
        {
            return (Data[(int)Math.Floor(Data.Count * 0.25) - 1] + Data[(int)Math.Floor(Data.Count * 0.25)]) / 2.0;
        }

        public double Q3()
        {
            return (Data[(int)Math.Ceiling(Data.Count * 0.75) - 1] + Data[(int)Math.Ceiling(Data.Count * 0.75)]) / 2.0;
        }

        public double Range() => Data.Max() - Data.Min();

        public double IQR() => Q3() - Q1();

        public int Max() => Data.Max();
        
        public int Min() => Data.Min();

        public double StdDev()
        {
            double mean = Mean();
            double sum = 0;
            foreach (int i in Data)
            {
                sum += (i - mean) * (i - mean);
            }
            return Math.Sqrt(sum / (Data.Count - 1));
        }

        public int Mode()
        {
            var groups = Data.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }

        public double Variance() => Math.Pow(StdDev(), 2);
        public string QuickSummary() => $"N: {Data.Count}, Mean: {Mean()}, SD: {StdDev()}, Min: {Data.Min()}, Q1: {Q1()}, Med: {Median()}, Q3: {Q3()}, Max: {Data.Max()}";

        public int[] Outliers()
        {
            List<int> outliers = new();
            foreach (int i in Data)
            {
                if (IsOutlier(i))
                {
                    outliers.Add(i);
                }
            }
            return outliers.ToArray();
        }

        public bool IsOutlier(int value) => IsOutlierIQR(value) && IsOutlierStdDev(value);

        public bool IsOutlierIQR(int value)
        {
            double iqr = IQR();
            return value > iqr * 1.5 + Q3() || value < iqr * 1.5 - Q1();
        }

        public bool IsOutlierStdDev(int value) => Math.Abs(value - Mean()) / StdDev() > 2;

        public bool IsSymmetric(int precision) => Utilities.Roughly(Q1() - Min(), Max() - Q3(), precision) && Utilities.Roughly(Median() - Q1(), Q3() - Median(), precision);
    }
}