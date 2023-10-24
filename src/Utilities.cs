namespace PMath
{
    public static class Utilities
    {
        public static bool Roughly(double val1, double val2, int range)
        {
            return val2 - range <= val1 && val1 <= val2 + range;
        }
    }
}