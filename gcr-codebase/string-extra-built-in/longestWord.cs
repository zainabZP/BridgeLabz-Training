using System;
class LongestWord{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string s = Console.ReadLine();
        int max=0,temp=0;string sub="",l="";
        for(int i=0;i<s.Length;i++){
            if(s[i]!=' '){
                temp++;
                sub+=s[i];
            }
            else{
                if(max<temp){
                    max=temp;
                    l=sub;
                }
                temp=0;
                sub="";
            }
        }
        if (temp>max){
            l=sub;
        }
        Console.WriteLine("Longest Word: " +l);
    }
}
