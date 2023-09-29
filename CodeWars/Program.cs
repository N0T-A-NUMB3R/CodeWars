using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    class Program
    {
        public static string Add(string a, string b)
        {
            static string Nums(long num) => string.Concat(num.ToString().OrderByDescending(i => i));
            var num = Nums(n);
            if (num == n.ToString())
            {
                return -1;
            }
            do
            {
                n++;
            } while (Nums(n) != num);

            return n;
        }

    }
    }
}