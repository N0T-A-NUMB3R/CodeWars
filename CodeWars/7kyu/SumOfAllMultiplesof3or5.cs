
namespace Solution
{
    public static class Program
    {
        public static int findSum(int n)
        {
            return Enumerable.Range(0, n + 1).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
