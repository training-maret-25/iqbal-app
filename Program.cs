using System;
using System.Linq; 
using System.Collections.Generic;

// soal Kasus: Reverse Array (Easy-Medium)
public class Program
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


// soal Kasus: Pangram Checker (Medium)

public class Program
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


// soal Kasus: Ganjil atau Genap (Medium-Hard)

public class Program
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


// soal Kasus: Konversi Detik ke Format Jam  (Hard)

public class Program
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

// soal Kasus: Anagram Checker  (Hard)

public class Program
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

// soal Tidak Ada Error Handling dalam Input User

public class Program
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

// soal Redundant If-Else Statement

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckNumber(5));
        Console.WriteLine(CheckNumber(-3));
        Console.WriteLine(CheckNumber(0));
    }

    public static string CheckNumber(int n)
    {
        return (n > 0) ? "positif" :
               (n < 0) ? "negatif" : "zero";

    }
}

Debugging Test - Collections & LINQ (I)

// soal Temukan Buku dengan Jumlah Halaman Terbanyak

class Program
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


// soal Hitung Total Jumlah Produk di Setiap Gudang

class Program
{

    static void Main()
    {
        Dictionary<string, int> warehouseStock = new Dictionary<string, int>
        {
            { "Gudang A", 500 },
            { "Gudang B", 1200 },
            { "Gudang C", 750 },
            { "Gudang D", 300 }
        };

        int totalPrice = warehouseStock.Sum(w => w.Value);
        Console.WriteLine($"total harga : {totalPrice}");

    }
}


// soal Cari Mahasiswa dengan IPK Tertinggi

class Program
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

// soal Ambil 3 Produk Terlaris Berdasarkan Jumlah Penjualan

class Program
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

// soal Filter Nama Pegawai yang Mengandung Huruf 'A'

static void Main()
{
    Dictionary<string, string> employees = new Dictionary<string, string>
        {
            { "E001", "Andi" },
            { "E002", "Budi" },
            { "E003", "Catherine" },
            { "E004", "Dewi" },
            { "E005", "Eka" }


        };

    var CariA = employees.Where(e => e.Value.ToUpper().Contains("A"))
                         .Select(e => e.Value)
                         .ToList();

    foreach (var item in CariA)
    {
        Console.WriteLine(item);
    }
}
