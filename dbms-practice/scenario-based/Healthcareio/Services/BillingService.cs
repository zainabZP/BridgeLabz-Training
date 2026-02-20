// using Microsoft.Data.SqlClient;
// using HealthClinicApp.Data;

// namespace HealthClinicApp.Services
// {
//     public class BillingService
//     {
//         public int GenerateBill(int visitId, decimal amount)
//         {
//             using var con = DbManager.GetConnection();
//             con.Open();

//             var cmd = new SqlCommand(
//             @"INSERT INTO Bills(VisitId,TotalAmount)
//               OUTPUT INSERTED.BillId
//               VALUES(@v,@a)", con);

//             cmd.Parameters.AddWithValue("@v", visitId);
//             cmd.Parameters.AddWithValue("@a", amount);

//             return (int)cmd.ExecuteScalar();
//         }

//         public void RecordPayment(int billId, string mode)
//         {
//             using var con = DbManager.GetConnection();
//             con.Open();

//             using var tx = con.BeginTransaction();

//             var updateBill = new SqlCommand(
//             @"UPDATE Bills SET PaymentStatus='PAID',PaymentDate=GETDATE()
//               WHERE BillId=@b", con, tx);
//             updateBill.Parameters.AddWithValue("@b", billId);
//             updateBill.ExecuteNonQuery();

//             var insertTxn = new SqlCommand(
//             @"INSERT INTO PaymentTransactions(BillId,PaymentMode)
//               VALUES(@b,@m)", con, tx);
//             insertTxn.Parameters.AddWithValue("@b", billId);
//             insertTxn.Parameters.AddWithValue("@m", mode);
//             insertTxn.ExecuteNonQuery();

//             tx.Commit();
//         }
//     }
// }

using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
    public class BillingService
    {
        private readonly string _conn;

        public BillingService(string conn)
        {
            _conn = conn;
        }

        public int GenerateBill(int visitId, decimal amount)
        {
            using var con = new SqlConnection(_conn);
            con.Open();

            var cmd = new SqlCommand(
            @"INSERT INTO Bills(visit_id,total_amount)
              OUTPUT INSERTED.bill_id
              VALUES(@v,@a)", con);

            cmd.Parameters.AddWithValue("@v", visitId);
            cmd.Parameters.AddWithValue("@a", amount);

            return (int)cmd.ExecuteScalar();
        }

        public void RecordPayment(int billId, string mode)
        {
            using var con = new SqlConnection(_conn);
            con.Open();

            using var tx = con.BeginTransaction();

            new SqlCommand(
            "UPDATE Bills SET payment_status='PAID',payment_date=GETDATE() WHERE bill_id=@b",
            con, tx)
            { Parameters = { new("@b", billId) } }.ExecuteNonQuery();

            new SqlCommand(
            @"INSERT INTO PaymentTransactions(bill_id,amount,payment_mode)
              SELECT bill_id,total_amount,@m FROM Bills WHERE bill_id=@b",
            con, tx)
            { Parameters = { new("@b", billId), new("@m", mode) } }.ExecuteNonQuery();

            tx.Commit();
        }
    }
}