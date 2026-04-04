namespace HealthClinicApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }=string.Empty;
        public DateTime DOB { get; set; }
        public string Phone { get; set; }=string.Empty;
        public string Address { get; set; }=string.Empty;
        public string BloodGroup { get; set; }=string.Empty;
    }
}