using System.Collections.Generic;
using System;
using System.Linq;
public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        T previous = default(T);
        foreach (T current in iterable)
        {
            if (!current.Equals(previous))
            {
                previous = current;
                yield return current;
            }
        }
    }
}