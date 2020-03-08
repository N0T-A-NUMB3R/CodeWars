using System.Collections.Generic;
using System.Linq;



public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        var smiles = new List<string>() { ":-)", ":~)", ":)", ";-)", ";~)", ";)", ":-D", ":~D", ":D", ";-D", ";~D", ";D" };
        return new List<string>(smileys).Count(s => smiles.Contains(s));

    }
}