using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public static class PascalsTriangleKATA
    {
        public static List<int> PascalsTriangle(int n)
        {
            var listTriangle = new List<int>();
            for (var i = 0; i < n; i++)
            {
                int currentItem = 1;
                for (int j = 0; j <= i; j++)
                {
                    listTriangle.Add(currentItem);
                    currentItem = currentItem * (i - j) / (j + 1);
                }
            }
            return listTriangle;
        }
    }
}