using System;

// Custom exception class
class InvalidFlightException : Exception
{
    public InvalidFlightException(string message) : base(message)
    {
    }
}

// Utility class for flight validations
class FlightUtil
{
    public bool validateFlightNumber(string flightNumber)
    {
        if (flightNumber.StartsWith("FL-"))
        {
            string numPart = flightNumber.Substring(3);
            int num;
            if (int.TryParse(numPart, out num))
            {
                if (num >= 1000 && num <= 9999)
                    return true;
            }
        }
        throw new InvalidFlightException("The flight number " + flightNumber + " is invalid");
    }

    public bool validateFlightName(string flightName)
    {
        if (flightName == "SpiceJet" || flightName == "Vistara" || flightName == "IndiGo" || flightName == "Air Arabia")
            return true;

        throw new InvalidFlightException("The flight name " + flightName + " is invalid");
    }

    public bool validatePassengerCount(int passengerCount, string flightName)
    {
        int maxCapacity = 0;

        if (flightName == "SpiceJet") maxCapacity = 396;
        else if (flightName == "Vistara") maxCapacity = 615;
        else if (flightName == "IndiGo") maxCapacity = 230;
        else if (flightName == "Air Arabia") maxCapacity = 130;

        if (passengerCount > 0 && passengerCount <= maxCapacity)
            return true;

        throw new InvalidFlightException("The passenger count " + passengerCount + " is invalid for " + flightName);
    }

    public double calculateFuelToFillTank(string flightName, double currentFuelLevel)
    {
        double tankCapacity = 0;

        if (flightName == "SpiceJet") tankCapacity = 200000;
        else if (flightName == "Vistara") tankCapacity = 300000;
        else if (flightName == "IndiGo") tankCapacity = 250000;
        else if (flightName == "Air Arabia") tankCapacity = 150000;

        if (currentFuelLevel < 0 || currentFuelLevel > tankCapacity)
            throw new InvalidFlightException("Invalid fuel level for " + flightName);

        return tankCapacity - currentFuelLevel;
    }
}

// Main class for user interaction
class UserInterface
{
    static void Main()
    {
        Console.WriteLine("Enter flight details");
        string input = Console.ReadLine();

        string[] parts = input.Split(':');

        if (parts.Length != 4)
        {
            Console.WriteLine("Invalid input format");
            return;
        }

        string flightNumber = parts[0];
        string flightName = parts[1];
        int passengerCount;
        double currentFuelLevel;

        // parse passenger count and fuel level safely
        if (!int.TryParse(parts[2], out passengerCount) || !double.TryParse(parts[3], out currentFuelLevel))
        {
            Console.WriteLine("Passenger count or fuel level is invalid");
            return;
        }

        FlightUtil flightUtil = new FlightUtil();

        try
        {
            flightUtil.validateFlightNumber(flightNumber);
            flightUtil.validateFlightName(flightName);
            flightUtil.validatePassengerCount(passengerCount, flightName);

            double fuelNeeded = flightUtil.calculateFuelToFillTank(flightName, currentFuelLevel);

            Console.WriteLine("Fuel required to fill the tank: " + fuelNeeded + " liters");
        }
        catch (InvalidFlightException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
