using System;
class Anagram{
    static void Main(){
        Console.WriteLine("Enter string1:");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter string2:");
        string s2 = Console.ReadLine();
        if (s1.Length != s2.Length){
            Console.WriteLine("Not an anagram");
        }
        else{
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            bool f=true;
            for (int i=0;i<arr1.Length;i++){
                if (arr1[i]!=arr2[i]){
                    f=false;
                    break;
                }
            }
            if (f)
                Console.WriteLine("Strings are anagrams");
            else
                Console.WriteLine("Strings are not anagrams");
        }
        
    }
}
