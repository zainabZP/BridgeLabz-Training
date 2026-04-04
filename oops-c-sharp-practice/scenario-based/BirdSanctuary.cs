using System;

// Interfaces
interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

// Base class
class Bird
{
    public string Name;

    public Bird(string name)
    {
        Name = name;
    }
}

// Derived classes
class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies");
    }
}

class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(Name + " swims");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(Name + " swims");
    }
}

class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies");
    }

    public void Swim()
    {
        Console.WriteLine(Name + " swims");
    }
}

// Main class
class BirdSanctuary
{
    public static void Main()
    {
        // Array of base class (polymorphism)
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle("Eagle");
        birds[1] = new Sparrow("Sparrow");
        birds[2] = new Duck("Duck");
        birds[3] = new Penguin("Penguin");
        birds[4] = new Seagull("Seagull");

        // Using for loop
        for (int i = 0; i < birds.Length; i++)
        {
            Console.WriteLine("Bird: " + birds[i].Name);

            if (birds[i] is IFlyable)
            {
                ((IFlyable)birds[i]).Fly();
            }

            if (birds[i] is ISwimmable)
            {
                ((ISwimmable)birds[i]).Swim();
            }

            Console.WriteLine();
        }
    }
}

