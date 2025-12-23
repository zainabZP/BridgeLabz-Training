using System;
class LeapYear{
	static void Main(){
		int y=int.Parse(Console.ReadLine());
		if((y%4==0&&y%100!=0)||(y%400==0))
			Console.WriteLine("its a leap year");
		else
			Console.WriteLine("its not a leap year");
	}
}