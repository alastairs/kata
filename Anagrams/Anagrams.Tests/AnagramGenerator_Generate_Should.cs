﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Anagrams.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class AnagramGenerator_Generate_Should
    {
        [Test]
        public void ReturnAnEmptyCollection_WhenGivenAnEmptyString()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate(string.Empty);

            CollectionAssert.IsEmpty(generatedAnagrams);
        }

        [Test]
        public void ReturnAnEmptyCollection_WhenGivenASingletonString()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("a");

            CollectionAssert.IsEmpty(generatedAnagrams);
        }

        [Test]
        public void ReturnTheReverseOfTheString_WhenTheStringIsTwoLetters()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("ab");

            CollectionAssert.Contains(generatedAnagrams, "ba");
        }

        [Test]
        public void ReturnOnlyOneAnagram_WhenTheStringIsTwoLetters()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("ab").ToList();

            Assert.That(generatedAnagrams, Has.Count.EqualTo(1));
        }

        [Test]
        public void ReturnTheStringCBAInTheOutput_WhenTheInputStringIsABC()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("abc").ToList();

            Assert.That(generatedAnagrams, Contains.Item("cba"));
        }

        [Test]
        public void ReturnTheStringACBInTheOutput_WhenTheInputStringIsABC()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("abc").ToList();

            Assert.That(generatedAnagrams, Contains.Item("acb"));
        }

        [Test]
        public void ReturnTheStringBACInTheOutput_WhenTheInputStringIsABC()
        {
            var anagrams = new AnagramGenerator();

            var generatedAnagrams = anagrams.Generate("abc").ToList();

            Assert.That(generatedAnagrams, Contains.Item("bac"));
        }

        [Test]
        public void NotReturnTheOriginalWordInTheOutput()
        {
            var anagrams = new AnagramGenerator();
            const string originalWord = "abc";

            var generatedAnagrams = anagrams.Generate(originalWord).ToList();

            CollectionAssert.DoesNotContain(generatedAnagrams, originalWord);
        }
    }
    // ReSharper restore InconsistentNaming
}