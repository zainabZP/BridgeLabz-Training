using HealthClinicApp.Models;

namespace HealthClinicApp.Utilities
{
    public static class FileStorage
    {
        private static readonly string DoctorFile = "doctors.txt";
        private static readonly string AppointmentFile = "appointments.txt";

        public static void SaveDoctors(List<Doctor> doctors)
        {
            using StreamWriter writer = new StreamWriter(DoctorFile);
            foreach (var d in doctors)
            {
                writer.WriteLine($"{d.DoctorId}|{d.Name}|{d.SpecialtyId}|{d.ConsultationFee}|{d.IsActive}");
            }
        }

        public static List<Doctor> LoadDoctors()
        {
            var list = new List<Doctor>();
            if (!File.Exists(DoctorFile)) return list;

            foreach (var line in File.ReadAllLines(DoctorFile))
            {
                var parts = line.Split('|');
                list.Add(new Doctor
                {
                    DoctorId = int.Parse(parts[0]),
                    Name = parts[1],
                    SpecialtyId = int.Parse(parts[2]),
                    ConsultationFee = decimal.Parse(parts[3]),
                    IsActive = bool.Parse(parts[4])
                });
            }
            return list;
        }

        public static void SaveAppointments(List<Appointment> appointments)
        {
            using StreamWriter writer = new StreamWriter(AppointmentFile);
            foreach (var a in appointments)
            {
                writer.WriteLine($"{a.AppointmentId}|{a.PatientId}|{a.DoctorId}|{a.AppointmentDateTime}|{a.Status}");
            }
        }

        public static List<Appointment> LoadAppointments()
        {
            var list = new List<Appointment>();
            if (!File.Exists(AppointmentFile)) return list;

            foreach (var line in File.ReadAllLines(AppointmentFile))
            {
                var parts = line.Split('|');
                list.Add(new Appointment
                {
                    AppointmentId = int.Parse(parts[0]),
                    PatientId = int.Parse(parts[1]),
                    DoctorId = int.Parse(parts[2]),
                    AppointmentDateTime = DateTime.Parse(parts[3]),
                    Status = parts[4]
                });
            }
            return list;
        }
    }
}