using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class AppointmentService
    {
        public void BookAppointment(int patientId, int doctorId, DateTime dt)
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Appointments(PatientId,DoctorId,AppointmentDateTime)
                             VALUES(@Pid,@Did,@Dt)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Pid", patientId);
            cmd.Parameters.AddWithValue("@Did", doctorId);
            cmd.Parameters.AddWithValue("@Dt", dt);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Appointment booked.");
        }

        public void ViewSchedule()
        {
            using var conn = DbManager.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    a.AppointmentId,
                    p.Name AS PatientName,
                    d.Name AS DoctorName,
                    a.AppointmentDateTime
                FROM Appointments a
                JOIN Patients p ON a.PatientId=p.PatientId
                JOIN Doctors d ON a.DoctorId=d.DoctorId";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["AppointmentId"]} | {reader["PatientName"]} | {reader["DoctorName"]} | {reader["AppointmentDateTime"]}");
            }
        }
    }
}