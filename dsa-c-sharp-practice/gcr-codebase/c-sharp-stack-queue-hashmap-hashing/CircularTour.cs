using System;

class PetrolPumpTour
{
    static int GetStartingPump(int[] fuel, int[] roadDistance)
    {
        int startingPoint = 0;
        int currentFuel = 0;
        int fuelShortage = 0;

        for (int i = 0; i < fuel.Length; i++)
        {
            // Add fuel from current pump and subtract distance to next
            currentFuel += fuel[i] - roadDistance[i];

            // If fuel goes negative, cannot start from previous point
            if (currentFuel < 0)
            {
                fuelShortage += currentFuel; // track deficit
                startingPoint = i + 1;       // move starting point ahead
                currentFuel = 0;             // reset current fuel
            }
        }

        // If overall fuel is enough, return start, else -1
        return (currentFuel + fuelShortage >= 0) ? startingPoint : -1;
    }

    static void Main()
    {
        int[] fuelAtPumps = { 6, 3, 7 };
        int[] distanceToNext = { 4, 6, 3 };

        int result = GetStartingPump(fuelAtPumps, distanceToNext);
        Console.WriteLine("Start from pump index: " + result);
    }
}
