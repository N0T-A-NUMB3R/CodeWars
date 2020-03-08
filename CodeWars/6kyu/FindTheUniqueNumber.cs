using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var output = 0;
        foreach (var n in numbers)
        {
            if (numbers.Where(x => x == n).Count() == 1)
            {
                output = n;
                break;
            }
        }
        return output;
    }
}