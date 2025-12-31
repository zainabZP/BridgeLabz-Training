using System;
class OddEven{
    static void Main(){
        // take an input n from user
        int n=int.Parse(Console.ReadLine());
        // loop till n and check whether each of the number is div by 2 or not
        for (int i=1;i<n;i++){
            if (i%2==0)
                Console.WriteLine(i+" is even");
            else
                Console.WriteLine(i+" is odd");
        }
    }
}
