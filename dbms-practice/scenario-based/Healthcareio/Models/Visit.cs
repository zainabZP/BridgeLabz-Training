namespace HealthClinicApp.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public string Diagnosis { get; set; }=string.Empty;
        public string Notes { get; set; }=string.Empty;
        public DateTime VisitDate { get; set; }
    }
}