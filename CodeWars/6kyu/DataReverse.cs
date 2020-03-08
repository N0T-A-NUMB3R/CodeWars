using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
  
    public class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            if (data == null)
                throw new ArgumentNullException();

            return GroupBin(data.ToList()).Reverse().SelectMany(x => x).ToArray();
        }
        public static IEnumerable<IEnumerable<int>> GroupBin(List<int> d)
        {
            while (d.Any())
            {
                var block = d.Take(8);
                if (block.Count() < 8) 
                    throw new ArgumentException();
                yield return block;
                d = d.Skip(8).ToList();
            }
        }
    }
}   
    }
}