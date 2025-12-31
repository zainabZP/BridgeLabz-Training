using System;
class FizzBuzz{
	static void Main(){
        Console.WriteLine("enter a number");
		int n=int.Parse(Console.ReadLine());
		if(n>0){
            string[] result=new string[n];
			for(int i=1;i<=n;i++){
				if(i>5&&i%3==0&&i%5==0) result[i-1]="FizzBuzz";
				else if(i>=3&&i%3==0) result[i-1]="Fizz";
				else if(i>=5&&i%5==0) result[i-1]="Buzz";
				else result[i-1]=i.ToString();
			}
            for(int i=0;i<result.Length;i++) Console.WriteLine("position "+(i+1)+" = "+result[i]);
		}
		else Console.WriteLine("enter a positive integer");
	}
}