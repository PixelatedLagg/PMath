using System.Numerics;

namespace PMath.Statistics
{
    public class QSet<T> where T : int, double
    {
        public List<T> Data = new List<T>();
        public string Name;

        public QSet(string name)
        {
            Name = name;
        }

        public double Mean()
        {
            
        }
    }
}