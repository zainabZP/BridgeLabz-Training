using System;
class ArrayRange{
    static void Main(){
        Console.WriteLine("enter index");
        int i=int.Parse(Console.ReadLine());
        string[] s1={"a","b","c","d","e"};
        Excep(s1,i);
    }
    static void Excep(string[] s1, int i){
        try{
            Console.WriteLine(s1[i]);
        }
        catch(Exception e){
            if(e is  IndexOutOfRangeException)
            Console.WriteLine("index out of bound of array");
        }
    }
}