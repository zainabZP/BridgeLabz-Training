using System;
class Argument{
    static void Main(){
        Console.WriteLine("Enter a string, strt index and end index ");
        string s1=Console.ReadLine();
        int s=int.Parse(Console.ReadLine());
        int e=int.Parse(Console.ReadLine());
        Excep(s1,s,e);
    }
    static void Excep(string s1, int s, int end){
        try{
            string sub="";
            if(s<=end){
                for(int i=s;i<=end;i++){
                    sub+=s1[i];
                }
                Console.WriteLine(sub);
            }
            else throw new ArgumentOutOfRangeException();
        }
        catch(Exception e){
            if(e is  ArgumentOutOfRangeException)
            Console.WriteLine("argument out of range");
        }
    }
}