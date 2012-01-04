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
                // Input ABC
                foreach (var character in originalWord)
                {
                    char currentCharacter = character;
                    var originalWordLessOneCharacter = ConvertEnumerableOfCharToString(originalWord.Where(c => c != currentCharacter));

                    yield return character + ReverseString(originalWordLessOneCharacter);
                    yield return character + originalWordLessOneCharacter;
                }
            }
        }

        private static string ConvertEnumerableOfCharToString(IEnumerable<char> enumerable)
        {
            return new string(enumerable.ToArray());
        }

        private static string ReverseString(string originalWord)
        {
            return ConvertEnumerableOfCharToString(originalWord.Reverse());
        }
    }
}
