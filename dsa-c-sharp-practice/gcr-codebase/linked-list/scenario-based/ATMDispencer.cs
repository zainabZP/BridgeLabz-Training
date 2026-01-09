// atm dispencer
using System;
class HelloWorld {
  static void Main() {
    int[] moneyArr1={500,200,100,50,20,10,5,2,1};
    int[] moneyArr2={200,100,50,20,10,5,2,1};
    int sum1=0,sum2=0,target=880;
    int[] countArr1={0,0,0,0,0,0,0,0,0};
    int[] countArr2={0,0,0,0,0,0,0,0};
    for(int i=0;i<moneyArr1.Length;i++){
        while((sum1+moneyArr1[i])<=target){
            sum1+=moneyArr1[i];
            countArr1[i]=countArr1[i]+1;
        }
    }
    Console.WriteLine("Number of notes require in scenerio 1 (i.e including 500 rupees note)");
    for(int i=0;i<countArr1.Length;i++){
        if(countArr1[i]!=0){
            Console.WriteLine("count of "+moneyArr1[i]+" note = "+countArr1[i]);
        }
    }
    for(int i=0;i<moneyArr2.Length;i++){
        while((sum2+moneyArr2[i])<=target){
            sum2+=moneyArr2[i];
            countArr2[i]=countArr2[i]+1;
        }
    }
    Console.WriteLine("Number of notes require in scenerio 2 (i.e excluding 500 rupees note)");
    for(int i=0;i<countArr2.Length;i++){
        if(countArr2[i]!=0){
            Console.WriteLine("count of "+moneyArr2[i]+" note = "+countArr2[i]);
        }
    }
  }
}