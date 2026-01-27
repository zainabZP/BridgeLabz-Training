using System;
using System.Text.RegularExpressions;
class ValidateNumberPlate{
    public static void Main(){
        string number=Console.ReadLine();
        string pattern="^[A-Z]{2}[0-9]{4}$";
        bool valid=Regex.IsMatch(number,pattern);
        if(valid) Console.WriteLine("Valid NumberPlate");
        else Console.WriteLine("Invalid Number Plate");
    }
}