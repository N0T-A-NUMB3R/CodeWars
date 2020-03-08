using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static int MinSum(int[] a)
    {
        var list = new List<int>(a).OrderByDescending(x => x);
        var output = 0;
        var indexmax = list.Count() - 1;

        foreach (var elem in list)
        {
            output += elem * list.ElementAt(indexmax);
            indexmax--;
        }

        return output / 2;
    }
}