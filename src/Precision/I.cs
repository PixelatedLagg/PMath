namespace PMath
{
    public class I //equal to sqrt(-1) * x
    {
        public double X;

        public I(double x)
        {
            X = x;
        }

        public static I operator +(I a, I b)
        {
            return new I(a.X + b.X);
        }

        public static I operator -(I a, I b)
        {
            return new I(a.X - b.X);
        }

        public static double operator *(I a, I b)
        {
            return a.X * b.X * -1;
        }

        public static I operator *(I a, double b)
        {
            return new I(a.X * b);
        }

        public static double operator /(I a, I b)
        {
            return a.X / b.X;
        }

        public static I operator /(I a, double b)
        {
            return new I(a.X / b);
        }
    }
}