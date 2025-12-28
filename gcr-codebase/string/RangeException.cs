using System;
class Range{
    static void Main(){
        Console.WriteLine("Enter a string ");
        string s1=Console.ReadLine();
        Excep(s1);
    }
    static void Excep(string s1){
        try{
            char ch=s1[s1.Length];
            Console.WriteLine(ch);
        }
        catch(Exception e){
            if(e is  IndexOutOfRangeException)
            Console.WriteLine("index out of bound");
        }
    }
}