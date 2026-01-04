using System;

class StudentInfo
{
    // static university name
    public static string universityTitle = "GLA University";
    private static int totalStudents = 0;

    // readonly roll number
    public readonly int rollNo;
    public string studentName;
    public char grade;

    // constructor using 'this' keyword
    public StudentInfo(int rollNo, string studentName, char grade)
    {
        this.rollNo = rollNo;
        this.studentName = studentName;
        this.grade = grade;
        totalStudents++;
    }

    // static method to display total students
    public static void showTotalStudents()
    {
        Console.WriteLine("Total Students : " + totalStudents);
    }

    // instance method to display student details
    public void showStudent()
    {
        Console.WriteLine("Name  : " + studentName);
        Console.WriteLine("Roll  : " + rollNo);
        Console.WriteLine("Grade : " + grade);
        Console.WriteLine("University : " + universityTitle);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // creating student object
        StudentInfo student1 = new StudentInfo(1, "Ana", 'A');

        // using 'is' operator for type checking
        if (student1 is StudentInfo)
        {
            student1.showStudent();
        }

        // display total students
        StudentInfo.showTotalStudents();
    }
}
