using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;

// soal Kasus: Reverse Array (Easy-Medium)
public class ReverseArray
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}