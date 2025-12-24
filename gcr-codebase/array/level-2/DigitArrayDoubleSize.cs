using System;
class DigitArrayDoubleSize{
    static void Main(){
        Console.WriteLine("enter number:");
        long n=long.Parse(Console.ReadLine());
        long c=0, s=1,idx=0, co=0;
        long temp=n;
        while(temp>0){
            c++;
            if(c>(10*s)) s++;
            temp=temp/10;
            co++;
        }
        long[] arr=new long[10*s];
        long max1=0, max2=0;
        while(n>0){
            long t=n%10;
            if(max1<t){
                max2=max1;
                max1=t;
            }
            else if(t<max1&&t>max2) max2=t;
            arr[idx]=t;
            idx++;
            n=n/10;
        }
        for(int i=0;i<co;i++){
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine(max1+" "+max2);
    }
}