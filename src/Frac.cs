namespace PMath
{
    public struct Frac
    {
        public int Numerator, Denominator;
        public Frac(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Frac Multiply(Frac frac)
        {
            return new Frac(frac.Numerator * Numerator, frac.Denominator * Denominator);
        }

        /*public Frac Add(Frac frac)
        {
            int common =
        }*/
    }
}