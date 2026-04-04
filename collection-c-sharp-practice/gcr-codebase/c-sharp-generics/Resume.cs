using System;
using System.Collections.Generic;

// Base class for all job roles
abstract class Role
{
    public string Name = "";  // simpler than property
    public abstract void ScreenCandidate();
}

// Different job roles
class Developer : Role
{
    public override void ScreenCandidate()
    {
        Console.WriteLine("Screening Developer: " + Name);
    }
}

class Analyst : Role
{
    public override void ScreenCandidate()
    {
        Console.WriteLine("Screening Analyst: " + Name);
    }
}

// Generic resume handler
class ResumeHandler<T> where T : Role
{
    private List<T> list = new List<T>();

    public void Add(T candidate)
    {
        list.Add(candidate);
    }

    public void ProcessAll()
    {
        foreach (T c in list)
            c.ScreenCandidate();
    }
}

class TestProgram
{
    static void Main()
    {
        ResumeHandler<Developer> devs = new ResumeHandler<Developer>();

        devs.Add(new Developer { Name = "Zainab" });
        devs.ProcessAll();
    }
}
