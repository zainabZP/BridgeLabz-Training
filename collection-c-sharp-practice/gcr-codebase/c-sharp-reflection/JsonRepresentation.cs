using System;
using System.Reflection;

class Person
{
    public string Name = "Luna";
    public int Age = 22;
}

class Program
{
    static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        string json = "{ ";
        foreach (var field in fields)
        {
            json += $"\"{field.Name}\": \"{field.GetValue(obj)}\", ";
        }
        json = json.TrimEnd(',', ' ') + " }";
        return json;
    }

    static void Main()
    {
        Person person = new Person();
        string json = ToJson(person);
        Console.WriteLine(json);
    }
}
