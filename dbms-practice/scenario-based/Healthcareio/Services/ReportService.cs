using System;
using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class ReportService
    {
        private readonly string _connectionString;

        // Constructor → receives DB connection string from Program.cs
        public ReportService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ================================
        // UC-5.4 → Revenue Report
        // ================================
        public void RevenueReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT SUM(TotalAmount) AS Revenue
                        FROM Bills
                        WHERE PaymentDate BETWEEN @From AND @To";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = fromDate;
                        cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = toDate;

                        object result = cmd.ExecuteScalar();

                        decimal revenue = 0;

                        if (result != DBNull.Value && result != null)
                            revenue = Convert.ToDecimal(result);

                        Console.WriteLine("\n===== REVENUE REPORT =====");
                        Console.WriteLine($"From : {fromDate}");
                        Console.WriteLine($"To   : {toDate}");
                        Console.WriteLine($"Total Revenue : ₹ {revenue}");
                        Console.WriteLine("==========================\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating revenue report: " + ex.Message);
            }
        }
    }
}