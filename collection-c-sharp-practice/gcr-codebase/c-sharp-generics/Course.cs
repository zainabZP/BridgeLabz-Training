using System;
using System.Collections.Generic;

// Base class for all courses
abstract class Course
{
    public string Name = "";
    public abstract void EvaluateCourse();
}

// Different types of courses
class ExamType : Course
{
    public override void EvaluateCourse()
    {
        Console.WriteLine(Name + " is evaluated by exam");
    }
}

class AssignmentType : Course
{
    public override void EvaluateCourse()
    {
        Console.WriteLine(Name + " is evaluated by assignment");
    }
}

// Generic course manager
class CourseManager<T> where T : Course
{
    private List<T> list = new List<T>();

    public void Add(T course)
    {
        list.Add(course);
    }

    public void EvaluateAll()
    {
        foreach (T c in list)
            c.EvaluateCourse();
    }
}

class Program
{
    static void Main()
    {
        CourseManager<ExamType> exams = new CourseManager<ExamType>();
        exams.Add(new ExamType { Name = "DSA" });

        exams.EvaluateAll();
    }
}
