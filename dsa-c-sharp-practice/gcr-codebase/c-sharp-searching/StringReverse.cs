using System;
using System.Text;
class Reverse{
    public static void Main(){
        StringBuilder sb=new StringBuilder(Console.ReadLine());
        string reversed = new string(sb.ToString().Reverse().ToArray()); // ToString converts obj to string, string class implements IEnumerable<char>, Reverse() is a LINQ method Returns IEnumerable<char>, The string constructor does NOT accept IEnumerable<char>. So we must convert the sequence to a char[].
        Console.WriteLine(reversed);
    }
}