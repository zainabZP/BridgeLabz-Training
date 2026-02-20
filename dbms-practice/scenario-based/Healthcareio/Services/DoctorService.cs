using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class DoctorService
    {
        public void AddDoctor(string name, int specialtyId, decimal fee)
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Doctors(Name,SpecialtyId,ConsultationFee)
                             VALUES(@Name,@SpecialtyId,@Fee)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@SpecialtyId", specialtyId);
            cmd.Parameters.AddWithValue("@Fee", fee);

            cmd.ExecuteNonQuery();
        }

        public void ShowAllDoctors()
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = "SELECT DoctorId,Name,SpecialtyId FROM Doctors WHERE IsActive=1";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["DoctorId"]} | {reader["Name"]} | SpecialtyId:{reader["SpecialtyId"]}");
            }
        }

        public void DeactivateDoctor(int id)
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = "UPDATE Doctors SET IsActive=0 WHERE DoctorId=@id";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}