using System;
class SnakeLadderGame{
    private int[] ladderArray={10,18,30,69,78};
    private int[] ladderArrayNewPosition={56,25,21,18,17};
    private int[] SnakeArray={99,96,94,77,37};
    private int[] SnakeArrayNewPosition={93,12,23,49,30};
    private const int BoardSize=100;
    public static void Main(){
        SnakeLadderGame obj=new SnakeLadderGame();
        Console.WriteLine("enter number of players");
        int numberOfPlayer=int.Parse(Console.ReadLine());
        int[] player=new int [numberOfPlayer];int flag=0;
        while(flag==0){
            for(int i=0;i<numberOfPlayer;i++){
                int x=obj.GenerateRandom();
                Console.WriteLine();
                Console.WriteLine("player "+(i+1)+" turn");
                Console.ReadLine();
                Console.WriteLine("dice value = "+x);
                if((player[i]+x)<=SnakeLadderGame.BoardSize) player[i]+=x;
                if(player[i]==100){
                    Console.WriteLine("player "+(i+1)+" wins");
                    flag=1;
                    break;
                }
                //ladder
                else if(player[i]==10||player[i]==18||player[i]==30||player[i]==69||player[i]==78){
                    Console.WriteLine();
                    Console.WriteLine("ladder reached");
                    Console.WriteLine();
                    int ladderIncrement=obj.ladder(player[i],obj.ladderArray,obj.ladderArrayNewPosition);
                    player[i]=player[i]+ladderIncrement;
                }
                //snake
                else if(player[i]==99||player[i]==96||player[i]==94||player[i]==77||player[i]==37){
                    Console.WriteLine();
                    Console.WriteLine("snake bit");
                    int snakeDecrement=obj.Snake(player[i],obj.SnakeArray,obj.SnakeArrayNewPosition);
                    player[i]=player[i]-snakeDecrement;
                }
                Console.WriteLine();
                Console.WriteLine("player "+(i+1)+" score is "+player[i]);
            }
            if(flag==1) break;
        }
        
    }
    public int GenerateRandom(){
        Random r=new Random();
        int x=r.Next(1,7);
        return x;
    }
    public int ladder(int position, int[] ladderArray, int[] ladderArrayNewPosition){
        if(position==ladderArray[0]) return ladderArrayNewPosition[0];
        else if(position==ladderArray[1]) return ladderArrayNewPosition[1];
        else if(position==ladderArray[2]) return ladderArrayNewPosition[2];
        else if(position==ladderArray[3]) return ladderArrayNewPosition[3];
        else return ladderArrayNewPosition[4];
    }
    public int Snake(int position,int[] SnakeArray, int[] SnakeArrayNewPosition){
        if(position==SnakeArray[0]) return SnakeArrayNewPosition[0];
        else if(position==SnakeArray[1]) return SnakeArrayNewPosition[1];
        else if(position==SnakeArray[2]) return SnakeArrayNewPosition[2];
        else if(position==SnakeArray[3]) return SnakeArrayNewPosition[3];
        else return SnakeArrayNewPosition[4];
    }
}