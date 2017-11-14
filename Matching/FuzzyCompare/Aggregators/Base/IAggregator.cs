namespace FuzzyRanks.Matching.FuzzyCompare.Aggregators.Base
{
    public interface IAggregator
    {
        float AggregatedSimilarity(float[] similarities, float[] weights);
    }
}
