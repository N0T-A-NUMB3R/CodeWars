using System;
using System.Collections.Generic;

public class SumDigNth
{

    public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
    {
        var list = CreateToSum(patternl, nthterm - 1);
        foreach (var elem in list)
        {
            initval += elem;
        }

        return sumDigits(initval);
    }

    private static List<long> CreateToSum(long[] patternl, int n)
    {
        var output = new List<long>();
        foreach (var elem in infiniteL(patternl))
        {
            if (output.Count < n)
            {
                output.Add(elem);
            }
            else
            {
                break;
            }

        }

        return output;
    }

    private static IEnumerable<long> infiniteL(long[] pattern)
    {
        while (true)
        {
            foreach (var p in pattern)
            {
                yield return p;
            }
        }
    }
    public static long sumDigits(long num)
    {
        long sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}