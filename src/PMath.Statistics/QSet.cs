using System.Numerics;

namespace PMath.Statistics
{
    public class QSet32
    {
        public List<int> Data = new();
        public string Name;

        public QSet32(string name)
        {
            Name = name;
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
    }
}