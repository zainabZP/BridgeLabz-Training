using System;
class Employee{
    public static string Name="zainab";
    public static int Id=1;
    public static int Salary=30000;
    public void Display(){
        Console.WriteLine("Name = "+Employee.Name+" Id = "+Employee.Id+" Salary = "+Employee.Salary);
    }
}
class Manager:Employee{
    static int TeamSize=5;
    public void Display(){
        Console.WriteLine("Name = "+Manager.Name+" Id = "+Manager.Id+" Salary = "+Manager.Salary+" Team Size = "+Manager.TeamSize);
    }
}
class Developer:Employee{
    static string ProgrammingLanguage="c-sharp";
    public void Display(){
        Console.WriteLine("Name = "+Developer.Name+" Id = "+Developer.Id+" Salary = "+Developer.Salary+" Programming Language = "+Developer.ProgrammingLanguage);
    }
}
class Intern:Employee{
    static string InternshipDuration="six months";
    public void Display(){
        Console.WriteLine("Name = "+Intern.Name+" Id = "+Intern.Id+" Salary = "+Intern.Salary+" Internship training = "+Intern.InternshipDuration);
    }
}
class Program{
    public static void Main(){
        Employee emp=new Employee();
        Manager manager=new Manager();
        Developer dev=new Developer();
        Intern intern=new Intern();
        emp.Display();
        manager.Display();
        dev.Display();
        intern.Display();
    }
}