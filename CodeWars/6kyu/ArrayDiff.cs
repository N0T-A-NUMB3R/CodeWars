using System.Linq;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        return a.Where(i => !b.Contains(i)).ToArray();
    }
}