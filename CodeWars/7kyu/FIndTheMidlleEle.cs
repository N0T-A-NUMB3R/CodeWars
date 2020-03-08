using System;
using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
    public static int Gimme(double[] inputArray)
    {
        return inputArray.TakeWhile(elem => elem == inputArray.Max() || elem == inputArray.Min()).Count();
    }
}
