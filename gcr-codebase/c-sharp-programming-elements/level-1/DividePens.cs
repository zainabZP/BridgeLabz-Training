using System;

class DividePens
{
    static void Main()
    {
        int totalPens = 14;
        int pensForEach = totalPens/3;
		int remainingPens=totalPens%3;
        Console.WriteLine("Pens each student gets="+pensForEach);
		Console.WriteLine("Pens left undivided="+remainingPens);
    }
}
