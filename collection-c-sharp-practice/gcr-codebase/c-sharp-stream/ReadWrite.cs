using System;
using System.IO;

class FileCopyBasic
{
    static void Main()
    {
        try
        {
            using (FileStream fsRead = new FileStream("input.txt", FileMode.Open))
            using (FileStream fsWrite = new FileStream("destination.txt", FileMode.Create))
            {
                int data;
                while ((data = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)data);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
