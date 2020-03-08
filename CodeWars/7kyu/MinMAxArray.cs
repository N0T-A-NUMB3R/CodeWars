using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<int> Solve(List<int> arr)
    {
        if (arr == null) throw new ArgumentNullException();
        return Output(arr).ToList();
    }

    private static IEnumerable<int> Output(IEnumerable<int> arr)
    {
        IEnumerable<int> MinList = arr.OrderBy(min => min);
        IEnumerable<int> MaxList = arr.OrderByDescending(max => max);
        var output = new List<int>();
        while (MaxList.Any())
        {
            output.Add(MaxList.Take(1).First());
            if (MinList.Any())
                output.Add(MinList.Take(1).First());
            MaxList = MaxList.Skip(1);
            MinList = MinList.Skip(1);
        }

        return output.Take(arr.Count());
    }
}