using System;
class UniversityDiscount{
	static void Main(){
		// taking fee and discount percent as user input
		Console.Write("Enter Fee = ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Discount Percent = ");
        double discountPercentage = Convert.ToDouble(Console.ReadLine());
		// calculating discount amount
        double disc = fee*discountPercentage/100;
		// calculating payable fee
        double finalFees = fee - disc;
		// printing discount amount and payable fee
        Console.WriteLine("The discount amount =" + disc + " and the final discounted fees =" + finalFees  );
	}
}
