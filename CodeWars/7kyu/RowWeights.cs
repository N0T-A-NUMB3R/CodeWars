using System;
using System.Collections.Generic;

class Kata
{
    public static int[] RowWeights(int[] a)
    {
        var l = new List<int>(a);
        var evenIndex = 0;
        var oddIndex = 0;
        for (int i = 0; i < l.Count; i++)
        {
            if (i % 2 == 0)
                evenIndex += l[i];
            else
            {
                oddIndex += l[i];
            }
        }

        return new List<int>() { evenIndex, oddIndex }.ToArray();
    }
}