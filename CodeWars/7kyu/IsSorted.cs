using System;
using System.Linq;

public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException();
        if (array.SequenceEqual(array.OrderBy(x => x)))
            return "yes, ascending";
        if (array.SequenceEqual(array.OrderByDescending(x => x)))
            return "yes, descending";
        return "no";
    }
}