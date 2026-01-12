using System;

class Applicant
{
    public string Name;
    public int CreditScore;
    public int Income;
    public int LoanAmount;
}

class LoanApplication
{
    public string LoanType;
    public int Term;
    public static double Interest = 0.12;
}

interface IApprovable
{
    void ApproveLoan();
    void CalculateEMI();
}

class Base : IApprovable
{
    string loanType;
    Applicant customer;
    LoanApplication application;

    public Base(string loanType)
    {
        this.loanType = loanType;

        customer = new Applicant();
        application = new LoanApplication();

        Console.WriteLine("Enter Name:");
        customer.Name = Console.ReadLine();

        Console.WriteLine("Enter Credit Score:");
        customer.CreditScore = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Income:");
        customer.Income = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Loan Amount:");
        customer.LoanAmount = int.Parse(Console.ReadLine());

        application.LoanType = loanType;

        Console.WriteLine("Enter Loan Term (months):");
        application.Term = int.Parse(Console.ReadLine());
    }

    public void ApproveLoan()
    {
        if (customer.CreditScore >= 700)
            Console.WriteLine(loanType + " loan is APPROVED");
        else
            Console.WriteLine(loanType + " loan is REJECTED");
    }

    public void CalculateEMI()
    {
        double P = customer.LoanAmount;
        double R = LoanApplication.Interest / 12;
        int N = application.Term;

        double emi = (P * R * Math.Pow(1 + R, N)) /
                     (Math.Pow(1 + R, N) - 1);

        Console.WriteLine("EMI for " + loanType + " loan is: " + Math.Round(emi, 2));
    }
}

class Utility
{
    public static void Main()
    {
        Base user1 = new Base("Personal");
        user1.ApproveLoan();
        user1.CalculateEMI();
    }
}
