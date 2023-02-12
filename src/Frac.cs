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

        public Frac Add(Frac frac)
        {
            int common = Denominator * frac.Denominator;
            return new Frac(Numerator * frac.Denominator + frac.Numerator * Denominator, common);
        }

        public Frac Simplify()
        {
            int gcd = Integers.EuclidGCD(Numerator, Denominator);
            return new Frac(Numerator / gcd, Denominator / gcd);
        }

        public bool CanSimplify()
        {
            return Integers.EuclidGCD(Numerator, Denominator) != 1;
        }

        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }

        public static implicit operator Frac(double d)
        {
             
        }
    }
}