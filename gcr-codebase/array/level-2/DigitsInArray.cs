using System;
class DigitsInArray{
    static void Main(){
        Console.WriteLine("enter number");
        int n=int.Parse(Console.ReadLine());
        int c=0;
        int temp=n;
        // count digits
        while(temp>0){
            temp=temp/10;
            c++;
        }
        // find max and second max digits
        int max1=0,max2=0;
        int[] arr=new int[c];int idx=0;
        while(n>0){
            int t=n%10;
            if(max1<t){
                max2=max1;
                max1=t;
            }
            else if(max2<t){
                max2=t;
            }
            arr[idx]=t;
            idx++;
            n=n/10;
        }
        for(int i=0;i<c;i++){
            Console.WriteLine(arr[i]);
        }
        // print max and msecond max digits
        Console.WriteLine(max1+" "+max2);
    }
}