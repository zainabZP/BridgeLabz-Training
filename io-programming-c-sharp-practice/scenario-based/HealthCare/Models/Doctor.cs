namespace HealthClinicApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public decimal ConsultationFee { get; set; }
        public bool IsActive { get; set; } = true;
    }
}