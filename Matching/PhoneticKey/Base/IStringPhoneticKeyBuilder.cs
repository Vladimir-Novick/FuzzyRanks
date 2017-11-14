namespace FuzzyRanks.Matching.PhoneticKey.Base
{
    public interface IPhoneticKeyBuilder
    {
        string BuildKey(string str1);

        int MaxLength
        {
            get;
            set;
        }
    }
}
