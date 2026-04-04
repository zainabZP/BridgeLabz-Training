
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Data
{
    public class DbManager
    {
        private static string connectionString =
            "Server=WASEEM\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}