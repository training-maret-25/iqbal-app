using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;


class ProdukTerlaris
{
    class SoldProduct
    {
        public string Name { get; set; }
        public int SoldQuantity { get; set; }
    }

    static void Main()
    {
        SoldProduct[] soldProducts = new SoldProduct[]
         {
            new SoldProduct { Name = "Headphone", SoldQuantity = 150 },
            new SoldProduct { Name = "Laptop", SoldQuantity = 80 },
            new SoldProduct { Name = "Smartphone", SoldQuantity = 200 },
            new SoldProduct { Name = "Keyboard", SoldQuantity = 120 },
            new SoldProduct { Name = "Mouse", SoldQuantity = 90 }
         };

        var penjualanTerbanayak = soldProducts.OrderByDescending(s => s.SoldQuantity).Take(3);

        foreach (var product in penjualanTerbanayak)
        {
            Console.WriteLine($" 3 Produk yang paling banyak terjual adalah {product.Name} terjual sebanyak {product.SoldQuantity}");
        }
    }
}