using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

// Soal array tanpa parameter
class ArraytakBerparameter
{
    static int hitungNumber(int[] angka)
    {
        int sum = 0;

        foreach (int num in angka)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var hasil = hitungNumber(numbers);
        Console.WriteLine("Total: " + hasil);
    }
}
