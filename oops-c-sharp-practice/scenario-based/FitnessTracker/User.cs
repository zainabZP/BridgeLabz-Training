using System;

public class UserProfile
{
    public string Name;
    public int Age;

    public UserProfile(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowDetails()
    {
        Console.WriteLine("User Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
