using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;

public class PangramCheker
{
    public static void Main(string[] args)
    {
        string str = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine("\"{0}\" adalah pangram: {1}", str, CheckPangram(str));
        Console.ReadKey();
    }

    static bool CheckPangram(string str)
    {
        return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
    }
}