using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


public class TaskRun
{
    public async Task<string> ReadFileAsync(string path)
    {
        using (var reader = new StreamReader(path))
        {
            return await reader.ReadToEndAsync();
        }
    }
}