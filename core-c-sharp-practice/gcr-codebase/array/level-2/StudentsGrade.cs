using System;
class StudentsGrade{
	static void Main(){
        Console.WriteLine("enter total number of person");
        int n=int.Parse(Console.ReadLine());
        double[] percentage=new double[n];
        double[] physics=new double[n];
        double[] chemistry=new double[n];
        double[] math=new double[n];
        for(int i=0;i<n;i++){
            Console.WriteLine("enter physics marks");
            physics[i]=double.Parse(Console.ReadLine()); // take physics marks
            Console.WriteLine("enter chemistry marks");
            chemistry[i]=double.Parse(Console.ReadLine()); // take chemistry marks
            Console.WriteLine("enter math marks");
            math[i]=double.Parse(Console.ReadLine()); // take physics marks
            percentage[i]=((physics[i]+chemistry[i]+math[i])/300)*100;  //calculate percentage

        }
        for(int i=0;i<n;i++){
            Console.Write("physics marks = "+physics[i]+" chemistry marks = "+chemistry[i]+" maths marks = "+math[i]+" percentage = "+percentage[i]);
            if(percentage[i]>80) Console.WriteLine(" A");
            else if(percentage[i]>=70&&percentage[i]<=79) Console.WriteLine(" B");
            else if(percentage[i]>=60&&percentage[i]<=69) Console.WriteLine(" C");
            else if(percentage[i]>=50&&percentage[i]<=59) Console.WriteLine(" D");
            else Console.WriteLine(" E");
        }

	}
}