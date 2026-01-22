using System;
using System.IO;
using System.Diagnostics;

class BufferedVsNormal
{
    static void Main()
    {
        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        // Normal FileStream
        sw.Start();
        using (FileStream fsRead = new FileStream("input.txt", FileMode.Open))
        using (FileStream fsWrite = new FileStream("normalCopy.txt", FileMode.Create))
        {
            int bytes;
            while ((bytes = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytes);
            }
        }
        sw.Stop();
        Console.WriteLine("Normal Stream Time: " + sw.ElapsedMilliseconds + " ms");

        // Buffered Stream
        sw.Restart();
        using (BufferedStream bsRead =
            new BufferedStream(new FileStream("input.txt", FileMode.Open)))
        using (BufferedStream bsWrite =
            new BufferedStream(new FileStream("bufferedCopy.txt", FileMode.Create)))
        {
            int bytes;
            while ((bytes = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytes);
            }
        }
        sw.Stop();
        Console.WriteLine("Buffered Stream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
