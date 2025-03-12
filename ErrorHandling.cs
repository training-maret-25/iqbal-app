using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

public class ErrorHandling
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        string input = Console.ReadLine();

        if (Int32.TryParse(input, out int num))
        {
            Console.WriteLine("You entered: " + num);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}

