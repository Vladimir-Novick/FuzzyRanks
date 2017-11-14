using System.Text.RegularExpressions;
using FuzzyRanks.Base.Utils;
using System;

namespace FuzzyRanks.Matching
{
    public static class Normalizer
    {

        private static Regex delComment = new Regex(@"\([^\(]*\)");

        /// <summary>
        ///    Field normalization :
        ///    1) remove comments (my comments here )
        ///    2) remove Noise Words
        ///    3) Remove Noise chars 
        /// </summary>
        /// <param name="removeWord"></param>
        /// <param name="source1"></param>
        /// <returns></returns>
        public static  string WordNornalize(String[] removeWord, string source1,string NoiseChars = "-.,")
        {
            String ret = " " + source1.ToLower() + " ";

            foreach ( var repl in removeWord)
            {
                ret = ret.Replace(repl, " ");
            }

            ret = delComment.Replace(ret, ""); 
            ret = Normalizer.ReplaceUmlauts(ret);
            ret = ret.Replace("\r\n", " ");
            ret = Normalizer.RemoveNoiseChars(ret, NoiseChars, ' ');
             ret = Normalizer.RemoveMultipleSpaces(ret);
            ret = ret.Trim();
            return ret;
        }

        public static string ReplaceUmlauts(string str)
        {
            // replace umlauts
            str = str.Replace("ä", "ae")
                     .Replace("ö", "oe")
                     .Replace("ü", "ue")
                     .Replace("ß", "ss")
                     .Replace("Ä", "Ae")
                     .Replace("Ö", "Oe")
                     .Replace("Ü", "Ue");

            return str;
        }

        public static string RemoveDiacritics(string str)
        {
            return StringUtil.RemoveDiacritics(str);
        }

        public static string RemoveMultipleSpaces(string str)
        {
            return Regex.Replace(str, @"\s+", " ", RegexOptions.Multiline);
        }


        /// <summary>
        ///   remove Noise chars
        /// </summary>
        /// <param name="str"></param>
        /// <param name="noiseChars"></param>
        /// <param name="replaceChar"></param>
        /// <returns></returns>
        public static string RemoveNoiseChars(string str, string noiseChars, char replaceChar = ' ')
        {
            foreach (var singleChar in noiseChars)
            {
                str = str.Replace(singleChar, replaceChar);
            }

            return str;
        }
    }
}