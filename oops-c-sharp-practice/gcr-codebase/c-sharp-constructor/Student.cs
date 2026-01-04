using System;

class StudentBase
{
    // public member - accessible everywhere
    public int rollNo;

    // protected member - accessible in derived classes
    protected string studentName;

    // private member - accessible only inside this class
    private double cgpaScore;

    // public method to set CGPA
    public void setCGPA(double value)
    {
        cgpaScore = value;
    }

    // public method to get CGPA
    public double getCGPA()
    {
        return cgpaScore;
    }
}

// subclass to demonstrate protected access
class PostgradStudent : StudentBase
{
    public void showStudentName()
    {
        studentName = "Ana"; // accessing protected variable
        Console.WriteLine("Student Name : " + studentName);
    }

    static void Main(string[] args)
    {
        PostgradStudent pgStudent = new PostgradStudent();
        pgStudent.rollNo = 101;
        pgStudent.setCGPA(8.5);

        pgStudent.showStudentName();
        Console.WriteLine("CGPA         : " + pgStudent.getCGPA());
    }
}
