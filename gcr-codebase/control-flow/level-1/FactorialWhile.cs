using System;
class FactorialWhile{
    static void Main(){
        // enter the number whose factorial to be calculated
        int n=int.Parse(Console.ReadLine());
        // checks if n>1
        if (n>=1){
            // if n>1 calculate its factorial using while loop and store result in variable f;
            int f = 1;
            int i = 1;
            while (i<=n){
                f=f*i; i++;
            }
            // print factorial of the number
            Console.WriteLine("Factorial = " +f );
        }
        // if n<1, ask user to enter a positive integer
        else{
            Console.WriteLine("enter a positive integer");
        }
    }
}
