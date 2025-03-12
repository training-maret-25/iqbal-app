using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;


class Buku
{

    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

    }

    static void Main()
    {
        Book[] Buku = new Book[]
        {
            new Book { Title = "The Alchemist", Pages = 208 },
            new Book { Title = "Harry Potter", Pages = 350 },
            new Book { Title = "Inferno", Pages = 480 },
            new Book { Title = "Atomic Habits", Pages = 320 }
        };

        var bukuTerbanyak = Buku.OrderByDescending(b => b.Pages).First();

        Console.WriteLine($"BuKu Yang kertanya paling banyak adalah : {bukuTerbanyak.Title} dengan {bukuTerbanyak.Pages} lembar.");


    }
}