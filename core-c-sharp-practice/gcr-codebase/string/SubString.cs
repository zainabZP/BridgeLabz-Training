using System;
class Compare{
    static void Main(){
        Console.WriteLine("Enter a strings, start, end : ");
        string s1=Console.ReadLine();
        int s=int.Parse(Console.ReadLine());
        int e=int.Parse(Console.ReadLine());
        Console.WriteLine("substring using method = "+SubString(s1,s,e));
        Console.WriteLine("substring using built-in = "+s1.Substring(s,e));
    }
    static string SubString(string s1, int s, int e){
        string sub="";
        int idx=s;
        for(int i=0;i<e;i++){
            sub+=s1[idx];
            idx++;
        }
        return sub;
    }
}