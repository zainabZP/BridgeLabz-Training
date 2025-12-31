using System;
class Format{
    static void Main(){
        Console.WriteLine("Enter a string ");
        string s1=Console.ReadLine();
        Excep(s1);
    }
    static void Excep(string s1){
        try{
            int n=int.Parse(s1);
            Console.WriteLine();
        }
        catch(Exception e){
            if(e is FormatException )
            Console.WriteLine("FormatException");
        }
    }
}