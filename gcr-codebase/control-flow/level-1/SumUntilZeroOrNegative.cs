using System;
class SumUntilEqualOrLessThanZero{
    static void Main(){
        // take a number as input from user
        double sum = 0.0;
        double n=double.Parse(Console.ReadLine());
        // if n is not equal to 0 then add it in sum until n is 0.
        while (n>0){
            sum=sum+n;
            n=double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Total = "+sum);
    }
}
