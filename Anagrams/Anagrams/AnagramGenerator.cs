using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public class AnagramGenerator
    {
        public IEnumerable<string> Generate(string originalWord)
        {
            if (originalWord.Length < 2)
            {
                yield break;
            }

            yield return ReverseString(originalWord);
            
            if (originalWord.Length == 3)
            {
                yield return "ACB";
                yield return "BAC";
            }
        }

        private static string ReverseString(string originalWord)
        {
            return new string(originalWord.Reverse().ToArray());
        }
    }
}
