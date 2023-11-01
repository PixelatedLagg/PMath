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

        public Linear Inverse()
        {
            //inverse code
        }

        public double Input(double x) => x * M + B;
        public double Input(int x) => x * M + B;
    }
}