using System.Numerics;
using ExtendedNumerics;
using ExtendedNumerics.Helpers;

namespace PMath.Statistics
{
    public static class CoordExtensions
    {
        public static double Distance(this (int x, int y) a, (int x, int y) b) => Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static double Distance(this (double x, double y) a, (double x, double y) b) => Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static decimal Distance(this (decimal x, decimal y) a, (decimal x, decimal y) b) => (decimal)Math.Sqrt((double)((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y)));
        public static float Distance(this (float x, float y) a, (float x, float y) b) => MathF.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        public static BigInteger Distance(this (BigInteger x, BigInteger y) a, (BigInteger x, BigInteger y) b) => ((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y)).SquareRoot();
        public static BigDecimal Distance(this (BigDecimal x, BigDecimal y) a, (BigDecimal x, BigDecimal y) b) => BigDecimal.SquareRoot((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y), BigDecimal.Precision);
    }
}