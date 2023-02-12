using PMath;

class Program
{
    public static void Main()
    {
        Frac a = new Frac(3, 14);
        Console.WriteLine(a.Add(new Frac(17, 50)));
    }
}