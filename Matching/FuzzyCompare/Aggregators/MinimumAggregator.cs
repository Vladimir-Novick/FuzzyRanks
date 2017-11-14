using FuzzyRanks.Matching.FuzzyCompare.Aggregators.Base;

namespace FuzzyRanks.Matching.FuzzyCompare.Aggregators
{
    using System.Linq;

    public class MinimumAggregator : Aggregator
    {
        public override float AggregatedSimilarity(float[] similarities, float[] weights = null)
        {
            return similarities.Min();
        }
    }
}