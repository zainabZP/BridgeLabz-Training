using System;

class BusRoute{
    static void Main(){
        int totalDistance = 0;
        bool exit = false;

        while (!exit){
            Console.WriteLine("Enter distance of next stop (in km): ");
            int distance = int.Parse(Console.ReadLine());
            totalDistance += distance;

            Console.WriteLine("Total Distance Travelled: " + totalDistance + " km");

            Console.WriteLine("Do you want to get off? (yes/no)");
            string choice = Console.ReadLine();

            if (choice.Equals("yes")){
                Console.WriteLine("Passenger got off.");
                Console.WriteLine("Final Distance: " + totalDistance + " km");
                exit = true;
            }
        }
    }
}
