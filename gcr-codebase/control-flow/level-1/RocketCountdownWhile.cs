using System;
class RocketCountdownUsingForLoop{
    static void Main(){
        // take final countdown value from user
        int c=int.Parse(Console.ReadLine());
        // print countdown in reverse order
        while (c>=1){
            Console.WriteLine(c);
            c--;
        }
    }
}
