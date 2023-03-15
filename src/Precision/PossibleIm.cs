namespace PMath
{
    public struct PossibleI
    {
        public IExpr? IValue;
        public double? Value;

        public PossibleI(I iValue)
        {
            IValue = new IExpr(iValue.X, 0);
            Value = null;
        }

        public PossibleI(IExpr iValue)
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