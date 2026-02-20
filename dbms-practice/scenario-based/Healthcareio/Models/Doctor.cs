namespace HealthClinicApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }=string.Empty;
        public int SpecialtyId { get; set; }   // FK to Specialties table
        public decimal ConsultationFee { get; set; }
        public bool IsActive { get; set; }
    }
}