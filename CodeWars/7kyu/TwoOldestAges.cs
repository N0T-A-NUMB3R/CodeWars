using System;
using System.Collections.Generic;
using System.Linq;

public class LargestTwo
{
    public static int[] TwoOldestAges(int[] ages)
    {
        if (ages == null) 
            throw new ArgumentNullException();
        return ages.OrderByDescending(n => n).Take(2).Reverse().ToArray();
    }
}