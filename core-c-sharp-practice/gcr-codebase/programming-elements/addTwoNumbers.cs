using System;
class AddTwoNumbers
{
    static void Main(){
        // taking input of two numbers from user
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]);  // taking first number input
        int b = int.Parse(inputs[1]); // taking second number input
        int c = a + b; // calculating sum
        Console.WriteLine(c); // printing sum of two numbers
    }
}
