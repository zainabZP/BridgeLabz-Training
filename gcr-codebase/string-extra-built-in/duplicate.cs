using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        string n="";
        for(int i=0;i<s.Length-1;i++){
            if(s[i]!=s[i+1]) n+=s[i];
        }
        n+=s[s.Length-1];
        Console.WriteLine("Without Duplicates: " +n);
    }
}
