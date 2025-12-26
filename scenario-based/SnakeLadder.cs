using System;
class Game{
    public static void Main(){
        Console.WriteLine("enter number of players");
        int n=int.Parse(Console.ReadLine());
        int[] p=new int [n];int f=0;
        while(f==0){
            for(int i=0;i<n;i++){
                int x=GenerateRandom();
                Console.WriteLine();
                Console.WriteLine("player "+(i+1)+" turn");
                Console.ReadLine();
                Console.WriteLine("dice value = "+x);
                if((p[i]+x)<=100) p[i]+=x;
                if(p[i]==100){
                    Console.WriteLine("player "+(i+1)+" wins");
                    f=1;
                    break;
                }
                //ladder
                else if(p[i]==10||p[i]==18||p[i]==30||p[i]==69||p[i]==78){
                    Console.WriteLine();
                    Console.WriteLine("ladder reached");
                    Console.WriteLine();
                    int lad=ladder(p[i]);
                    p[i]=p[i]+lad;
                }
                //snake
                else if(p[i]==99||p[i]==96||p[i]==94||p[i]==77||p[i]==37){
                    Console.WriteLine();
                    Console.WriteLine("snake bit");
                    int snak=Snake(p[i]);
                    p[i]=p[i]-snak;
                }
                Console.WriteLine();
                Console.WriteLine("player "+(i+1)+" score is "+p[i]);
            }
            if(f==1) break;
        }
        
    }
    public static int GenerateRandom(){
        Random r=new Random();
        int x=r.Next(1,7);
        return x;
    }
    public static int ladder(int lad){
        if(lad==10) return 56;
        else if(lad==18) return (43-18);
        else if(lad==30) return (51-30);
        else if(lad==69) return (87-69);
        else return (95-78);
    }
    public static int Snake(int s){
        if(s==99) return (99-6);
        else if(s==96) return (96-84);
        else if(s==94) return (94-71);
        else if(s==77) return (77-28);
        else return (37-7);
    }
}