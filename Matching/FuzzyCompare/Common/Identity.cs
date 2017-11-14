using FuzzyRanks.Matching.FuzzyCompare.Base;

namespace FuzzyRanks.Matching.FuzzyCompare.Common
{
    public class Identity : FuzzyComparer
    {
        public override float Compare(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                return 0;
            }

            if (!this.CaseSensitiv)
            {
                str1 = str1.ToLower();
                str2 = str2.ToLower();
            }

            if (str1.Equals(str2))
            {
                return 1.0f;
            }

            return 0;
        }
    }
}