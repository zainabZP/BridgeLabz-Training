using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        accounts[101] = 5000;
        accounts[102] = 8000;

        Queue<int> withdrawals = new Queue<int>();
        withdrawals.Enqueue(101);
        withdrawals.Enqueue(102);

        while (withdrawals.Count > 0)
        {
            int acc = withdrawals.Dequeue();
            accounts[acc] -= 1000;
            Console.WriteLine("Account " + acc + " Balance: " + accounts[acc]);
        }
    }
}
