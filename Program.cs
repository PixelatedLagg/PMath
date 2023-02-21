using PMath;

class Program
{
    public static void Main()
    {
        SForm eq = new SForm(3, 7, 6, -4, 178);
        Console.WriteLine(eq.Eval(6));
    }
}