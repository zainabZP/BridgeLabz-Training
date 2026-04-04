namespace HealthClinicApp.Services
{
    public class BillingService
    {
        public decimal GenerateBill(decimal consultationFee, decimal extraCharges)
        {
            decimal total = consultationFee + extraCharges;
            Console.WriteLine($"Total Bill: {total}");
            return total;
        }
    }
}