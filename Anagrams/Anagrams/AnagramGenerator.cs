﻿using System;
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

            var generatedAnagrams = new List<string>();

            generatedAnagrams.Add(ReverseString(originalWord));
            yield return ReverseString(originalWord);
            
            if (originalWord.Length == 3)
            {
                foreach (var character in originalWord)
                {
                    char currentCharacter = character;
                    var originalWordLessOneCharacter = ConvertEnumerableOfCharToString(originalWord.Where(c => c != currentCharacter));

                    var transposition = character + ReverseString(originalWordLessOneCharacter);
                    if (!generatedAnagrams.Contains(transposition))
                    {
                        generatedAnagrams.Add(transposition);
                        yield return transposition;
                    }

                    transposition = character + originalWordLessOneCharacter;
                    if (transposition != originalWord && !generatedAnagrams.Contains(transposition))
                    {
                        generatedAnagrams.Add(transposition);
                        yield return transposition;
                    }
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
