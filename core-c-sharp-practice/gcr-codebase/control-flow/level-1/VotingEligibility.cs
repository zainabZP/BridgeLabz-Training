using System;
class VotingEligibilityCriteria{
    static void Main(){
        // taking age as an input
        Console.WriteLine("enter age");
        int age=int.Parse(Console.ReadLine());
        // check if age is equal or greater than 18, if yes than eligible else not
        if (age>=18){
            Console.WriteLine("eligible");
        }
        else{
            Console.WriteLine("not eligible");
        }
    }
}
