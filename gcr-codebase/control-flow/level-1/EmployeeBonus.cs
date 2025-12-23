using System;
class BonusOfEmployees{	
    static void Main(){
		// take salary and year as input from user
        double sal=double.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
		// if year > 5, bonus will be 5% of salary
		if (y>5) {
            double bonus=sal*0.05;
            Console.WriteLine("Bonus = "+bonus);
        }
		// else there is no bonus
        else{ 
            Console.WriteLine("No bonus");
        }
    }
}
