using System;

interface IControllable
{
    void TurnOn();
    void TurnOff();
}

// Base class
abstract class Appliance
{
    protected string name;

    public Appliance(string name)
    {
        this.name = name;
    }
}

// Light
class Light : Appliance, IControllable
{
    public Light(string name) : base(name)
    {
    }

    public void TurnOn()
    {
        Console.WriteLine("Turn on " + name);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off " + name);
    }
}

// Fan
class Fan : Appliance, IControllable
{
    public Fan(string name) : base(name)
    {
    }

    public void TurnOn()
    {
        Console.WriteLine("Turn on " + name);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off " + name);
    }
}

// AC
class AC : Appliance, IControllable
{
    public AC(string name) : base(name)
    {
    }

    public void TurnOn()
    {
        Console.WriteLine("Turn on " + name);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off " + name);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        IControllable device1 = new Light("light");
        IControllable device2 = new Fan("fan");
        IControllable device3 = new AC("AC");

        device1.TurnOn();
        device2.TurnOn();
        device3.TurnOn();

        device1.TurnOff();
        device2.TurnOff();
        device3.TurnOff();
    }
}