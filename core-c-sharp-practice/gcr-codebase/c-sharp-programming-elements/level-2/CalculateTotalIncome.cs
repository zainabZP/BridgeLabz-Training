using System;
class CalculateTotalIncome {
    static void Main(){
        // take salary and bonus as user inputs
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        // calculate final income
        double Income = salary+bonus;
        // printing calculated income
        Console.WriteLine("Total Income = "+ Income);
    }
}
