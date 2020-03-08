using System.Linq;

public class Kata
{
    public static int Grow(int[] x)
    {
        var toMul = x[0];
        foreach (var elem in x.Skip(1))
        {
            toMul *= elem;
        }
        return toMul;
    }
}