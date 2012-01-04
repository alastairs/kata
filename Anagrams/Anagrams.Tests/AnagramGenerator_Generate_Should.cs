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
            var anagrams = new Anagrams.AnagramGenerator();

            var generatedAnagrams = anagrams.Generate(string.Empty);

            CollectionAssert.IsEmpty(generatedAnagrams);
        }
    }
    // ReSharper restore InconsistentNaming
}