using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
    public static long rowSumOddNumbers(long n)
    {
        return InfiniteOdd().ElementAt((int)n - 1).Sum();
    }

    public static IEnumerable<IEnumerable<long>> InfiniteOdd()
    {
        long start = 1;
        var output = new List<long>();
        output.Add(start);
        yield return output;
        var nPack = 2;
        while (true)
        {
            output = new List<long>(nPack);
            for (int i = 0; i < nPack; i++)
            {
                start = start + 2;
                output.Add(start);
            }

            yield return output;
            nPack += 1;

        }
    }
}