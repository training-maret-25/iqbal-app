using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class FilterNama
{
    static void Main()
{
    Dictionary<string, string> employees = new Dictionary<string, string>
        {
            { "E001", "Andi" },
            { "E002", "Budi" },
            { "E003", "Catherine" },
            { "E004", "Dewi" },
            { "E005", "Eka" }


        };

    var CariA = employees.Where(e => e.Value.ToUpper().Contains("A"))
                         .Select(e => e.Value)
                         .ToList();

    foreach (var item in CariA)
    {
        Console.WriteLine(item);
    }
}
}