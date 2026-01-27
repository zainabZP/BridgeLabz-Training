using System;
using System.Text.RegularExpressions;
class ExtractCapitalizedWords{
    public static void Main(){
        string word=Console.ReadLine();
        string pattern="[A-Z][a-z]+";
        MatchCollection matches=Regex.Matches(word,pattern);
        foreach(Match m in matches){
            Console.WriteLine(m.Value);
        }
    }
}