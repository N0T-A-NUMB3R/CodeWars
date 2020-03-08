using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        if (array == null) throw new ArgumentNullException();
        var l1 = array.Where(x => x % 2 != 0).OrderBy(x => x).ToList();
        var output = new List<int>();

        foreach (var elem in array)
        {
            if (elem % 2 == 0)
                output.Add(elem);
            else
            {
                var toAdd = l1.First();
                output.Add(toAdd);
                l1.Remove(toAdd);
            }
        }

        return output.ToArray();
    }
}