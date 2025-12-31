using System;
class Compare{
    static void Main(){
        Console.WriteLine("Enter two strings : ");
        string s1=Console.ReadLine();
        string s2=Console.ReadLine();
        bool r=CompareString(s1,s2);
        if(r) Console.WriteLine("strings are equal using method");
        else Console.WriteLine("strings are not equal");
        if(s1.Equals(s2)) Console.WriteLine("both strings are equal according to .Equals()");
        else Console.WriteLine("strings are not equal");
    }
    static bool CompareString(string s1, string s2){
        if (s1.Length!=s2.Length) return false;
        for (int i=0;i<s1.Length;i++){
            if(s1[i]!=s2[i]) return false;
        }
        return true;
    }
}