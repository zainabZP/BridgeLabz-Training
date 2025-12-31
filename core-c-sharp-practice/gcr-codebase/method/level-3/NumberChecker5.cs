using System;
class NumberCheckerExtended{
    public static int CountDigits(int n){
        int c=0;
        while(n>0){
            c++;
            n=n/10;
        }
        return c;
    }
    public static bool Prime(int n){
		for(int i=2;i<n;i++){
			if(n%i==0){
				return false;
			}
		}
		return true;
    }
    public static bool Neon(int n){
        int sq=n*n,sum=0;;
        while(sq>0){
            int temp=sq%10;
            sum+=temp;
            sq=sq/10;
        }
        if(sum==n) return true;
        else return false;
    }
    public static bool Automorphic(int n){
        int s=CountDigits(n);
        int sq=n*n;
        for(int i=0;i<s;i++){
            int tsq=sq%10;
            int tn=n%10;
            if(tn!=tsq) return false;
            sq=sq/10;
            n=n/10;
        }
        return true;
    }
    public static bool Buzz(int n){
        if(n%7==0||n%10==7) return true;
        else return false;
    }
    public static bool Spy(int n){
        int sum=0,pro=1;
         while(n>0){
            int temp=n%10;
            sum+=temp;
            pro*=temp;
            n=n/10;
        }
        if(sum==pro) return true;
        else return false;
    }
    static void Main(){
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int size=CountDigits(n);
        if(Prime(n)) Console.WriteLine("number is prime");
        else Console.WriteLine("number is not prime");
        if(Neon(n)) Console.WriteLine("number is a neon number");
        else Console.WriteLine("number is not a neon number");
        if(Automorphic(n)) Console.WriteLine("number is automorphic");
        else Console.WriteLine("number is not automorphic");
        if(Buzz(n)) Console.WriteLine("number is a buzz number");
        else Console.WriteLine("number is not a buzz number");
        if(Spy(n)) Console.WriteLine("number is a spy number");
        else Console.WriteLine("number is not a spy number");
    }
}