namespace PMath
{
    public class IExpr : ResultI
    {
        public double X;
        public double Constant;

        public IExpr(double x, double constant)
        {
            X = x;
            Constant = constant;
        }
    }
}