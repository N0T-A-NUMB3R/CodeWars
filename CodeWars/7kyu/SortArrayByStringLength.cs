using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        return array.ToList().OrderBy(x => x.Length).ToArray();
    }
}