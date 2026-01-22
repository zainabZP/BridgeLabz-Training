using System;
using System.IO;

class StudentBinary
{
    static void Main()
    {
        using (BinaryWriter bw =
            new BinaryWriter(File.Open("input.txt", FileMode.Create)))
        {
            bw.Write(101);
            bw.Write("Rahul");
            bw.Write(8.6);
        }

        using (BinaryReader br =
            new BinaryReader(File.Open("input.txt", FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
