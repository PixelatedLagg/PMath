namespace PMath
{
    public class Expression
    {
        List<Operation> Operations = new List<Operation>();

        public Expression(List<Operation> operations)
        {
            Operations = operations;
        }
    }
}