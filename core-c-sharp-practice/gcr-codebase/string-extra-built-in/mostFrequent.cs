using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        Array.Sort(arr);
        int max=0,c=1;char ch=s[0];
        for(int i=1;i<s.Length;i++){
            if(arr[i]==arr[i-1]) c++;
            else{
                 if(max<c){
                    max=c;
                    ch=s[i-1];
                 }
                 c=1;
            }
        }
        if (c > max){
            max = c;
            ch = arr[arr.Length - 1];
        }
        Console.WriteLine("Most Frequent Character: " +ch);
    }
}
