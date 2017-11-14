using System.Reflection;
using FuzzyRanks.Base.Utils;

namespace FuzzyRanks.Matching.FuzzyCompare.Aggregators.Base
{
    public class AggregatorFactory : GenericFactory
    {
        public static Aggregator GetInstance(string typeName, params object[] parameters)
        {
            return GetInstance<Aggregator>(Assembly.GetExecutingAssembly(), typeName, parameters);
        }
    }
}
