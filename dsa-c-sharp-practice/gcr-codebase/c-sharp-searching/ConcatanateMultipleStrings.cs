using System;
using System.Text;
class ConcatanateStrings{
    public static void Main(){
        StringBuilder sb=new StringBuilder(Console.ReadLine());
        for(int i=0;i<10;i++)
        sb.Append(Console.ReadLine());
        Console.WriteLine(sb.ToString());
    }
}