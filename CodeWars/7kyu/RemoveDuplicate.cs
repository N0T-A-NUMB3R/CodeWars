﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string RemoveDuplicateWords(string s)
    {
        return string.Join(" ", s.Split(' ').Distinct());
    }
}