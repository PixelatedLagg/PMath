namespace PMath.Statistics
{
    public class QSet32
    {
        public List<int> Data = new();
        public string Name;

        public QSet32(string name, params int[] data)
        {
            Name = name;
            Data.AddRange(data);
        }

        public double Mean()
        {
            int total = 0;
            foreach (int i in Data)
            {
                total += i;
            }
            return total / Data.Count;
        }

        public double StdDev()
        {
            double mean = Mean();
            double sum = 0;
            foreach (int i in Data)
            {
                sum += (i - mean) * (i - mean);
            }
            return Math.Sqrt(sum / Data.Count);
        }
    }
}