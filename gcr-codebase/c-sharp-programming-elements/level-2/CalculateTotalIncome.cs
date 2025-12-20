using System;
class CalculateTotalIncome {
    static void Main(){
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        double Income = salary+bonus;
        Console.WriteLine("Total Income = "+ Income);
    }
}