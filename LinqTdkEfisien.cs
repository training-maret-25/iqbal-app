using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


class LinqTdkEfisien
{


    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine(string.Join(", ", evenNumbers));
    }
}