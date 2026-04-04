using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class AppointmentService
{
private readonly List<Appointment> _appointments;

    public AppointmentService()
    {
        _appointments = FileStorage.LoadAppointments();
    }

    public void BookAppointment(int patientId, int doctorId, DateTime dateTime)
    {
        var appointment = new Appointment
        {
            AppointmentId = IdGenerator.NextAppointmentId(),
            PatientId = patientId,
            DoctorId = doctorId,
            DateTime = dateTime
        };

        _appointments.Add(appointment);
        FileStorage.SaveAppointments(_appointments);

        Console.WriteLine("Appointment stored in file.");
    }

    public void ShowAppointments()
    {
        foreach (var a in _appointments)
            Console.WriteLine($"{a.AppointmentId} | {a.DateTime}");
    }
}
}
