using System;

class StaffBase
{
    // public member
    public int staffID;

    // protected member
    protected string deptName;

    // private member
    private double monthlySalary;

    // method to assign salary
    public void setSalary(double amount)
    {
        monthlySalary = amount;
    }

    // method to fetch salary
    public double getSalary()
    {
        return monthlySalary;
    }
}

// derived class
class TeamManager : StaffBase
{
    public void showStaffInfo()
    {
        staffID = 201;
        deptName = "IT";

        Console.WriteLine("Staff ID   : " + staffID);
        Console.WriteLine("Department : " + deptName);
    }

    static void Main(string[] args)
    {
        // object creation
        TeamManager mgr = new TeamManager();

        // set private salary
        mgr.setSalary(75000);

        // display staff info
        mgr.showStaffInfo();

        // display salary
        Console.WriteLine("Salary     : " + mgr.getSalary());
    }
}
