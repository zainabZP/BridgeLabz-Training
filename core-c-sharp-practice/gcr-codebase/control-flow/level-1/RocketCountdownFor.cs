using System;
class RocketCountdownUsingForLoop{
    static void Main(){
        // take final countdown value from user
        int c=int.Parse(Console.ReadLine());
        // print countdown in reverse order
        for (int i=c;i>=1;i--){
            Console.WriteLine(i);
        }
    }
}
