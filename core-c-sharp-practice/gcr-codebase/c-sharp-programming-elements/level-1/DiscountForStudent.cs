using System;

class DiscountForStudent
{
    static void Main()
    {
		// Create a double variable 'fee' and 'discountPercent', and assign value 125000 and 10 respectively.
        double fee  = 125000 ;
        double discountPercent =10;
		// calculating discount
		double discountAmount=(10.0/100.0)*fee;
		//calculating payable fee
		double payableFee=fee-discountAmount;
		// printing discount and payable fee
		Console.WriteLine("Discount="+discountAmount);
		Console.WriteLine("payable fee="+payableFee);
    }
}
