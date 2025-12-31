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
    public static int[] Store(int size, int n){
        int[] a=new int[size];
        int i=0;
        while(n>0){
            int temp=n%10;
            a[i]=temp;
            i++;
            n=n/10;
        }
        return a;
    }
    public static int Reverse(int n){
        int rev=0;
        while(n>0){
            int temp=n%10;
            rev=rev*10+temp;
            n=n/10;
        }
        return rev;
    }
    public static bool CheckEqualArray(int[] a, int[] b){
        if(a.Length!=b.Length) return false;
        for(int i=0;i<a.Length;i++){
            if(a[i]!=b[i]) return false;
        }
        return true;
    }
    public static bool Palindrome(int n){
        int rev=Reverse(n);
        if(rev==n) return true;
        else return false;
    }
    public static bool Duck(int n){
         while(n>0){
            int temp=n%10;
            if(temp==0){
                return true;
            }
            n=n/10;
        }
        return false;
    }
    static void Main(){
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int size=CountDigits(n);
        int[] arr=Store(size,n);
         Console.WriteLine("number of digits = "+size);
        Console.WriteLine("reversed number = "+Reverse(n));
        if(Palindrome(n)) Console.WriteLine("number is a palindrome");
        else Console.WriteLine("number is not a palindrome");
        if(Duck(n)) Console.WriteLine("number is a duck number");
        else Console.WriteLine("number is not a duck number");
        int[] arrCopy=Store(size,n);
        if(CheckEqualArray(arr, arrCopy)) Console.WriteLine("Array equals its copy");
        else Console.WriteLine("Array does not equal its copy");
    }
}