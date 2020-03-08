using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).Where(x => x.Value % 2 != 0).First()
                  .Key;
        }
    }
}