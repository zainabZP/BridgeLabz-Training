using System;
class BodyMassIndex2DArray{
	static void Main(){
        Console.WriteLine("enter total number of person");
        int n=int.Parse(Console.ReadLine());
        double[,] data=new double[n,3];
        for(int i=0;i<n;i++){
            for(int j=0;j<2;j++){
                if(j==0) Console.WriteLine("enter weight");
                else if(j==1) Console.WriteLine("enter height");
                data[i,j]=double.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<n;i++){
            data[i,2]=(data[i,0])/(data[i,1]*data[i,1]);
            Console.Write("weight = "+data[i,0]+" height = "+data[i,1]+" bmi = "+data[i,2]);
            if(data[i,2]<=18.4) Console.WriteLine(" underweight");
            else if(data[i,2]>=18.5&&data[i,2]<=24.9) Console.WriteLine(" normal");
            else if(data[i,2]>=25.0&&data[i,2]<=39.9) Console.WriteLine(" overweight");
            else Console.WriteLine(" obese");
        }

	}
}