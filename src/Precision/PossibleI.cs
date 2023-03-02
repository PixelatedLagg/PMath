namespace PMath
{
    public struct PossibleI
    {
        public I? IValue;
        public double? Value;

        public PossibleI(I iValue)
        {
            IValue = iValue;
            Value = null;
        }

        public PossibleI(double value)
        {
            Value = value;
            IValue = null;
        }

        public bool IsI()
        {
            return Value == null;
        }
    }
}