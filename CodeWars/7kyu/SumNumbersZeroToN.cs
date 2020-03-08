using System.Linq;

public class SequenceSum
{
    public static string ShowSequence(int n)
    {
        if (n == 0)
        {
            return "0=0";
        }
        if (n < 0)
        {
            return n.ToString() + "<0";
        }
        var list = Enumerable.Range(0, n + 1);
        return string.Join("+", list) + " " + "=" + " " + list.Sum();

    }
}