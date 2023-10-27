namespace PMath.Statistics
{
    public class QSet32Array
    {
        List<QSet32> Sets = new();

        public Q2Set32(params QSet32[] sets)
        {
            Sets.AddRange(sets);
        }
    }
}