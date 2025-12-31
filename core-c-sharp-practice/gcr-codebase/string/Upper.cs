using System;
class ConvertToUpper{
    static void Main(){
        Console.WriteLine("Enter a strings in small letters: ");
        string s1=Console.ReadLine();
        Console.WriteLine("String convert to uppercase using custom method : "+Upper(s1));
        Console.WriteLine("String convert to uppercase using built-in method : "+s1.ToUpper());
    }
    static string Upper(string s1){
        string r="";
        for (int i=0;i<s1.Length;i++){
            int x=(int)s1[i]-32;
            char ch=(char)x;
            r+=ch;
        }
        return r;
    }
}