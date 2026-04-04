using System;
using System.Collections.Generic;

class InsurancePolicy
{
    static void Main()
    {
        HashSet<string> policies = new HashSet<string>();
        policies.Add("P101");
        policies.Add("P102");
        policies.Add("P101");

        foreach (string p in policies)
        {
            Console.WriteLine(p);
        }
    }
}
