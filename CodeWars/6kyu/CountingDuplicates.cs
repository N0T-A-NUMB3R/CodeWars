using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        if (str == null) throw new ArgumentNullException();
        var aux = new Dictionary<char, int>();
        foreach (var car in str)
        {
            if (Char.IsUpper(car))
            {
                var c = Char.ToLower(car);
                if (aux.ContainsKey(Char.ToLower(car)))
                {
                    aux[c]++;
                }
                else
                {
                    aux.Add(c, 1);
                }
            }
            else
            {
                if (aux.ContainsKey(Char.ToLower(car)))
                {
                    aux[car]++;
                }
                else
                {
                    aux.Add(car, 1);
                }
            }

        }

        return aux.Count(c => c.Value > 1);
    }
}