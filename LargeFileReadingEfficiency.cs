using System;
using System.IO;
using System.Diagnostics;

class LargeFileReadingEfficiency
{
    static void Main(string[] args)
    {
        string filePath = "a.txt"; // Ensure different sizes (1MB, 100MB, 500MB)

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
            return;
        }

        try
        {
            // Measure time taken by StreamReader (Optimized: Reading line by line)
            Stopwatch stopwatch = Stopwatch.StartNew();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null) { }  // Read line-by-line instead of character-by-character
            }
            stopwatch.Stop();
            Console.WriteLine($"StreamReader (line-by-line): {stopwatch.ElapsedMilliseconds} ms");

            // Measure time taken by FileStream with BufferedStream (Optimized)
            stopwatch.Restart();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
            using (BufferedStream bufferedStream = new BufferedStream(fileStream, 8192)) // 8KB buffer
            {
                byte[] buffer = new byte[8192]; // 8KB buffer
                while (bufferedStream.Read(buffer, 0, buffer.Length) > 0) { }
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered FileStream: {stopwatch.ElapsedMilliseconds} ms");

        }
        catch (IOException ex)
        {
            Console.WriteLine($"File reading error: {ex.Message}");
        }
    }
}
