using System;
using System.Linq;
using System.Collections.Generic;

public class Brace
{
    public static bool validBraces(String braces)
    {
        int level = 0;
        char[] c = braces.ToCharArray();
        char[] check = new char[c.Length * 10];
        foreach (var item in c)
        {
            Console.WriteLine("letter = " + item);
            if (item == '(' || item == '{' || item == '[')
            {
                level++; check[level] = item;
            }
            if (item == ')' && check[level] == '(')
            {
                level--;
            }
            else
            {
                if (item == ')' && check[level] != '(')
                {
                    level = level + 10;
                }
            }
            if (item == '}' && check[level] == '{')
            {
                level--;
            }
            else
            {
                if (item == '}' && check[level] != '{')
                {
                    level = level + 10;
                }
            }
            if
                (item == ']' && check[level] == '[')
            {
                level--;
            }
            else
            {
                if (item == ']' && check[level] != '[')
                {
                    level = level + 10;
                }
            }
        }

        return level == 0;
    }
}