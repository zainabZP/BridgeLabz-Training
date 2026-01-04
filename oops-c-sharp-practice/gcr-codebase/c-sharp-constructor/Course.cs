using System;

class CourseInfo
{
    // instance data members
    public string subjectName;
    public int courseLength;
    public double courseFee;

    // static member (common for all courses)
    public static string collegeName = "GLA University";

    // instance method
    public void showCourse()
    {
        Console.WriteLine("Course       : " + subjectName);
        Console.WriteLine("Duration     : " + courseLength + " days");
        Console.WriteLine("Fee Amount   : " + courseFee);
        Console.WriteLine("Institute    : " + collegeName);
        Console.WriteLine();
    }

    // static method to change institute name
    public static void changeInstitute(string newName)
    {
        collegeName = newName;
    }

    static void Main(string[] args)
    {
        // creating object
        CourseInfo courseObj = new CourseInfo();

        courseObj.subjectName = "C# Programming";
        courseObj.courseLength = 30;
        courseObj.courseFee = 5000;

        // displaying course details
        courseObj.showCourse();

        // updating institute name
        CourseInfo.changeInstitute("GLA Online Academy");

        // displaying updated details
        courseObj.showCourse();
    }
}
