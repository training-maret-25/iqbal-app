using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics; 

class IterasiManual
{


    static void Main()
    {
        List<int> sales = new List<int> { 100, 200, 150, 300, 250 };


        var totalSales = sales.Sum();

        Console.WriteLine(totalSales);

    }
}