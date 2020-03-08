public static class Kata
{
    public static int SquareSum(int[] n)
    {
        var output = 0;
        foreach (var elem in n)
        {
            output += elem * elem;
        }
        return output;
    }
}