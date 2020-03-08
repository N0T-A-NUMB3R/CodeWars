using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        var letters = new string(num.ToString().ToArray());
        var aux = new List<int>();
        foreach (var l in letters)
        {
            aux.Add(int.Parse(l.ToString()));
        }
        var output = new StringBuilder();
        foreach (var a in aux.OrderByDescending(x => x))
        {
            output.Append(a);
        }
        return int.Parse(output.ToString());
    }
}