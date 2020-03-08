using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {

        if (arr == null) throw new ArgumentNullException();
        if (x <= 0) throw new ArgumentException();
        var dic = new Dictionary<int, int>();
        var output = new List<int>();
        foreach (var elem in arr)
        {
            if (dic.ContainsKey(elem))
            {
                dic[elem] += 1;
            }
            else
            {
                dic.Add(elem, 1);
            }
            if (dic[elem] <= x)
                output.Add(elem);

        }

        return output.ToArray();
    }
}