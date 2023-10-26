namespace PMath.Statistics
{
    public class Q2Set32
    {
        public List<int> X = new();
        public List<int> Y = new();

        public Q2Set32(int[] x, int[] y)
        {
            X.AddRange(x);
            Y.AddRange(y);
        }
    }
}