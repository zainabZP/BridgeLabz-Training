using System;
class FindOccurence{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string s=Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string sub=Console.ReadLine();
        int count=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]==sub[0]&&(s.Length-i)>=sub.Length){
                int idx=i,f=1;
                for(int j=0;j<sub.Length;j++){
                    if(s[idx]!=sub[j]){
                        f=0;break;
                    }
                    idx++;
                }
                if(f==1) count++;
            }
        }
        Console.WriteLine("Occurrences : "+count);
    }
}
