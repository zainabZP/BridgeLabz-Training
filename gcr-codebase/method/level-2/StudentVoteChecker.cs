using System;
class VoteCheck{
    static void Main(){
        int[] age=new int[10];

        for(int i=0;i<10;i++){
            Console.Write("Enter age : ");
            age[i]=int.Parse(Console.ReadLine());

            if(Check(age[i]))
                Console.WriteLine("Can Vote");
            else
                Console.WriteLine("Cannot Vote");
        }
    }

    static bool Check(int a){
        if(a>=18) return true;
        else return false;
    }
}
