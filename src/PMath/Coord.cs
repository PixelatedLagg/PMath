using System.Numerics;
using ExtendedNumerics;
using ExtendedNumerics.Helpers;

namespace PMath.Statistics
{
    public static class Coord
    {
        public static double Distance((int x, int y) a, (int x, int y) b) => Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static double Distance((double x, double y) a, (double x, double y) b) => Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static decimal Distance((decimal x, decimal y) a, (decimal x, decimal y) b) => (decimal)Math.Sqrt((double)((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y)));
        public static float Distance((float x, float y) a, (float x, float y) b) => MathF.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static BigInteger Distance((BigInteger x, BigInteger y) a, (BigInteger x, BigInteger y) b) => ((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y)).SquareRoot();
        public static BigDecimal Distance((BigDecimal x, BigDecimal y) a, (BigDecimal x, BigDecimal y) b) => BigDecimal.SquareRoot((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y), BigDecimal.Precision);
    }
}