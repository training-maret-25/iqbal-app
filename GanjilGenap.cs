using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

// soal Kasus: Ganjil atau Genap (Medium-Hard)

public class GanjilGenap
{
    static (string, string) SplitEvenOdd(int max)
    {
        List<int> genap = new List<int>();
        List<int> ganjil = new List<int>();

        for (int i = 1; i <= max; i++)
        {
            if (i % 2 == 0)
                genap.Add(i);
            else
                ganjil.Add(i);
        }

        string genapStr = string.Join(", ", genap);
        string ganjilStr = string.Join(", ", ganjil);

        return (genapStr, ganjilStr);
    }

    public static void Main(string[] args)
    {
        int n = 10;
        var (genapStr, ganjilStr) = SplitEvenOdd(n);

        Console.WriteLine("Bilangan Genap: " + genapStr);
        Console.WriteLine("Bilangan Ganjil: " + ganjilStr);
    }
}
