using PMath;
using PMath.Statistics;

class Program
{
    public static void Main()
    {
        QSet32 set = new("test", -8035, -7798, -7008, -5525, 4863, 3218, -3000, 5990, 7175, -1044);
        Console.WriteLine(set.QuickSummary());
        Console.Write("Outliers:");
        foreach (int i in set.Outliers())
        {
            Console.Write($" {i}");
        }
    }
}