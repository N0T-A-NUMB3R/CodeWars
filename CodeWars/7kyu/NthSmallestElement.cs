using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static int NthSmallest(int[] arr, int pos)
    {
        return new List<int>(arr).OrderBy(n => n).Skip(pos - 1).First();
    }
}