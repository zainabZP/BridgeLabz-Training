using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();

        votes["A"] = 3;
        votes["B"] = 5;
        votes["C"] = 2;

        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(votes);

        foreach (var v in sortedVotes)
        {
            Console.WriteLine(v.Key + " : " + v.Value);
        }
    }
}
