using System;

class DividePens
{
    static void Main()
    {
		// Create a int variable 'totalPens' and assign value 14.
        int totalPens = 14;
		// divide pens among 3 children
        int pensForEach = totalPens/3;
		// calculating remaining pens
		int remainingPens=totalPens%3;
		// printing pens per child
        Console.WriteLine("Pens each student gets="+pensForEach);
		// printing pens left undivided
		Console.WriteLine("Pens left undivided="+remainingPens);
    }
}
