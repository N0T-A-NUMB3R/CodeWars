using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string Order(string words)
    {
        var split = words.Split(' ').ToList();
        var count = 1;
        var output = new List<string>();
        while (count <= split.Count)
        {
            foreach (var s in split)
            {
                if (s.Contains(count.ToString()))
                    output.Add(s);
            }

            count++;
        }
        return string.Join(" ", output);
    }
}