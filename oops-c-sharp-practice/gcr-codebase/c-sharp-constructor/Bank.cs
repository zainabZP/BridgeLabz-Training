using System;

class AccountBase
{
    // public member
    public int accNo;

    // protected member
    protected string holderName;

    // private member
    private double accBalance;

    // method to assign balance
    public void updateBalance(double amt)
    {
        accBalance = amt;
    }

    // method to read balance
    public double fetchBalance()
    {
        return accBalance;
    }
}

// child class
class SavingUser : AccountBase
{
    public void showAccount()
    {
        accNo = 98765;
        holderName = "Ana";

        Console.WriteLine("Account Number : " + accNo);
        Console.WriteLine("Holder Name   : " + holderName);
    }

    static void Main(string[] args)
    {
        // object creation
        SavingUser userObj = new SavingUser();

        // setting balance
        userObj.updateBalance(5000);

        // displaying details
        userObj.showAccount();
        Console.WriteLine("Balance Amount: " + userObj.fetchBalance());
    }
}
