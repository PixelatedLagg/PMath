namespace PMath
{
    public class Linear
    {
        double M, B;

        public Linear(double m, double b)
        {
            M = m;
            B = b;
        }

        public Linear Inverse() => new(1 / M, -1 * B / M);

        public double Input(double x) => x * M + B;
        public double Input(int x) => x * M + B;
    }
}