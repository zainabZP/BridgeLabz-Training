using System;

class LuckyDraw{
    static void Main(){
        bool exit = false;
        while (!exit){
            Console.WriteLine("Enter a number (or -1 to exit): ");
            int number = int.Parse(Console.ReadLine());
            if (number == -1){
                exit = true;
            }
            else if (number <= 0){
                Console.WriteLine("Invalid number");
            }
            else if (number % 3 == 0 && number % 5 == 0){
                Console.WriteLine(" Congratulations! You won a gift!");
            }
            else{
                Console.WriteLine("Better luck next time.");
            }
        }
    }
}
