namespace PMath
{
    public class Op
    {
        double Left, Right;
        public OpType OpType;

        public Op(double left, double right, OpType opType)
        {
            Left = left;
            Right = right;
            OpType = opType;
        }

        public double Eval(int precision)
        {
            //return operation with certain digits of precision after decimal point
        }
    }
}