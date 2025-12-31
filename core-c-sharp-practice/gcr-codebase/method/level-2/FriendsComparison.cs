using System;
class Friends{
    static void Main(){
        string[] n = {"Amar","Akbar","Anthony"};
        int[] a = new int[3];
        double[] h = new double[3];

        for(int i=0;i<3;i++){
            Console.Write("Enter age of "+n[i]+": ");
            a[i]=int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            h[i]=double.Parse(Console.ReadLine());
        }

        int y = Young(a);
        int t = Tall(h);

        Console.WriteLine("Youngest: "+n[y]);
        Console.WriteLine("Tallest: "+n[t]);
    }

    static int Young(int[] a){
        int m=0;
        for(int i=1;i<a.Length;i++){
            if(a[i]<a[m]) m=i;
        }
        return m;
    }

    static int Tall(double[] h){
        int m=0;
        for(int i=1;i<h.Length;i++){
            if(h[i]>h[m]) m=i;
        }
        return m;
    }
}
