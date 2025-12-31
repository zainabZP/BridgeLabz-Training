using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        int i=0,j=s.Length-1,f=1;
        while(i<j){
            if(s[i]!=s[j]){
                Console.WriteLine("Not Palindrome");
                f=0;
                break;
            }
            i++;j--;
        }
        if (f==1) Console.WriteLine("Palindrome");
    }
}
