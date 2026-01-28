using System;
using System.Collections.Generic;
using System.Reflection;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key, BindingFlags.Public | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(obj, prop.Value);
            }
        }
        return obj;
    }

    static void Main()
    {
        var data = new Dictionary<string, object>
        {
            {"Name", "Luna"},
            {"Age", 22}
        };

        Student student = ToObject<Student>(data);
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
    }
}
