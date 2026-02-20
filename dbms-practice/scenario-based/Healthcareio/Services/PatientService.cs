using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;
using HealthClinicApp.Models;

namespace HealthClinicApp.Services
{
    public class PatientService
    {
        public void RegisterPatient(string name, DateTime dob, string phone,
            string address, string bloodGroup)
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Patients(Name,DOB,Phone,Address,BloodGroup)
                             VALUES(@Name,@DOB,@Phone,@Address,@BloodGroup)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@DOB", dob);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Patient stored in database.");
        }

        public void ShowAllPatients()
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Patients";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["PatientId"]} | {reader["Name"]} | {reader["Phone"]}");
            }
        }

        // UC-1.3 Search Patient
        public void Search(string keyword)
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = @"SELECT * FROM Patients
                             WHERE Name LIKE @k OR Phone = @phone";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
            cmd.Parameters.AddWithValue("@phone", keyword);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["PatientId"]} | {reader["Name"]} | {reader["Phone"]}");
            }
        }
    }
}