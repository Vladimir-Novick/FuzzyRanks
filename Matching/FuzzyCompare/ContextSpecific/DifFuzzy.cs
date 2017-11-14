using FuzzyRanks.Matching;
using FuzzyRanks.Matching.FuzzyCompare.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FuzzyRanks.Matching.FuzzyCompare.ContextSpecific
{
    public class DifFuzzy
    {
        public float Match_Threshold;


        private DiceCoefficent comparer;

   
        private String[] RemoveWord = { " la ", " and " , " & " , "hotel" , " spa " , " resort " , " apartamentos " , " apartment " , " de " };

        public DifFuzzy()
        {
            comparer = new DiceCoefficent();
          

        }

        public  float Compare(string source1, string target1)
        {
            String source = Normalizer.WordNornalize(RemoveWord,source1);
            string target = Normalizer.WordNornalize(RemoveWord,target1);
            return comparer.Compare(source, target);
        }


    }
}
