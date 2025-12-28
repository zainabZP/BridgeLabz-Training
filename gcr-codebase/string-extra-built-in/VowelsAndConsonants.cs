using System;
class VowelsAndConsonants{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s=Console.ReadLine();
        int v=0,con=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'||s[i]=='A'||s[i]=='E'||s[i]=='I'||s[i]=='O'||s[i]=='U'){
                v++;
            }
            else{
                con++;
            }
        }
        Console.WriteLine("Total Vowels = "+v);
        Console.WriteLine("Total Consonants = " +con);
    }
}
