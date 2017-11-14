using System.Reflection;
using FuzzyRanks.Base.Utils;

namespace FuzzyRanks.Matching.FuzzyCompare.Base
{
    public class FuzzyComparerFactory : GenericFactory
    {
        public static FuzzyComparer GetInstance(string typeName, params object[] parameters)
        {
            return GetInstance<FuzzyComparer>(Assembly.GetExecutingAssembly(), typeName, parameters);
        }
    }
}
