using System;
class NumberReverse{
    static void Main(){
        // take number from user
        Console.WriteLine("enter number :");
        int n=int.Parse(Console.ReadLine());
        int temp=n;
        int c=0;
        // Count number of digits
        while(temp>0){
            c++;
            temp=temp/10;
        }
        // Create array and store digits in the array
        int[] f=new int[c];
        int idx=0;
        while(n>0){
            f[idx]=n%10;
            idx++;
            n=n/10;
        }
        // Sort digits
        Array.Sort(f);
        // Count frequency of each digit in array f
        int count=1;
        for(int i=0;i<f.Length-1;i++){
            if(f[i]==f[i+1]) count++;
            else{
                Console.WriteLine("frequency of "+f[i]+" = "+count);
                count=1;
            }
        }
        Console.WriteLine("frequency of "+f[f.Length-1]+" = "+count);
    }
}