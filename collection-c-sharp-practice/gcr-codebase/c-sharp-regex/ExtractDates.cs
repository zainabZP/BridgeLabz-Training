using System;
using System.Text.RegularExpressions;
class ExtractDates{
    public static void Main(){
        string date=Console.ReadLine();
        string pattern="[0-9]{2}[/][0-9]{2}[/][0-9]{2}";
        MatchCollection matches=Regex.Matches(date,pattern);
        foreach(Match m in matches){
            Console.WriteLine(m.Value);
        }
    }
}