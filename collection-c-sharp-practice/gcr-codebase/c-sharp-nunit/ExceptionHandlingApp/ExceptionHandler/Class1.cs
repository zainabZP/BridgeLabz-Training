using System;

namespace ExceptionHandler
{
    public class ExceptionHandler
    {
        // Method that divides two numbers
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Cannot divide by zero");

            return a / b;
        }
    }
}
