using System;
class UniversityDiscount{
	static void Main(){
		Console.Write("Enter Fee = ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Discount Percent = ");
        double discountPercentage = Convert.ToDouble(Console.ReadLine());
        double disc = fee*discountPercentage/100;
        double finalFees = fee - disc;
        Console.WriteLine("The discount amount =" + disc + " and the final discounted fees =" + finalFees  );
	}
}