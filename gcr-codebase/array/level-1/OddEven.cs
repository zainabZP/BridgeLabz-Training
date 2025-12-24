using System;
class OddEven{
    static void Main(){
        Console.WriteLine("enter range : ");
        int n=int.Parse(Console.ReadLine());
        int oddLen=0;
        if(n%2==0) oddLen=n/2;
        else oddLen=(n/2)+1;
        int[] odd=new int[oddLen];
        int[] even=new int[(n/2)];
        int idxOdd=0, idxEven=0;
        for(int i=1;i<=n;i++){
            if(i%2==0){
                even[idxEven]=i;
                idxEven++;
            }
            else{
                odd[idxOdd]=i;
                idxOdd++;
            }
        }
        if(idxEven>0) Console.WriteLine("Even numbers are : ");
        for(int i=0;i<even.Length;i++){
            Console.WriteLine(even[i]);
        }
        if(idxOdd>0) Console.WriteLine("Odd numbers are : ");
        for(int i=0;i<odd.Length;i++){
            Console.WriteLine(odd[i]);
        }
    }
}
