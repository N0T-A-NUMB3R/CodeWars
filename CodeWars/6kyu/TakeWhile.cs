using System;
using System.Linq;
using System;
using System.Collections.Generic;

public class Kata
{
    public static int[] TakeWhile(int[] arr, Func<int, bool> pred)
    {
        var list = new List<int>();
        foreach (var elem in arr)
        {
            if (pred(elem))
                list.Add(elem);
            else
                break;
        }

        return list.ToArray();
    }
}