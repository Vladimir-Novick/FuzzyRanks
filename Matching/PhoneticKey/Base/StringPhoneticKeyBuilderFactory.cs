using System.Reflection;
using FuzzyRanks.Base.Utils;

namespace FuzzyRanks.Matching.PhoneticKey.Base
{
    public class PhoneticKeyBuilderFactory : GenericFactory
    {
        public static PhoneticKeyBuilder GetInstance(string typeName, params object[] parameters)
        {
            return GetInstance<PhoneticKeyBuilder>(Assembly.GetExecutingAssembly(), typeName, parameters);
        }
    }
}
