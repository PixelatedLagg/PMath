namespace PMath.Statistics
{
    public static class XYSet32
    {
        public static Linear LinearBestFit(QSet32 x, QSet32 y)
        {
            if (x.Count != y.Count)
            {
                throw new Exception("QSet32 X must have the same count as QSet32 Y!");
            }
            int numPoints = x.Count;
            double meanX = x.Mean();
            double meanY = y.Mean();
            int sumXSquared = x.SumSquared();
            double sumXY = 0;
            for (int i = 0; i < x.Count; i++)
            {
                sumXY += x[i] * y[i];
            }
            double a = (sumXY / numPoints - meanX * meanY) / (sumXSquared / numPoints - meanX * meanX);
            return new Linear(a, (meanY - a * meanX));
        }
    }
}