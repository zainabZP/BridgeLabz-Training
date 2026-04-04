using System;
using System.Text.RegularExpressions;
class ExtractEmail{
    public static void Main(){
        string email=Console.ReadLine();
        string pattern="[a-zA-Z]+[_.a-z0-9A-Z]*[@][a-zA-Z]+[.][a-zA-Z]+";
        MatchCollection matches=Regex.Matches(email,pattern);
        foreach(Match m in matches){
            Console.WriteLine(m.Value);
        }
    }
}