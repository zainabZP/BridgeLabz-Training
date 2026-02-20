using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class VisitService
    {
        public int RecordVisit(int appointmentId, string diagnosis, string notes)
        {
            using var con = DbManager.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();

            var cmd = new SqlCommand(
            @"INSERT INTO Visits(AppointmentId,Diagnosis,Notes)
              OUTPUT INSERTED.VisitId
              VALUES(@a,@d,@n)", con, tx);

            cmd.Parameters.AddWithValue("@a", appointmentId);
            cmd.Parameters.AddWithValue("@d", diagnosis);
            cmd.Parameters.AddWithValue("@n", notes);

            int visitId = (int)cmd.ExecuteScalar();

            var update = new SqlCommand(
            @"UPDATE Appointments SET Status='COMPLETED'
              WHERE AppointmentId=@id", con, tx);

            update.Parameters.AddWithValue("@id", appointmentId);
            update.ExecuteNonQuery();

            tx.Commit();
            return visitId;
        }
    }
}