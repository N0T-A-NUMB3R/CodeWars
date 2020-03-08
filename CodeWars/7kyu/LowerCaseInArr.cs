using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static object[] ArrayLowerCase(object[] arr)
    {
        var output = new List<object>();

        foreach (var elem in arr)
        {
            output.Add(elem is string ? StringToLower(((string)elem)) : elem);
        }

        return output.ToArray();
    }

    public static string StringToLower(string str)
    {
        return str.ToLower();
    }
}