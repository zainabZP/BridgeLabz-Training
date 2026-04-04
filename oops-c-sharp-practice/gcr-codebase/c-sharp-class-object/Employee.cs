using System;

class StaffInfo
{
    // employee data members
    public string empName;
    public int empCode;
    public double monthlyPay;

    // method to print employee details
    public void showInfo()
    {
        Console.WriteLine("Employee Name : " + empName);
        Console.WriteLine("Employee ID   : " + empCode);
        Console.WriteLine("Salary        : " + monthlyPay);
    }

    static void Main(string[] args)
    {
        // creating object
        StaffInfo staffObj = new StaffInfo();

        // assigning values
        staffObj.empName = "Ana";
        staffObj.empCode = 101;
        staffObj.monthlyPay = 50000.0;

        // displaying details
        staffObj.showInfo();
    }
}
