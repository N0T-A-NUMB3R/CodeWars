using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        var sum = 0;
        foreach (var item in arr)
        {
            if (item > 0)
                sum += item;
        }
        return sum;
    }
}