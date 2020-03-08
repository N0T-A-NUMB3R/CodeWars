using System;
using System.Linq;
using System.Text;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        if (word == null)
            throw new ArgumentNullException();
        var aux = new StringBuilder();
        foreach (var letter in word)
        {
            aux.Append(word.Count(x => x == char.ToLower(letter) || x == char.ToUpper(letter)) > 1 ? ")" : "(");
        }
        //too many queries, it isn't a good solution :(

        return aux.ToString();

    }
}