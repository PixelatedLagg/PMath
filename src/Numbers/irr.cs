using System.Numerics;

namespace PMath
{
    public class Irr
    {
        BigFloat Value;
        BigFloat Root;

        public Irr(BigFloat value, BigFloat root)
        {
            Value = value;
            Root = root;
        }

        public BigFloat Eval(BigInteger precision)
        {
            //return operation with certain digits of precision after decimal point
        }
    }
}