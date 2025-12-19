using System;

class Operators{

	static void Main(){
		
		int a=10, b=15;
		
		// performing airthmetic operations -
		
		int add=a+b;
		int sub=a-b;
		int mul=a*b;
		double div=a/b;
		int mod=a%b;
		Console.WriteLine("sum of two numbers="+ add);
		Console.WriteLine("subtraction of two numbers="+ sub);
		Console.WriteLine("multiplication of two numbers="+ mul);
		Console.WriteLine("division of two numbers="+ div);
		Console.WriteLine("mod of two numbers="+ mod);
		
		
		//performing relational operations -
		
		if(a==b) Console.WriteLine("first number is equal to second number");
		if(a!=b) Console.WriteLine("first number is not equal to second number");
		if(a>b) Console.WriteLine("first number is greater than second number");
		if(a<b) Console.WriteLine("first number is smaller than second number");
		if(a>=b) Console.WriteLine("first number is either greater or equal to second number");
		if(a<=b) Console.WriteLine("first number is either smaller or equal to second number");
		
		
		// performing logical operations -
		bool x=true, y=false;
		Console.WriteLine(x&&y); // result of logical AND performed on two numbers (10 and 15);
		Console.WriteLine(x||y); // result of logical OR performed on two numbers (10 and 15);
		Console.WriteLine(!x); // result of logical NOT performed on two numbers (10 and 15);
		
		
		// performing assignment operator -
		
		a=25; b=30; // assigning new values to a and b using assign operator
		a+=10; //performing add and assign on a
		Console.WriteLine(a);
		a-=5; //performing subtract and assign on a
		Console.WriteLine(a);
		a*=10; //performing multiply and assign on a
		Console.WriteLine(a);
		a/=10; //performing divide and assign on a
		Console.WriteLine(a);
		a%=10; //performing mod and assign on a
		Console.WriteLine(a);
		
		
		// performing unary operators -
		a=12;
		Console.WriteLine(a++); //incrementing a by 1
		Console.WriteLine(a--); //decrementing a by 1
		b=-a;
		Console.WriteLine(b); //unary minus change sign;
		bool IsTrue=true;
		Console.WriteLine(!IsTrue); // logical not inverse the value
		
		
		// performing typeof operator -
		Console.WriteLine(typeof(int));
		
		// performing ternary operator -
		int z=(a<b)?a:b;
		Console.WriteLine(z);
		
		// prforming typecasting - 
		char t=(char)78;
		Console.WriteLine(t);
		
	}
}

		
		