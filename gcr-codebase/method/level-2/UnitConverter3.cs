using System;

class LengthConvert {
    static void Main() {
        Console.WriteLine("1 Yard to Feet");
        Console.WriteLine("2 Feet to Yard");
        Console.WriteLine("3 Meter to Inch");
        Console.WriteLine("4 Inch to Meter");
        Console.WriteLine("5 Inch to Cm");

        int option = Convert.ToInt32(Console.ReadLine());
        double value = Convert.ToDouble(Console.ReadLine());
        double answer;

        if (option == 1) {
            answer = YardFeet(value);
            Console.WriteLine(answer);
        }
        else if (option == 2) {
            answer = FeetYard(value);
            Console.WriteLine(answer);
        }
        else if (option == 3) {
            answer = MeterInch(value);
            Console.WriteLine(answer);
        }
        else if (option == 4) {
            answer = InchMeter(value);
            Console.WriteLine(answer);
        }
        else if (option == 5) {
            answer = InchCm(value);
            Console.WriteLine(answer);
        }
        else {
            Console.WriteLine("Wrong Choice");
        }
    }

    static double YardFeet(double y) {
        return y * 3;
    }

    static double FeetYard(double f) {
        return f * 0.333333;
    }

    static double MeterInch(double m) {
        return m * 39.3701;
    }

    static double InchMeter(double i) {
        return i * 0.0254;
    }

    static double InchCm(double i) {
        return i * 2.54;
    }
}
