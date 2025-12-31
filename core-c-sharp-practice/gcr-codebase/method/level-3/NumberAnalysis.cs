using System;
class NumberChecker{
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
    public static bool Armstrong(int n){
        int ogNumber=n;
        int sum=0;
        while (n!=0){
            int t=n%10;
            sum=sum+(t*t*t);
            n=n/10;
        }
        if (sum==ogNumber) return true;
        else return false;
    }
    public static void Max(int[] a){
        int max1=0,max2=0;
        for(int i=0;i<a.Length;i++){
            if(a[i]>max1){
                max2=max1;
                max1=a[i];
            }
            else if(a[i]>max2){
                max2=a[i];
            }
        }
        Console.WriteLine("max digit = "+max1);
        Console.WriteLine("second max digit = "+max2);
    }
    public static void Min(int[] a){
        int min1=10,min2=10;
        for(int i=0;i<a.Length;i++){
            if(a[i]<min1){
                min2=min1;
                min1=a[i];
            }
            else if(a[i]<min2){
                min2=a[i];
            }
        }
        Console.WriteLine("min digit = "+min1);
        Console.WriteLine("second min digit = "+min2);
    }
    static void Main(){
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int size=CountDigits(n);
        int[] arr=Store(size,n);
        Max(arr);
        Min(arr);
        if(Duck(n)) Console.WriteLine("It is a duck number");
        else Console.WriteLine("It is not a duck number");
        if(Armstrong(n)) Console.WriteLine("It is an Armstrong number");
        else Console.WriteLine("It is not an Armstrong number");
    }
}