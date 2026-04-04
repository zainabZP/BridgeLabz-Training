using System;

namespace FutureLogistics.Models
{
    public class BrickTransport : GoodsTransport
    {
        private float size;
        private int quantity;
        private float pricePerBrick;

        public BrickTransport(string id, string date, int rating,
                              float size, int quantity, float pricePerBrick)
            : base(id, date, rating)
        {
            this.size = size;
            this.quantity = quantity;
            this.pricePerBrick = pricePerBrick;
        }

        public float Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float PricePerBrick { get => pricePerBrick; set => pricePerBrick = value; }

        public override string SelectVehicle()
        {
            if (quantity < 300) return "Truck";
            if (quantity <= 500) return "Lorry";
            return "MonsterLorry";
        }

        public override float ComputeTotalCharge()
        {
            float baseCost = quantity * pricePerBrick;
            float tax = baseCost * 0.3f;
            float vehicleCost = GetVehiclePrice(SelectVehicle());
            float discount = 0;

            if (rating == 5) discount = 0.2f * baseCost;
            else if (rating == 3 || rating == 4) discount = 0.1f * baseCost;

            float total = baseCost + tax + vehicleCost - discount;
            return (float)Math.Round(total, 2);
        }

        private float GetVehiclePrice(string vehicle)
        {
            switch (vehicle.ToLower())
            {
                case "truck": return 1000;
                case "lorry": return 1700;
                default: return 3000;
            }
        }
    }
}
