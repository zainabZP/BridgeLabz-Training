using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }
    public int RollNo { get; set; }

    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, RollNo: {RollNo}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        // Create instance dynamically
        object studentObj = Activator.CreateInstance(type);

        // Set properties using Reflection
        type.GetProperty("Name").SetValue(studentObj, "Luna");
        type.GetProperty("RollNo").SetValue(studentObj, 101);

        // Call Display method
        type.GetMethod("Display").Invoke(studentObj, null);
    }
}
