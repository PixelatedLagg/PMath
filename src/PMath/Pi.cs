using System.Numerics;
using ExtendedNumerics;
using PMath.Statistics;

namespace PMath
{
    public static class Pi
    {
        public static BigDecimal Value = 3.14159265358; //12 digits by default
        public static BigDecimal CalculatePi(int numTerms) //ramanujan sum
        {
            BigDecimal sum = 0;
            for (int k = 0; k < numTerms; k++)
            {
                sum += new BigDecimal(Prb.Factorial(4 * (BigInteger)k)) * (1103 + 26390 * (BigInteger)k) / (BigDecimal.Pow(new BigDecimal(Prb.BigFactorial(k)), 4) * BigDecimal.Pow(new BigDecimal(396), 4 * k));
            }
            sum *= 2 * BigDecimal.SquareRoot(2, BigDecimal.Precision) / 9801;
            return 1 / sum;
        }
    }
}