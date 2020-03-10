using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns.Commons
{
    public class CsvFileReader
    {
        public static IList<string[]> Read(String filepath)
        {
            return File.ReadAllLines(filepath).Select(s => s.Split(",")).ToList();
        }
    }
}
