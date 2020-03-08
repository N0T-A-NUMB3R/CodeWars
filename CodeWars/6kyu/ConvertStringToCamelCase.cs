
using System;
using System.Collections.Generic;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        if (str == null)
            throw new ArgumentNullException("str");

        var chars = new List<Char>();
        bool upper = false;
        foreach (var s in str)
        {
            if (upper)
            {
                chars.Add(Char.ToUpper(s));
                upper = false;
                continue;
            }

            if (s.Equals('-') || s.Equals('_'))
            {
                upper = true;
                continue;
            }

            chars.Add(s);
        }
        return string.Join("", chars);
    }
}