using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialize
{
    static void Main()
    {
        List<Employee> list = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Riya", Department = "HR", Salary = 40000 }
        };

        JsonSerializerOptions options = new JsonSerializerOptions();
        options.TypeInfoResolver = new DefaultJsonTypeInfoResolver();

        string json = JsonSerializer.Serialize(list, options);
        File.WriteAllText("input.txt", json);

        string data = File.ReadAllText("input.txt");
        List<Employee> empList =
            JsonSerializer.Deserialize<List<Employee>>(data, options);

        foreach (Employee e in empList)
        {
            Console.WriteLine(e.Id + " " + e.Name + " " +
                              e.Department + " " + e.Salary);
        }
    }
}
