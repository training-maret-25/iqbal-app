using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class RedudantIfElse
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckNumber(5));
        Console.WriteLine(CheckNumber(-3));
        Console.WriteLine(CheckNumber(0));
    }

    public static string CheckNumber(int n)
    {
        return (n > 0) ? "positif" :
               (n < 0) ? "negatif" : "zero";

    }
}