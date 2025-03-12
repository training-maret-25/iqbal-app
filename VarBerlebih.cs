using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

public class VarBerlebih
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        var result = numbers.Select(x => x * 2).Where(x => x > 50);
        foreach (int item in result)
        {
            Console.WriteLine(item);
        }
    }
}