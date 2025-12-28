using System;
class RemoveCharacter{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s =Console.ReadLine();
        Console.WriteLine("Enter character to remove:");
        char ch =Console.ReadLine()[0];
        string result = "";
        for (int i =0;i<s.Length;i++){
            if (s[i] != ch){
                result +=s[i];
            }
        }
        Console.WriteLine("Modified String: " +result);
    }
}
