namespace PMath.Statistics
{
    public class QSet32Array
    {
        public readonly List<QSet32> Sets = new();

        public QSet32Array(params QSet32[] sets)
        {
            Sets.AddRange(sets);
        }
    }
}