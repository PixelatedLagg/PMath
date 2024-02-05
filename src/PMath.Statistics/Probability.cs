namespace PMath.Statistics
{
    public static class Probability
    {
        public static int NCR(int n, int r)
        {
            return n.Factorial() / (r.Factorial() * (n - r).Factorial());
        }
    }
}