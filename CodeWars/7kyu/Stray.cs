using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class Kata
    {
        public static int Stray(int[] numbers)
        {
           var i = 0;
           foreach(var n in numbers)
           {
                if (numbers.Any(n) == true)
                {
                    i = n;
                }
           }
            return i;
        }
    }
}
