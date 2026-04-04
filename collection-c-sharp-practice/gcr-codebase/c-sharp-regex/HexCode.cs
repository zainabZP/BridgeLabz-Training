using System;
using System.Text.RegularExpressions;
class ValidateHexCode{
    public static void Main(){
        string hex=Console.ReadLine();
        string pattern="^[#][0-9A-Fa-f]{6}$";
        bool valid=Regex.IsMatch(hex,pattern);
        if(valid) Console.WriteLine("Valid hex code");
        else Console.WriteLine("Invalid hex code");
    }
}