using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

class DebugingError
{
    static void Main()
    {
        try
        {
            string config = ReadConfig("config.txt");
            Console.WriteLine($"Config: {config}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File tidak ditemukan: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Kesalahan saat membaca file: {ex.Message}");
        }
        catch (Exception ex)
        {
            string logMessage = $"[{DateTime.Now}] ERROR: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
            File.AppendAllText("error.log", logMessage);
            Console.WriteLine("Terjadi error, cek file error.log");
        }


    }

    static string ReadConfig(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File tidak ditemukan");
            return string.Empty;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            return reader.ReadToEnd();
        }
    }


}