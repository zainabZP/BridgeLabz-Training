using System;

class VehicleInfo
{
    // static registration fee
    public static double regFee = 1000;

    // readonly registration number
    public readonly string regNumber;
    public string ownerName;
    public string vehicleType;

    // constructor using 'this' keyword
    public VehicleInfo(string regNumber, string ownerName, string vehicleType)
    {
        this.regNumber = regNumber;
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // static method to update registration fee
    public static void changeRegFee(double newFee)
    {
        regFee = newFee;
    }

    // instance method to display vehicle details
    public void showVehicle()
    {
        Console.WriteLine("Owner Name       : " + ownerName);
        Console.WriteLine("Vehicle Type     : " + vehicleType);
        Console.WriteLine("Registration No. : " + regNumber);
        Console.WriteLine("Registration Fee : " + regFee);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // creating vehicle object
        VehicleInfo myVehicle = new VehicleInfo("UP14AB1234", "Ana", "Car");

        // using 'is' operator for type checking
        if (myVehicle is VehicleInfo)
        {
            myVehicle.showVehicle();
        }

        // updating registration fee
        VehicleInfo.changeRegFee(1500);

        // display updated fee
        myVehicle.showVehicle();
    }
}
