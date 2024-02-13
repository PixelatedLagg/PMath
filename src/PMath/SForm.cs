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
            double result = 0;
            for (int i = Multiplicity; i > 0; i--)
            {
                result += Values[Values.Length - i - 1] * Math.Pow(x, i);
            }
            return result + Values[Values.Length - 1];
        }

        /*public bool? EvenOrOdd() //calc even = true, odd = false, or neither = null
        {

        }*/
    }
}