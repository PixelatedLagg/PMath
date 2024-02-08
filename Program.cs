using System.Numerics;
using ExtendedNumerics;
using PMath;
using PMath.Statistics;
using System.Globalization;
class Program
{
    public static void Main()
    {
        BigInteger b = BigInteger.Parse("5.50262215981e+57", NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent); //45!
        Console.WriteLine(b.ReverseFactorial());
        
    }
}