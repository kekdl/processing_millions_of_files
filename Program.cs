using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace processing_millions_of_files
{
    class Program
    {
        static void Main(string[] args)
        {
            int fileCount = 0;
            var sw = Stopwatch.StartNew();
            var files = Directory.EnumerateFiles("/home/sasha/wargamming/1", "*.json", SearchOption.AllDirectories);
            Parallel.ForEach(files, (file) =>
            {
                string json = File.ReadAllText(file);
                fileCount++;
            });
            Console.WriteLine("Processed {0} files in {1} milliseconds", fileCount, sw.ElapsedMilliseconds);
        }
    }
}
