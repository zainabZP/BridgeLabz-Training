using System;

class Cafeteria
{   
    static string[] snackList ={
            "Cheese Toast",
            "Veg Burger",
            "Spring Roll",
            "Potato Wedges",
            "Idli Sambar",
            "Fried Rice",
            "Noodles",
            "Ice Cream",
            "Cold Drink",
            "Green Tea"
        };
        static int[] priceList={
            40,50,80,70,100,60,110,150,30,20
        };
    static void Main()
    {
        Console.WriteLine("WELCOM TO CAFETERIA ");
        bool flag=false;
        while(!flag){
            Console.WriteLine("ENTER CHOICE : ");
            Console.WriteLine("1. SEE MENU");
            Console.WriteLine("2. PLACE ORDER");
            Console.WriteLine("3. EXIT");
            int ch=int.Parse(Console.ReadLine());
            switch(ch){
                case 1: PrintMenu(snackList,priceList);break;
                case 2: Console.WriteLine("Enter item numbers (space separated):");
                        string input = Console.ReadLine();
                        string[] order = input.Split(' ');
                        PlaceOrder(order);break;
                case 3: flag=true;break;
                default: Console.WriteLine("Enter Valid Choice");break;
            }
        }
    }
    public static void PrintMenu(string[] snackList, int[] priceList)
    {
        for (int i = 0; i < snackList.Length; i++)
        {
            Console.WriteLine((i + 1) + " --> " + snackList[i]+" --> "+priceList[i]);
        }
    }
    public static void PlaceOrder(string[] order)
    {
        int sum=0;
        for(int i=0;i<order.Length;i++){
            int idx=int.Parse(order[i])-1;
            sum+=priceList[idx];
        }
        Console.WriteLine("PAY AMOUNT "+sum+" TO PLACE ORDER");
        int amount=int.Parse(Console.ReadLine());
        if(amount==sum){
            Console.Write("Your Oder : ");
            for(int i=0;i<order.Length;i++){
                int idx=int.Parse(order[i])-1;
                Console.Write(snackList[idx]+" ");
            }
            Console.Write("is Placed");
            Console.WriteLine();
        }
        else Console.WriteLine("ORDER DECLINED");
    }
}
