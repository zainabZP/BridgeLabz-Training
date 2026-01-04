using System;

class EmployeeInfo
{
    // static variable shared by all employees
    public static string companyTitle = "TechCorp";
    private static int totalEmployees = 0;

    // readonly employee ID
    public readonly int empID;
    public string empName;
    public string empDesignation;

    // constructor using 'this' keyword
    public EmployeeInfo(int empID, string empName, string empDesignation)
    {
        this.empID = empID;
        this.empName = empName;
        this.empDesignation = empDesignation;
        totalEmployees++;
    }

    // static method to display total employees
    public static void showTotalEmployees()
    {
        Console.WriteLine("Total Employees : " + totalEmployees);
    }

    static void Main(string[] args)
    {
        // creating employee object
        EmployeeInfo emp1 = new EmployeeInfo(1, "Ana", "Developer");

        // using 'is' operator for type checking
        if (emp1 is EmployeeInfo)
        {
            Console.WriteLine("Name        : " + emp1.empName);
            Console.WriteLine("Designation : " + emp1.empDesignation);
            Console.WriteLine("Employee ID : " + emp1.empID);
            Console.WriteLine("Company     : " + companyTitle);
        }

        // displaying total employees
        EmployeeInfo.showTotalEmployees();
    }
}
