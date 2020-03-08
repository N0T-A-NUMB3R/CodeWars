using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        var output = new StringBuilder();
        foreach (var letter in str)
        {
            if (char.IsUpper(letter))
                output.Append(" " + letter);
            else
                output.Append(letter);
        }
        return output.ToString(); ;
    }
}