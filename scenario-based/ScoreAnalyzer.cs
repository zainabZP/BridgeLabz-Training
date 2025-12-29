using System;
class StudentScores{
    public static void Main(){
        StudentScores obj=new StudentScores();
        Console.WriteLine("enter number of students");
        int totalStudents=int.Parse(Console.ReadLine());
         Console.WriteLine("enter number of subjects");
        int totalSubjects=int.Parse(Console.ReadLine());
        double[,] scores=new double[totalStudents,totalSubjects];
        for(int i=0;i<totalStudents;i++){
            Console.WriteLine("ENTER STUDENT "+(i+1)+" MARKS OF "+totalSubjects+" SUBJECTS");
            for(int j=0;j<totalSubjects;j++){
                try{
                    double x=double.Parse(Console.ReadLine());
                    if(x>=0)
                    scores[i,j]=x;
                    else throw new Exception("NO NEGATIVE MARKING");
                }
                catch(Exception e){
                    Console.WriteLine("ENTER VALID SCORE");
                    j=j-1;
                }
            }
        }
        obj.HighestAndLowestScore(scores);
        obj.CalculateAverage(scores);
    }
    public void CalculateAverage(double[,] scores){
        for(int i=0;i<scores.GetLength(0);i++){
            double sum=0.0;
            for(int j=0;j<scores.GetLength(1);j++){
                sum+=scores[i,j];
            }
            Console.WriteLine("Average score of student "+(i+1)+" = "+(sum/scores.GetLength(1)));
            Console.Write("scores above average : ");
            int flag=0;
            for(int j=0;j<scores.GetLength(1);j++){
                if(scores[i,j]>(sum/scores.GetLength(1))){
                    flag=1;
                    Console.Write(scores[i,j]+" ");
                }
            }
            if(flag==0) Console.WriteLine("No Scores"); 
            Console.WriteLine();
        }
    }
    public void HighestAndLowestScore(double[,] scores){
        for(int i=0;i<scores.GetLength(0);i++){
            double highestScore=scores[i,0],lowestScore=scores[i,0];
            for(int j=1;j<scores.GetLength(1);j++){
                if(highestScore<scores[i,j]){
                    highestScore=scores[i,j];
                }
                if(lowestScore>scores[i,j]){
                    lowestScore=scores[i,j];
                }
            }
             Console.WriteLine("highest score of student "+(i+1)+" = "+highestScore+" and lowest score of student "+(i+1)+" = "+lowestScore);
        }
    }

}
