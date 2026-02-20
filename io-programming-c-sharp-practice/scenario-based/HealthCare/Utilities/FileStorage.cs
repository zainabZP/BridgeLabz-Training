using System.Text;
using HealthClinicApp.Models;

namespace HealthClinicApp.Utilities
{
public static class FileStorage
{
private static readonly string patientFile = "patients.txt";
private static readonly string doctorFile = "doctors.txt";
private static readonly string appointmentFile = "appointments.txt";

    // ================= PATIENT =================

    public static void SavePatients(List<Patient> patients)
    {
        using StreamWriter writer = new StreamWriter(patientFile, false, Encoding.UTF8);

        foreach (var p in patients)
        {
            writer.WriteLine($"{p.PatientId}|{p.Name}|{p.DOB}|{p.Phone}|{p.Address}|{p.BloodGroup}");
        }
    }

    public static List<Patient> LoadPatients()
    {
        List<Patient> list = new();

        if (!File.Exists(patientFile))
            return list;

        using StreamReader reader = new StreamReader(patientFile);

        while (!reader.EndOfStream)
        {
            var parts = reader.ReadLine().Split('|');

            list.Add(new Patient
            {
                PatientId = int.Parse(parts[0]),
                Name = parts[1],
                DOB = DateTime.Parse(parts[2]),
                Phone = parts[3],
                Address = parts[4],
                BloodGroup = parts[5]
            });
        }

        return list;
    }

    // ================= DOCTOR =================

    public static void SaveDoctors(List<Doctor> doctors)
    {
        using StreamWriter writer = new StreamWriter(doctorFile, false, Encoding.UTF8);

        foreach (var d in doctors)
        {
            writer.WriteLine($"{d.DoctorId}|{d.Name}|{d.Specialty}|{d.ConsultationFee}|{d.IsActive}");
        }
    }

    public static List<Doctor> LoadDoctors()
    {
        List<Doctor> list = new();

        if (!File.Exists(doctorFile))
            return list;

        using StreamReader reader = new StreamReader(doctorFile);

        while (!reader.EndOfStream)
        {
            var parts = reader.ReadLine().Split('|');

            list.Add(new Doctor
            {
                DoctorId = int.Parse(parts[0]),
                Name = parts[1],
                Specialty = parts[2],
                ConsultationFee = decimal.Parse(parts[3]),
                IsActive = bool.Parse(parts[4])
            });
        }

        return list;
    }

    // ================= APPOINTMENT =================

    public static void SaveAppointments(List<Appointment> appointments)
    {
        using StreamWriter writer = new StreamWriter(appointmentFile, false, Encoding.UTF8);

        foreach (var a in appointments)
        {
            writer.WriteLine($"{a.AppointmentId}|{a.PatientId}|{a.DoctorId}|{a.DateTime}|{a.Status}");
        }
    }

    public static List<Appointment> LoadAppointments()
    {
        List<Appointment> list = new();

        if (!File.Exists(appointmentFile))
            return list;

        using StreamReader reader = new StreamReader(appointmentFile);

        while (!reader.EndOfStream)
        {
            var parts = reader.ReadLine().Split('|');

            list.Add(new Appointment
            {
                AppointmentId = int.Parse(parts[0]),
                PatientId = int.Parse(parts[1]),
                DoctorId = int.Parse(parts[2]),
                DateTime = DateTime.Parse(parts[3]),
                Status = parts[4]
            });
        }

        return list;
    }
}
}
