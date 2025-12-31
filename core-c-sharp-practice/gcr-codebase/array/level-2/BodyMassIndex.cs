using System;
class BodyMassIndex{
	static void Main(){
        Console.WriteLine("enter total number of person");
        int n=int.Parse(Console.ReadLine());
        double[] bmi=new double[n];
        double[] h=new double[n];
        double[] w=new double[n];
        for(int i=0;i<n;i++){
            Console.WriteLine("enter weight in kg");
            w[i]=double.Parse(Console.ReadLine()); // take weight input in kg
            Console.WriteLine("enter height in m");
            h[i]=double.Parse(Console.ReadLine()); // take height input in m
            double b=(w[i])/(h[i]*h[i]); //BMI = weight / (height * height);
            bmi[i]=b;

        }
        for(int i=0;i<n;i++){
            Console.Write("weight = "+w[i]+" height = "+h[i]+" bmi = "+bmi[i]);
            if(bmi[i]<=18.4) Console.WriteLine(" underweight");
            else if(bmi[i]>=18.5&&bmi[i]<=24.9) Console.WriteLine(" normal");
            else if(bmi[i]>=25.0&&bmi[i]<=39.9) Console.WriteLine(" overweight");
            else Console.WriteLine(" obese");
        }

	}
}