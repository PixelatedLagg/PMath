using System.Numerics;
using ExtendedNumerics;
using PMath;
using PMath.Statistics;
using System.Globalization;
class Program
{
    public static void Main()
    {
        BigDecimal.Precision = 50;
        Console.WriteLine(Distr.NormalCDF(-1, 0.25, 0, 1));
    }
}