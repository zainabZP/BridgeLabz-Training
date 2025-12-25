using System;
class FactorsCalc{
    static void Main(){
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] arr = GetFactors(num);

        Console.WriteLine("Factors:");
        foreach (int val in arr)
            Console.Write(val + " ");

        Console.WriteLine("\nSum = " + Total(arr));
        Console.WriteLine("Sum of Squares = " + SquareTotal(arr));
        Console.WriteLine("Product = " + Multiply(arr));
    }

    static int[] GetFactors(int num){
        int cnt = 0;
        for(int i=1;i<=num;i++)
            if(num%i==0) cnt++;

        int[] res = new int[cnt];
        int k = 0;
        for(int i=1;i<=num;i++)
            if(num%i==0)
                res[k++] = i;

        return res;
    }

    static int Total(int[] arr){
        int s = 0;
        foreach(int v in arr)
            s += v;
        return s;
    }

    static double SquareTotal(int[] arr){
        double s = 0;
        foreach(int v in arr)
            s += Math.Pow(v,2);
        return s;
    }

    static int Multiply(int[] arr){
        int p = 1;
        foreach(int v in arr)
            p *= v;
        return p;
    }
}
