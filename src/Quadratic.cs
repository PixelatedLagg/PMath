namespace PMath
{
    public class Quadratic
    {
        public double A, B, C;

        public Quadratic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

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

        public static pirr[] Roots(double a, double b, double c) //returns x values of all roots
        {
            if (b * b - 4 * a * c == 0)
            {
                return new pirr[1] { new pirr(-b / (2 * a)) };
            }
            return new pirr[2] { new pirr((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a), new pirr((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a) };
        }

        public static double SumOfRoots(double a, double b)
        {
            return -b / a;
        }

        public static double ProductOfRoots(double a, double c)
        {
            return c / a;
        }

        /*public static bool IsFactorable(double a, double b, double c)
        {
            
        }*/

        public static (double, double, double) FromRoots(double root1, double root2)
        {

        }

        public static (double, double, double) FromRoot(double root)
        {
            
        }
    }
}