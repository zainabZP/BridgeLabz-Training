using System;
class CheckIfFirstIsSmallest{
    static void Main(){
		// taking 3 numbers as input from user
        string[] input = Console.ReadLine().Split();
        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        int n3 = int.Parse(input[2]);
		// check if n1<n2 & n1<n3, and store the result (true or false) in a variable r
        bool r = n1 < n2 && n1 < n3;
		if(r)
			Console.WriteLine("first number is smallest");
		else{
			Console.WriteLine("first number is not smallest");
		}
    }
}
