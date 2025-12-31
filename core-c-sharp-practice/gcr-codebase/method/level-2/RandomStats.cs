using System;
class RandomStats{
    static void Main(){
        int[] arr=RandomArray(5);
        double[] res=AverageMinMax(arr);

        Console.WriteLine("Average = "+res[0]);
        Console.WriteLine("Min = "+res[1]);
        Console.WriteLine("Max = "+res[2]);
    }

    static int[] RandomArray(int n){
        int[] a=new int[n];
        Random r=new Random();
        for(int i=0;i<n;i++){
            a[i]=r.Next(1000,10000);
        }
        return a;
    }

    static double[] AverageMinMax(int[] a){
        int sum=0;
        int min=a[0];
        int max=a[0];

        for(int i=0;i<a.Length;i++){
            sum=sum+a[i];
            if(a[i]<min) min=a[i];
            if(a[i]>max) max=a[i];
        }

        double avg=(double)sum/a.Length;
        double[] res={avg,min,max};
        return res;
    }
}
