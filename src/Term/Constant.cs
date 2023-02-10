namespace PMath
{
    public struct Constant : ITerm
    {
        public double Value;

        public Constant(double value)
        {
            Value = value;
        }
    }
}