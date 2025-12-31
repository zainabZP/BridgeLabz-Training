using System;
class Null{
    static void Main(){
        Console.WriteLine("Enter a strings ");
        string s1=Console.ReadLine();
        Excep(s1);
    }
    static void Excep(string s1){
        try{
            if(s1.Length==0) throw new NullReferenceException();
            Console.WriteLine(s1.Length);
        }
        catch(Exception e){
            if(e is NullReferenceException)
            Console.WriteLine("null string");
        }
    }
}