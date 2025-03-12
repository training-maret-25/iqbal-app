using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


public class Sorting
{
    static void Main()
    {
        List<string> names = new List<string> { "Zara", "Andi", "Budi", "Cindy" };
        var sortedNames = names.OrderByDescending(n => n).ToList();
        Console.WriteLine(string.Join(", ", sortedNames));

    }
}