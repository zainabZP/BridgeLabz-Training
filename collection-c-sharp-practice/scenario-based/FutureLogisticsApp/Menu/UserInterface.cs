using System;
using FutureLogistics.Models;
using FutureLogistics.Utilities;

namespace FutureLogistics.Menu
{
    public class UserInterface
    {
        public void Launch()
        {
            Console.WriteLine("Enter the transport details:");
            string input = Console.ReadLine();

            TransportHelper helper = new TransportHelper();
            GoodsTransport gt = helper.ParseInput(input);

            if (gt == null || !helper.IsValidTransportId(gt.Id))
                return;

            Console.WriteLine($"Transporter ID : {gt.Id}");
            Console.WriteLine($"Date of transport : {gt.Date}");
            Console.WriteLine($"Rating : {gt.Rating}");

            string type = helper.GetTransportType(gt);

            if (type == "BrickTransport")
            {
                BrickTransport bt = (BrickTransport)gt;
                Console.WriteLine($"Brick quantity : {bt.Quantity}");
                Console.WriteLine($"Brick price : {bt.PricePerBrick}");
            }
            else if (type == "TimberTransport")
            {
                TimberTransport tt = (TimberTransport)gt;
                Console.WriteLine($"Timber type : {tt.TimberType}");
                Console.WriteLine($"Timber price per unit : {tt.TimberPrice}");
            }

            Console.WriteLine($"Vehicle : {gt.SelectVehicle()}");
            Console.WriteLine($"Total charge : {gt.ComputeTotalCharge()}");
        }
    }
}
