using System;
class Lexical{
    static void Main(){
        Console.WriteLine("String 1:");
        string s1 = Console.ReadLine().ToLower();
        Console.WriteLine("String 2:");
        string s2 = Console.ReadLine().ToLower();
        string ans="";int f=0;
        int min=Math.Min(s1.Length,s2.Length);
        for(int i=0;i<min;i++){
            int n1=(int)s1[i];
            int n2=(int)s2[i];
            if(n1<n2){
                ans=s1;
                f=1;
                Console.WriteLine(s1+" is lexically smaller");
                break;
            }
            else if(n2<n1){
                ans=s2;
                f=1;
                Console.WriteLine(s2+" is lexically smaller");
                break;
            }
            
        }
        if (f==0){
            if (s1.Length<s2.Length)
                Console.WriteLine(s1 + " is lexically smaller");
            else if (s2.Length < s1.Length)
                Console.WriteLine(s2 + " is lexically smaller");
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
