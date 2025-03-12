using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class ipkTertinggi
{
    class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
    }

    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Andi", GPA = 3.2 },
            new Student { Name = "Budi", GPA = 3.8 },
            new Student { Name = "Citra", GPA = 3.5 },
            new Student { Name = "Dewi", GPA = 3.9 }
        };

        var ipkTertinggi = students.OrderByDescending(s => s.GPA).First();
        Console.WriteLine($"mahasiswa dengan ipk tertinggi adalah {ipkTertinggi.Name} dengan ipk : {ipkTertinggi.GPA}");
    }
}