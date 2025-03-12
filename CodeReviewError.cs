using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;

class CodeReviewError
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt")
            .CreateLogger();

        string filePath = "config.txt";
        int maxRetry = 3;
        int retryCount = 0;
        bool success = false;

        while (retryCount < maxRetry && !success)
        {
            try
            {
                string config = CekFile(filePath);
                if (string.IsNullOrEmpty(config))
                {
                    Log.Warning("File ditemukan tetapi kosong: {FilePath}", filePath);
                    Console.WriteLine("File ditemukan tetapi kosong.");
                }
                else
                {
                    Log.Information("Konfigurasi berhasil dibaca.");
                    Console.WriteLine("Konfigurasi berhasil dibaca:\n" + config);
                }
                success = true;
            }
            catch (FileNotFoundException)
            {
                Log.Error("File tidak ditemukan: {FilePath}", filePath);
                Console.WriteLine("File tidak ditemukan.");
                break;
            }
            catch (IOException ex)
            {
                retryCount++;
                Log.Warning("Percobaan {RetryCount}: File sedang digunakan oleh proses lain. Error: {ErrorMessage}", retryCount, ex.Message);
                Console.WriteLine($"File sedang digunakan ({retryCount}/{maxRetry}). Mencoba lagi...");
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Log.Error("Kesalahan tidak terduga: {ErrorMessage}", ex.Message);
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
                break;
            }
        }

        Log.CloseAndFlush();
    }

    static string CekFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException();
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            return reader.ReadToEnd();
        }
    }

}