using System;

class DiscountForStudent
{
    static void Main()
    {
        double fee  = 125000 ;
        double discountPercent =10;
		double discountAmount=(10.0/100.0)*fee;
		double payableFee=fee-discountAmount;
		Console.WriteLine("Discount="+discountAmount);
		Console.WriteLine("payable fee="+payableFee);
    }
}
