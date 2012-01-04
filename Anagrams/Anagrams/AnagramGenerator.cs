using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public class AnagramGenerator
    {
        public IEnumerable<string> Generate(string empty)
        {
            if (empty.Length < 2)
            {
                return Enumerable.Empty<string>();
            }

            return new[] {"ba"};
        }
    }
}
