using System;
using System.Text.RegularExpressions;
class ExtractLinks{
    public static void Main(){
        string date=Console.ReadLine();
        string pattern = "[a-z]+://[a-zA-Z0-9./?=&_-]+";
        MatchCollection matches=Regex.Matches(date,pattern);
        foreach(Match m in matches){
            Console.WriteLine(m.Value);
        }
    }
}