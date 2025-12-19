using System;

class CalculateProfit
{
    static void Main()
    {
        double costPrice = 129;
        double sellingPrice = 191;
		double profitPercent=((sellingPrice-costPrice)/costPrice)*100;
        Console.WriteLine(profitPercent);
    }
}
