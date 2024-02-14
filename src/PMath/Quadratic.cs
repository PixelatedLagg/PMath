namespace PMath
{
    public class Quadratic
    {
        public static double Eval(double a, double b, double c, double x)
        {
            return a * x * x + b * x + c;
        }

        public static double AxisOfSymmetry(double a, double b)
        {
            return -b / 2 * a;
        }

        public static bool? NatureOfRoots(double a, double b, double c)
        {
            double disc = b * b - 4 * a * c;
            if (disc < 0)
            {
                return null; //imaginary roots
            }
            double discSqrt = Math.Sqrt(disc);
            if (discSqrt - (int)discSqrt < double.Epsilon)
            {
                return true; //rational root
            }
            return false; //irrational roots
        }

        public static double SumOfRoots(double a, double b)
        {
            return -b / a;
        }

        public static double ProductOfRoots(double a, double c)
        {
            return c / a;
        }
    }
}