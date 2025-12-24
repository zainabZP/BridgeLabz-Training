using System;
class VotingEligibilityCriteria{
    static void Main(){
        int[] age=new int[10];
        // taking age as an input
        Console.WriteLine("enter age of 10 persons");
        for(int i=0;i<10;i++)
        age[i]=int.Parse(Console.ReadLine());
        // check if age is equal or greater than 18, if yes than eligible else not
        for(int i=0;i<10;i++){
            if (age[i]>=18)
                Console.WriteLine("person "+(i+1)+" with age = "+age[i]+", is eligible");
            else
                Console.WriteLine("person "+(i+1)+" with age = "+age[i]+", is not eligible");
        }
    }
}
