using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        string result="";
        for(int i=0;i<s.Length;i++){
            if (char.IsUpper(s[i])) result+=char.ToLower(s[i]);
            else result+=char.ToUpper(s[i]);
        }
        Console.WriteLine("Toggled string = " + result);
    }
}
