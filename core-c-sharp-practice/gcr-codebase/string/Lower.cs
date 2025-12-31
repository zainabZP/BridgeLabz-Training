using System;
class ConvertToLower{
    static void Main(){
        Console.WriteLine("Enter a strings in capital letters: ");
        string s1=Console.ReadLine();
        Console.WriteLine("String convert to lower case using custom method : "+Lower(s1));
        Console.WriteLine("String convert to lower case using built-in method : "+s1.ToLower());
    }
    static string Lower(string s1){
        string r="";
        for (int i=0;i<s1.Length;i++){
            int x=(int)s1[i]+32;
            char ch=(char)x;
            r+=ch;
        }
        return r;
    }
}