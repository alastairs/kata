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
    }
    // ReSharper restore InconsistentNaming
}