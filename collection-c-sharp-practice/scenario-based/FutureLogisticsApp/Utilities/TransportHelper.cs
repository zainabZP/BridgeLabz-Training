using System;
using FutureLogistics.Models;

namespace FutureLogistics.Utilities
{
    public class TransportHelper
    {
        public GoodsTransport ParseInput(string input)
        {
            try
            {
                string[] tokens = input.Split(':');
                string id = tokens[0];
                string date = tokens[1];
                int rating = int.Parse(tokens[2]);
                string type = tokens[3];

                if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
                {
                    return new BrickTransport(
                        id, date, rating,
                        float.Parse(tokens[4]),
                        int.Parse(tokens[5]),
                        float.Parse(tokens[6]));
                }
                else if (type.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase))
                {
                    return new TimberTransport(
                        id, date, rating,
                        float.Parse(tokens[4]),
                        float.Parse(tokens[5]),
                        tokens[6],
                        float.Parse(tokens[7]));
                }
                else
                {
                    Console.WriteLine("Unknown transport type!");
                    return null;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input format! Check colons and numeric values.");
                return null;
            }
        }

        public bool IsValidTransportId(string id)
        {
            if (id.Length == 7 && id.StartsWith("RTS") &&
                char.IsDigit(id[3]) && char.IsDigit(id[4]) && char.IsDigit(id[5]) &&
                char.IsUpper(id[6]))
            {
                return true;
            }

            Console.WriteLine($"Transport ID {id} is invalid");
            Console.WriteLine("Please provide a valid record");
            return false;
        }

        public string GetTransportType(GoodsTransport gt)
        {
            if (gt is BrickTransport) return "BrickTransport";
            if (gt is TimberTransport) return "TimberTransport";
            return "Unknown";
        }
    }
}
