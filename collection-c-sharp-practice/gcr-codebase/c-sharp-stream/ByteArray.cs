using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        try
        {
            byte[] data = File.ReadAllBytes("input.txt");

            using (MemoryStream ms = new MemoryStream(data))
            {
                File.WriteAllBytes("output.txt", ms.ToArray());
            }

            Console.WriteLine("File copied using MemoryStream.");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
