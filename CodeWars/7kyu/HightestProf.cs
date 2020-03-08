using System;
using System.Linq;

public class MinMax
{
    public static int[] minMax(int[] lst)
    {
        var ints = lst.OfType<int>().ToList();
        return new[] { ints.Min(), ints.Max() };
    }
}