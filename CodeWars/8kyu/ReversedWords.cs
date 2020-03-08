using System;
using System.Linq;

public class Kata
{
    public static string ReverseWords(string str)
    {
        if (str == null)
            throw new ArgumentNullException();
        return string.Join(" ", str.Split(' ').Reverse());
    }
}