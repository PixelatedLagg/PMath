namespace PMath
{
    public class Quadratic
    {
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

        public static PossibleI[] Roots(double a, double b, double c) //returns x values of all roots
        {
            if (b * b - 4 * a * c == 0)
            {
                return new PossibleI[1] { new PossibleI(-b / (2 * a)) };
            }
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