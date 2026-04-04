using System;

class VehicleInfo
{
    // instance variables
    public string owner;
    public string type;

    // static variable shared by all vehicles
    public static double regFee = 1000;

    // instance method to show vehicle details
    public void showVehicle()
    {
        Console.WriteLine("Owner Name       : " + owner);
        Console.WriteLine("Vehicle Type     : " + type);
        Console.WriteLine("Registration Fee : " + regFee);
        Console.WriteLine();
    }

    // static method to update registration fee
    public static void changeRegistrationFee(double fee)
    {
        regFee = fee;
    }

    static void Main(string[] args)
    {
        // creating vehicle object
        VehicleInfo vehicle1 = new VehicleInfo();
        vehicle1.owner = "Zainab";
        vehicle1.type = "Car";

        // display vehicle details
        vehicle1.showVehicle();

        // updating registration fee
        VehicleInfo.changeRegistrationFee(1500);

        // display updated details
        vehicle1.showVehicle();
    }
}
