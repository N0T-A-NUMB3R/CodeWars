using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        foreach (var elem in listOfItems)
        {
            if (elem is int)
                yield return (int)elem;
        }
    }
}