using System;

class BankInfo
{
    // static variable shared by all accounts
    public static string bankTitle = "SBI";
    private static int totalAccounts = 0;

    // readonly account number
    public readonly int accNo;
    public string holderName;

    // constructor using 'this' keyword
    public BankInfo(int accNo, string holderName)
    {
        this.accNo = accNo;
        this.holderName = holderName;
        totalAccounts++;
    }

    // static method to show total accounts
    public static void showTotalAccounts()
    {
        Console.WriteLine("Total Accounts : " + totalAccounts);
    }

    static void Main(string[] args)
    {
        // creating bank account object
        BankInfo account1 = new BankInfo(101, "Ana");

        // using 'is' operator for type checking
        if (account1 is BankInfo)
        {
            Console.WriteLine("Account Holder : " + account1.holderName);
            Console.WriteLine("Account Number : " + account1.accNo);
            Console.WriteLine("Bank Name      : " + bankTitle);
        }

        // displaying total accounts
        BankInfo.showTotalAccounts();
    }
}
