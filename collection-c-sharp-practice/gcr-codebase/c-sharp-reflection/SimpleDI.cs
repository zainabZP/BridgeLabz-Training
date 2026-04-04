using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Engine
{
    public void Start() => Console.WriteLine("Engine started!");
}

class Car
{
    [Inject]
    public Engine engine;

    public void Drive() => engine.Start();
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        Type type = typeof(Car);

        foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            if (field.GetCustomAttribute(typeof(InjectAttribute)) != null)
            {
                field.SetValue(car, Activator.CreateInstance(field.FieldType));
            }
        }

        car.Drive();
    }
}
