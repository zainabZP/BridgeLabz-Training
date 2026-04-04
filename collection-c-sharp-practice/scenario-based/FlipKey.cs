using System;
class FlipKey{
    public string CleanseAndInvert(string s){
        if(s.Length<6) return "";
        s=s.ToLower();
        for(int i=0;i<s.Length;i++){
            if(s[i]<97||s[i]>122) return "";
        }
        string r="";
        for(int i=0;i<s.Length;i++){
            int v=(int)s[i];
            if(v%2!=0) r+=s[i];
        }
        char[] arr=r.ToCharArray();
        int x=0,y=arr.Length-1;
        while(x<y){
            char t=arr[x];
            arr[x]=arr[y];
            arr[y]=t;
            x++;y--;
        }
        for(int i=0;i<arr.Length;i++){
            if(i%2==0) arr[i]=(char)((int)arr[i]-32);
        }
        string f="";
        for(int i=0;i<arr.Length;i++){
            f+=arr[i];
        }
        return f;
    }
    public static void Main(){
        FlipKey obj=new FlipKey();
        string str=Console.ReadLine();
        string r=obj.CleanseAndInvert(str);
        if(r=="") Console.WriteLine("Invalid Input");
        else Console.WriteLine("The generated Key is - "+r);
    }
}