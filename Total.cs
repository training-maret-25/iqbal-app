using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class Total
{

    static void Main()
    {
        Dictionary<string, int> warehouseStock = new Dictionary<string, int>
        {
            { "Gudang A", 500 },
            { "Gudang B", 1200 },
            { "Gudang C", 750 },
            { "Gudang D", 300 }
        };

        int totalPrice = warehouseStock.Sum(w => w.Value);
        Console.WriteLine($"total harga : {totalPrice}");

    }
}