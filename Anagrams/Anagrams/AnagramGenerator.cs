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

            yield return new string(originalWord.Reverse().ToArray());
        }
    }
}
