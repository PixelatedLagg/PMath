namespace PMath
{
    public class irr : num
    {
        num Left;
        num Right;
        num Root;

        public irr(num left, num right)
        {
            Left = left;
            Right = right;
        }

        public ldec Eval(int precision)
        {
            //return operation with certain digits of precision after decimal point
        }
    }
}