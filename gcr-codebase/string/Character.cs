using System;
class Compare{
    static void Main(){
        Console.WriteLine("Enter a strings : ");
        string s1=Console.ReadLine();
        char[] sa=CharacterArray(s1);
        Console.WriteLine("characters using method: ");
        for (int i=0;i<s1.Length;i++){
            Console.Write(sa[i]+" ");
        }
        Console.WriteLine();
        char[] sb=s1.ToCharArray();
        Console.WriteLine("characters using built-in: ");
        for (int i=0;i<s1.Length;i++){
            Console.Write(sb[i]+" ");
        }
    }
    static char[] CharacterArray(string s1){
        char[] a=new char[s1.Length];
        for (int i=0;i<s1.Length;i++){
            a[i]=s1[i];
        }
        return a;
    }
}