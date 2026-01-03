using System;
class Vehicle{
    public int MaxSpeed=30;
    public string FuelType="Deisel";
    public void DisplayInfo(){
        Console.WriteLine("Max Speed = " + MaxSpeed + " km/hr Fuel Type = " + FuelType);
    }
}
class Car : Vehicle{
    public int SeatCapacity=25;
    public void DisplayInfo(){
        Console.WriteLine("Car Max Speed = " + MaxSpeed +" Fuel Type = " + FuelType +" Seat Capacity = " + SeatCapacity);
    }
}
class Truck : Vehicle{
    public int PayloadCapacity=200;
    public void DisplayInfo(){
        Console.WriteLine("Truck Max Speed = " + MaxSpeed +" Fuel Type = " + FuelType +" Payload Capacity = " + PayloadCapacity);
    }
}
class Motorcycle : Vehicle{
    public bool HasSidecar=true;
    public void DisplayInfo(){
        Console.WriteLine("Motorcycle Max Speed = " + MaxSpeed +" Fuel Type = " + FuelType +" Has Sidecar = " + HasSidecar);
    }
}

class Program{
    public static void Main(){
        Vehicle vehicle=new Vehicle();
        Car car=new Car();
        Truck truck=new Truck();
        Motorcycle motorcycle=new Motorcycle();
        vehicle.DisplayInfo();
        car.DisplayInfo();
        truck.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}
