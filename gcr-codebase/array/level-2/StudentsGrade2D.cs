using System;
class StudentsGrade2D{
	static void Main(){
        Console.WriteLine("enter total number of Student");
        int n=int.Parse(Console.ReadLine());
        double[,] data=new double[n,4];
        for(int i=0;i<n;i++){
            for(int j=0;j<3;j++){
                if(j==0) Console.WriteLine("enter physics marks");
                else if(j==1) Console.WriteLine("enter chemistry marks");
                else if(j==2) Console.WriteLine("enter maths marks");
                data[i,j]=double.Parse(Console.ReadLine());
            }
        }


        for(int i=0;i<n;i++){
            data[i,3]=((data[i,1]+data[i,2]+data[i,0])/300)*100;
            Console.Write("physics marks = "+data[i,0]+" chemistry marks = "+data[i,1]+" maths marks = "+data[i,2]+" percentage = "+data[i,3]);
            if(data[i,3]>80) Console.WriteLine(" grade = A");
            else if(data[i,3]>=70&&data[i,3]<=79) Console.WriteLine(" grade = B");
            else if(data[i,3]>=60&&data[i,3]<=69) Console.WriteLine(" grade = C");
            else if(data[i,3]>=50&&data[i,3]<=59) Console.WriteLine(" grade = D");
            else Console.WriteLine(" grade = E");
        }

	}
}