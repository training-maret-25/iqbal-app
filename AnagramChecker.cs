using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

public class AnagramCheker
{
    public static void Main(string[] args)
    {
        string kata1 = "listen";
        string kata2 = "silent";

        char[] kt1 = kata1.ToLower().ToCharArray();
        char[] kt2 = kata2.ToLower().ToCharArray();

        Array.Sort(kt1);
        Array.Sort(kt2);

        string val1 = new string(kt1);
        string val2 = new string(kt2);

        if (val1 == val2)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

