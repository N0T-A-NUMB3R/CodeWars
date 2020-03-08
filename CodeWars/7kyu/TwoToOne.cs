using System;
using System.Collections.Generic;
using System.Linq;

public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        if (s1 == null || s2 == null)
            throw new ArgumentNullException();

        var output = s1 + s2;
        return String.Concat(output.OrderBy(c => c).Distinct());


    }