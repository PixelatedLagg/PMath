namespace PMath
{
    public class Operation : ITerm
    {
        public OperationType Type;
        public double Left, Right;

        public Operation(OperationType type, double left, double right)
        {
            Type = type;
            Left = left;
            Right = right;
        }
    }
}