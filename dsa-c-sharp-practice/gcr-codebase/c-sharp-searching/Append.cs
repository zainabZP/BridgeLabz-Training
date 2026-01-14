using System;
using System.Text;
class AppendString{
    public static void Main(){
        StringBuilder sb=new StringBuilder(Console.ReadLine());
        sb.Append(Console.ReadLine());
        Console.WriteLine(sb.ToString());
    }
}