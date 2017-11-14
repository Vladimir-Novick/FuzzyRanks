using System;
using System.Runtime.Serialization;
using FuzzyRanks.Matching.FuzzyCompare.Common;
using FuzzyRanks.Matching.FuzzyCompare.StringCostFunctions;
using FuzzyRanks.Matching.FuzzyCompare.StringCostFunctions.Base;

namespace FuzzyRanks.Matching.FuzzyCompare.Base
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(DamerauLevenshteinDistance))]
    [KnownType(typeof(ExtendedEditex))]
    [KnownType(typeof(Identity))]
    [KnownType(typeof(ExtendedJaccard))]
    [KnownType(typeof(JaroWinkler))]
    [KnownType(typeof(DiceCoefficent))]
    [KnownType(typeof(MongeElkan))]
    [KnownType(typeof(NGramDistance))]
    [KnownType(typeof(SmithWaterman))]

    public abstract class FuzzyComparer : IFuzzyComparer
    {
        // ***********************Fields***********************

        private StringCostFunction costFunction = new DefaultSubstitutionCostFunction();

        private bool caseSensitiv = false;

        // ***********************Properties***********************

        [DataMember]
        public StringCostFunction CostFunction
        {
            get
            {
                if (this.costFunction == null)
                {
                    this.costFunction = new DefaultSubstitutionCostFunction();
                }
                return this.costFunction;
            }
            set { this.costFunction = value; }
        }

        public string Name
        {
            get { return this.GetType().Name; }
        }

        public bool CaseSensitiv
        {
            get { return this.caseSensitiv; }
            set { this.caseSensitiv = value; }
        }

        // ***********************Functions***********************

        /// <summary>
        /// Compares two strings, with a fuzzy string comparefunction
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns></returns>
        public abstract float Compare(string str1, string str2);

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}