namespace PMath
{
    public class SForm
    {
        public int Multiplicity;
        public double[] Values;

        public SForm(int multiplicity, params double[] values)
        {
            Multiplicity = multiplicity;
            Values = values;
        }

        public double Eval(double x)
        {
            //input x into equation
        }

        public SForm Inverse()
        {
            //calc inverse
        }

        public bool? EvenOrOdd()
        {
            //calc even = true, odd = false, or neither = null
        }
    }
}