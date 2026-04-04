namespace FutureLogistics.Models
{
    public abstract class GoodsTransport
    {
        protected string id;
        protected string date;
        protected int rating;

        public GoodsTransport(string id, string date, int rating)
        {
            this.id = id;
            this.date = date;
            this.rating = rating;
        }

        public string Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public int Rating { get => rating; set => rating = value; }

        public abstract string SelectVehicle();
        public abstract float ComputeTotalCharge();
    }
}
