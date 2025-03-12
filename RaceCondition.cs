using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

class RaceCondition
{
    public class Counter
    {
        private int _count = 0;
        private static readonly object lockObj = new object();

        public async Task IncrementAsync()
        {

            await Task.Delay(100);
            lock (lockObj)
                _count++; // ⚠️ Race Condition saat banyak task berjalan
        }
        public int GetCount() => _count;
    }


    public static async Task Main()
    {
        var counter = new Counter();
        var tasks = new List<Task>();
        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(counter.IncrementAsync());
        }
        await Task.WhenAll(tasks);
        Console.WriteLine($"Final Count: {counter.GetCount()}"); // ⚠️ Hasilnya tidak selalu 1000
    }
}