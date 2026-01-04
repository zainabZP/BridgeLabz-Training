using System;

class AccountInfo
{
    // static member (common for all objects)
    public static string bankTitle = "SBI";

    // readonly member
    public readonly int accNumber;

    public string customerName;

    // constructor using this keyword
    public AccountInfo(int accNumber, string customerName)
    {
        this.accNumber = accNumber;
        this.customerName = customerName;
    }

    static void Main(string[] args)
    {
        // object creation
        AccountInfo obj = new AccountInfo(101, "Ana");

        // using is operator
        if (obj is AccountInfo)
        {
            Console.WriteLine("Account Holder : " + obj.customerName);
            Console.WriteLine("Bank Name     : " + bankTitle);
            Console.WriteLine("Account No    : " + obj.accNumber);
        }
    }
}
