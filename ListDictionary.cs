using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class ListDictionary
{


    static void Main()
    {
        var Employees = new Dictionary<int, string>();

        Employees[1] = "Andi";
        Employees[2] = "Budi";
        Employees[3] = "Sindy";

        Console.WriteLine($"nama berdasarlan id {Employees[1]}");
    }
}
