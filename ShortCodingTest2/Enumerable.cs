using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortCodingTest2
{
    public static class Enumerable
    {
        public static IEnumerable<int> Range(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
                yield return i;
        }
    }
}
