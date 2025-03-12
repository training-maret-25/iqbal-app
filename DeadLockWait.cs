using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

//Kasus 1: Deadlock karena .Wait() pada Task
class DeadLockWait
{
    public class DataFetcher
    {
        public async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000);
            return "Data Loaded";
        }
    }


    public static async Task Main()
    {
        var fetcher = new DataFetcher();
        Console.WriteLine("Fetching data...");
        string result = await fetcher.FetchDataAsync();// ⚠️ Deadlock di UI Thread
        Console.WriteLine(result);
    }
}