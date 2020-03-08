using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str)
    {
        var aux = str.ToCharArray();
        Array.Reverse(aux);
        return new string(aux);
    }
}