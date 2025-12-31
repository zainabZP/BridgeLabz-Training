using System;
class BMI{
    static void Main(){
        double[,] d=new double[10, 3];
        for (int i=0;i<10;i++) {
            Console.Write("Enter weight (kg): ");
            d[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height (cm): ");
            d[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
        string[] st=calc(d);
        for (int i=0;i<10;i++) {
            Console.WriteLine("BMI: " + d[i, 2] + " st: " + st[i]);
        }
    }
    static string[] calc(double[,] d) {
        string[] st = new string[10];
        for (int i = 0; i < 10; i++) {
            double heightM = d[i, 1] / 100;
            d[i, 2] = d[i, 0] / (heightM * heightM);
            if (d[i, 2] < 18.5) st[i] = "Underweight";
            else if (d[i, 2] < 25) st[i] = "Normal";
            else if (d[i, 2] < 30) st[i] = "Overweight";
            else st[i] = "Obese";
        }
        return st;
    }
}
