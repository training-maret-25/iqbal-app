using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

public class KonversiWaktu
{
    public static void Main(string[] args)
    {
        int TotalDetik = 3661;

        int Jam = TotalDetik / 3600;
        int SisaDetik = TotalDetik % 3600;
        int Menit = SisaDetik / 60;
        int detik = SisaDetik % 60;


        Console.WriteLine($"{Jam} Jam {Menit} Menit {detik} detik");

    }
}