using System;
class Employee{
    public static int[,] SalaryYearArray(){
        int[,] arr=new int[10,2];
        Random r=new Random();
        for(int i=0;i<10;i++){
            int sal=r.Next(10000,100000);
            int y=r.Next(1,11);
            arr[i,0]=sal;
            arr[i,1]=y;
        }
        return arr;
    }
    public static double[,] BonusNewSalaryArray(int[,] arr){
        double[,] a=new double[10,2];
        for(int i=0;i<10;i++){
            int sal=arr[i,0];
            int y=arr[i,1];
            if(y<5){
                a[i,0]=0.02*sal;
                a[i,1]=sal+a[i,0];
            }
            else{
                a[i,0]=0.05*sal;
                a[i,1]=sal+a[i,0];
            }
        }
        return a;
    }
    public static void Display(int[,] a){
        double[,] b=BonusNewSalaryArray(a);
        Console.WriteLine("Old Salary\tBonus\tNew Salary");
        for(int i=0;i<10;i++){
            Console.WriteLine(a[i,0]+"\t"+(int)b[i,0]+"\t"+(int)b[i,1]);
        }
    }
    static void Main(){
        int[,] emp=SalaryYearArray();
        Display(emp);
    }
}
