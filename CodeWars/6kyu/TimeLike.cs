using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static string FormatTime(int hour)
    {
        var sb = new StringBuilder();
        foreach (var c in toTime(hour.ToString()))
            sb.Append(c);

        return sb.ToString();
    }
    public static IEnumerable<char> toTime(string s)
    {
        var primo = true;
        if (s.Length == 3)
            foreach (var elem in s)
            {
                if (primo)
                {
                    yield return elem;
                    yield return ':';
                    primo = false;
                }
                else
                {
                    yield return elem;
                }
            }

        if (s.Length == 4)
        {
            yield return s.Take(1).First();

            foreach (var elem in s.Skip(1))
            {
                if (primo)
                {
                    yield return elem;
                    yield return ':';
                    primo = false;
                }
                else
                {
                    yield return elem;
                }
            }
        }
        if (s.Length > 4 || s.Length < 3)
            throw new ArgumentException();
    }
}