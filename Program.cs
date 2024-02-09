using System.Numerics;
using ExtendedNumerics;
using PMath;
using PMath.Statistics;
using System.Globalization;
class Program
{
    public static void Main()
    {
        Console.WriteLine(test(10, 10));
    }
    static int test(int x, int y)
    {
        return (int)((x * (Math.Pow(10, y) - 1)) / 9);
    }
}