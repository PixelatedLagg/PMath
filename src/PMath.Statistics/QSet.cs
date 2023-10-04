using System.Numerics;

namespace PMath.Statistics
{
    public class QSet
    {
        public List<BigInteger> Data = new List<BigInteger>();
        public string Name;

        public QSet(string name)
        {
            Name = name;
        }
    }
}