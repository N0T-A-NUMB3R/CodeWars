using System;
using System.Linq;

public class Kata
{
    public static string OddOrEven(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException();
        return (array.Sum() % 2 == 0) ? "even" : "odd";

    }
}