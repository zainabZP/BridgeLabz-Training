using System;
using System.Text.RegularExpressions;
class ReplaceSpaces{
    public static void Main(){
       string sentence=Console.ReadLine();
       Console.WriteLine(sentence);
       string pattern="[ ]+";
       string result=Regex.Replace(sentence,pattern," ");
       Console.WriteLine(result);
    }
}