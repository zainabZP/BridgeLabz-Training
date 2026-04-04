using System;
interface IRentable{
    double CalculateRent(int days);
}
class Vehicle{
    private int vehicleId;
    private string vehicleName;
    private double rentPerDay;
    public void SetVehicleId(int id){
        vehicleId = id;
    }
    public void SetVehicleName(string name){
        vehicleName = name;
    }
    public void SetRentPerDay(double rent){
        rentPerDay = rent;
    }
    public int GetVehicleId() { return vehicleId; }
    public string GetVehicleName() { return vehicleName; }
    public double GetRentPerDay() { return rentPerDay; }
    public void Display(){
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Vehicle Name: " + vehicleName);
    }
}
class Bike : Vehicle, IRentable{
    public double CalculateRent(int days){
        return days * GetRentPerDay(); ;
    }
    public void Display(){
        base.Display();
        Console.WriteLine("Vehicle Type: Bike");
    }
}
class Car : Vehicle, IRentable{
    public double CalculateRent(int days){
        return days * GetRentPerDay(); ;
    }
    public void Display(){
        base.Display();
        Console.WriteLine("Vehicle Type: Car");
    }
}
class Truck : Vehicle, IRentable
{
    public double CalculateRent(int days)
    {
        return days * GetRentPerDay(); ;
    }

    public void Display()
    {
        base.Display();
        Console.WriteLine("Vehicle Type: Truck");
    }
}
class Customer{
    private int customerId;
    private string customerName;

    public void SetCustomerId(int id){
        customerId = id;
    }

    public void SetCustomerName(string name){
        customerName = name;
    }

    public void DisplayCustomer(){
        Console.WriteLine("Customer ID: " + customerId);
        Console.WriteLine("Customer Name: " + customerName);
    }
}
class Program
{
    static void Main()
    {
        Bike b = new Bike();
        b.SetVehicleId(1);
        b.SetVehicleName("Honda Bike");
        b.SetRentPerDay(300);

        Car c = new Car();
        c.SetVehicleId(2);
        c.SetVehicleName("Maruti Car");
        c.SetRentPerDay(1000);

        Truck t = new Truck();
        t.SetVehicleId(3);
        t.SetVehicleName("Tata Truck");
        t.SetRentPerDay(2000);

        Customer cust = new Customer();
        cust.SetCustomerId(101);
        cust.SetCustomerName("Zainab");

        Console.WriteLine("Customer Details:");
        cust.DisplayCustomer();

        Console.WriteLine("Bike Details:");
        b.Display();
        Console.WriteLine("Rent for 5 days: " + b.CalculateRent(3));

        Console.WriteLine("Car Details:");
        c.Display();
        Console.WriteLine("Rent for 3 days: " + c.CalculateRent(2));

        Console.WriteLine("Truck Details:");
        t.Display();
        Console.WriteLine("Rent for 1 day: " + t.CalculateRent(1));
    }
}
