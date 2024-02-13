using System.Numerics;
using ExtendedNumerics;

namespace PMath
{
    public static class Pi
    {
        public static BigDecimal CalculatePi(int numTerms) //ramanujan sum
        {
            BigDecimal sum = 0;
            for (int k = 0; k < numTerms; k++)
            {
                sum += new BigDecimal((4 * (BigInteger)k).Factorial()) * (1103 + 26390 * (BigInteger)k) / (BigDecimal.Pow(new BigDecimal(k.BigFactorial()), 4) * BigDecimal.Pow(new BigDecimal(396), 4 * k));
            }
            sum *= 2 * BigDecimal.SquareRoot(2, BigDecimal.Precision) / 9801;
            return 1 / sum;
        }
    }
}