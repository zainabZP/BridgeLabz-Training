using System;

class CalculateProfit
{
    static void Main()
    {
		// Creating an int variable 'costPrice' and assign value 129
        double costPrice = 129;
		// Creating an int variable 'sellingPrice' and assign value 191
        double sellingPrice = 191;
		// calculating profit percentage
		double profitPercent=((sellingPrice-costPrice)/costPrice)*100;
		// printing profit percentage
        Console.WriteLine(profitPercent);
    }
}
