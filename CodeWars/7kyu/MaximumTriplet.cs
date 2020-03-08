using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static int MaxTriSum(int[] a)
    {
        return new List<int>(a).OrderByDescending(n => n).Distinct().Take(3).Sum();
    }
}