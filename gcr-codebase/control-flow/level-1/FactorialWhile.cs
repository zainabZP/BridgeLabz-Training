using System;
class FactorialWhile{
    static void Main(){
        // enter the number whose factorial to be calculated
        int n=int.Parse(Console.ReadLine());
        int f=1;
        int i=1;
        while (i<=n){
            f=f*i; i++;
        }
        // print factorial of the number
        Console.WriteLine("Factorial = " +f);
    }
}
