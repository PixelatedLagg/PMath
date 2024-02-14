namespace PMath
{
    public class Linear
    {
        public static (double m, double b) Inverse(double m, double b) => (1 / m, -1 * b / m);
    }
}