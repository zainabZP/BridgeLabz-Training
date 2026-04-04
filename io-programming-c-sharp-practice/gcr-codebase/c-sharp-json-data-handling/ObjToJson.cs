using System;

class Car
{
    public string Brand;
    public int Year;
}

class CarToJson
{
    static void Main()
    {
        Car car = new Car();
        car.Brand = "Honda";
        car.Year = 2022;

        string json =
        "{\n" +
        "  \"Brand\": \"" + car.Brand + "\",\n" +
        "  \"Year\": " + car.Year + "\n" +
        "}";

        Console.WriteLine(json);
    }
}
