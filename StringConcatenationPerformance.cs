using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationPerformance
{
    static void Main()
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };

        foreach (int size in datasetSizes)
        {
            string[] strings = new string[size];
            for (int i = 0; i < size; i++)
            {
                strings[i] = "a";
            }

            GC.Collect(); // Minimize GC interference before timing
            Console.WriteLine($"\nConcatenating {size} strings:");

            // Using string concatenation
            Stopwatch stopwatch = Stopwatch.StartNew();
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += strings[i];
            }
            stopwatch.Stop();
            Console.WriteLine($"String concatenation time: {stopwatch.ElapsedMilliseconds} ms");

            // Using StringBuilder
            GC.Collect();
            stopwatch = Stopwatch.StartNew();
            StringBuilder stringBuilder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append(strings[i]);
            }
            result = stringBuilder.ToString();
            stopwatch.Stop();
            Console.WriteLine($"StringBuilder concatenation time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
