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
                return true; //rational roots
            }
            return false; //irrational roots
        }

        /*public static Point[] Roots(double a, double b, double c)
        {
            
        }*/
    }
}