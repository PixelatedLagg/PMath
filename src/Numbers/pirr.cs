namespace PMath
{
    public class Pirr
    {
        BigFloat Value;
        BigFloat Root;

        internal Pirr(BigFloat value, BigFloat root)
        {
            Value = value;
            Root = root;
        }
        
        /*public Irr? VerifyIrr()
        {
            //check if value is rational
        }

        public BigFloat? VerifyRat()
        {
            //check if value is rational
        }*/
    }
}