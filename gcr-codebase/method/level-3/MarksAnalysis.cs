using System;
class MarksAnalysis{
    public static int[,] Score(int n){
        int[,] arr=new int[n,3];
        Random r=new Random();
        for(int i=0;i<n;i++){
            arr[i,0]=r.Next(10,100);
            arr[i,1]=r.Next(10,100);
            arr[i,2]=r.Next(10,100);
        }
        return arr;
    }
    public static double[,] Calculate(int[,] arr){
        int n=arr.GetLength(0);
        double[,] a=new double[n,3];
        for(int i=0;i<n;i++){
            a[i,0]=arr[i,0]+arr[i,1]+arr[i,2];
            double t=arr[i,0]+arr[i,1]+arr[i,2];
            a[i,1]=(int)(t/3.0);
            a[i,2]=(int)((t/300.0)*100.0);
        }
        return a;
    }
    public static void Display(int[,] s,double[,] r){
        Console.WriteLine("Physics    Chemistry    Maths    Total    Average    Percentage");
        int n=s.GetLength(0);
        for(int i=0;i<n;i++){
            Console.WriteLine(s[i,0]+"\t    "+s[i,1]+"\t        "+s[i,2]+"\t   "+r[i,0]+"\t    "+r[i,1]+"\t    "+r[i,2]);
        }
    }
    static void Main(){
        Console.WriteLine("Enter number of students : ");
        int n=int.Parse(Console.ReadLine()!);
        int[,] scores=Score(n);
        double[,] res=Calculate(scores);
        Display(scores,res);
    }
}
