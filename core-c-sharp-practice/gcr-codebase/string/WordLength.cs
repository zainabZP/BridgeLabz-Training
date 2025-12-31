using System;
class WordLength{
    static void Main(){
        Console.WriteLine("Enter a strings : ");
        string s1=Console.ReadLine();
        int[,] result = WordArray(s1);
        Console.WriteLine("Word Index   Length");
        for (int i = 0; i < result.GetLength(0); i++){
            Console.WriteLine(result[i, 0]+"            "+result[i, 1]);
        }  
    }
    static List<string> Split(string s1){
        List<string> li=new List<string>();
        string sub="";
        for (int i=0;i<s1.Length;i++){
            if(s1[i]!=' '){
                sub+=s1[i];
            }
            else{
                li.Add(sub);
                sub=null;
            }
        }
        li.Add(sub);
        return li;
    }
    static int CountLength(string s){
        int i=0,c=0;
        while (true){
            try{
                char ch=s[i];
                c++;
                i++;
            }
            catch (IndexOutOfRangeException){
                break;
            }
        }
        return c;
    }
    static int[,] WordArray(string s){
        List<string> li=Split(s);
        int[,] r=new int [li.Count,2];
        for(int i=0;i<li.Count;i++){
            r[i,0]=i;
            r[i,1]=CountLength(li[i]);
        }
        return r;
    }
}