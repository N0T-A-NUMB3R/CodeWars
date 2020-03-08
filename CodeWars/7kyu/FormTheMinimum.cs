using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static long MinValue(int[] a)
    {
        return int.Parse(string.Join("", new List<int>(a).OrderBy(n => n).Distinct()));
    }
}