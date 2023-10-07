using PMath;
using PMath.Statistics;

class Program
{
    public static void Main()
    {
        QSet32 set = new("test", 1, 2, 3, 4, 55, 67, 7888, 67);
        Console.WriteLine(set.StdDev());
        Console.WriteLine(set.Variance());
        Console.WriteLine(set.Mean());
        Console.WriteLine(set.Median());
    }
}