using System;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            if (BinaryArray == null) throw new ArgumentNullException();
            var output = 0;
            var index = 0;
            foreach (var bin in BinaryArray.Reverse())
            {
                if (bin == 0)
                {
                    index++;
                }
                else
                {
                    output += Convert.ToInt32(Math.Pow(2, index));
                    index++;
                }


            }

            return output;
        }
    }
}