using System;
class Find{
    public static void Main(){
        int n=int.Parse(Console.ReadLine());
        string t=Console.ReadLine();
        string[] arr=new string[n];
        string[] word=new string[n];
        for(int i=0;i<n;i++){
            string sentence=Console.ReadLine();
            arr[i]=sentence;
            int j=0;string str="";
            while(sentence[j]!=' '){
                str+=sentence[j];
                j++;
            }
            word[i]=str;
        }
        for(int i=0;i<arr.Length;i++){
            if(word[i]==t){
                Console.WriteLine(arr[i]);break;
            }
        }
    }
}