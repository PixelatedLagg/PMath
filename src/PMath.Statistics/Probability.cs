using System.Numerics;

namespace PMath.Statistics
{
    public static class Probability
    {
        public static int NCR(int n, int r)
        {
            return n.Factorial() / (r.Factorial() * (n - r).Factorial());
        }

        public static BigInteger NCR(BigInteger n, BigInteger r)
        {
            return n.Factorial() / (r.Factorial() * (n - r).Factorial());
        }
    }
}