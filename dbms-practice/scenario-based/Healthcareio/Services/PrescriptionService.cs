using Microsoft.Data.SqlClient;
using HealthClinicApp.Data;

namespace HealthClinicApp.Services
{
    public class PrescriptionService
    {
        public void AddPrescription(int visitId, string med, string dose, string duration)
        {
            using var con = DbManager.GetConnection();
            con.Open();

            var cmd = new SqlCommand(
            @"INSERT INTO Prescriptions(VisitId,Medicine,Dosage,Duration)
              VALUES(@v,@m,@d,@du)", con);

            cmd.Parameters.AddWithValue("@v", visitId);
            cmd.Parameters.AddWithValue("@m", med);
            cmd.Parameters.AddWithValue("@d", dose);
            cmd.Parameters.AddWithValue("@du", duration);

            cmd.ExecuteNonQuery();
        }
    }
}