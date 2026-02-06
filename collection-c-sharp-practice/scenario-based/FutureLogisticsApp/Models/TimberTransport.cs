using System;

namespace FutureLogistics.Models
{
    public class TimberTransport : GoodsTransport
    {
        private float length;
        private float radius;
        private string type;
        private float pricePerUnit;

        public TimberTransport(string id, string date, int rating,
                               float length, float radius, string type, float pricePerUnit)
            : base(id, date, rating)
        {
            this.length = length;
            this.radius = radius;
            this.type = type;
            this.pricePerUnit = pricePerUnit;
        }

        public override string SelectVehicle()
        {
            double area = 2 * 3.147 * radius * length;
            if (area < 250) return "Truck";
            if (area <= 400) return "Lorry";
            return "MonsterLorry";
        }

        public override float ComputeTotalCharge()
        {
            double volume = 3.147 * radius * radius * length;
            double rate = type.Equals("Premium", StringComparison.OrdinalIgnoreCase) ? 0.25 : 0.15;
            double baseCost = volume * pricePerUnit * rate;
            double tax = baseCost * 0.3;
            float vehicleCost = GetVehiclePrice(SelectVehicle());
            double discount = 0;

            if (rating == 5) discount = baseCost * 0.2;
            else if (rating == 3 || rating == 4) discount = baseCost * 0.1;

            float total = (float)(baseCost + tax + vehicleCost - discount);
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

        public string TimberType => type;
        public float TimberPrice => pricePerUnit;
    }
}
