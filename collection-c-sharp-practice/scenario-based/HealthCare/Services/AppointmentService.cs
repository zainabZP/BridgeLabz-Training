// using HealthClinicApp.Models;
// using HealthClinicApp.Utilities;

// namespace HealthClinicApp.Services
// {
//     public class AppointmentService
//     {
//         private readonly List<Appointment> _appointments = new();

//         public void BookAppointment(int patientId, int doctorId, DateTime dateTime)
//         {
//             bool alreadyBooked = _appointments.Any(a =>
//                 a.DoctorId == doctorId && a.DateTime == dateTime && a.Status == "SCHEDULED");

//             if (alreadyBooked)
//             {
//                 Console.WriteLine("Slot not available.");
//                 return;
//             }

//             var appointment = new Appointment
//             {
//                 AppointmentId = IdGenerator.NextAppointmentId(),
//                 PatientId = patientId,
//                 DoctorId = doctorId,
//                 DateTime = dateTime
//             };

//             _appointments.Add(appointment);
//             Console.WriteLine("Appointment booked.");
//         }

//         public List<Appointment> GetDailySchedule(DateTime date)
//         {
//             return _appointments
//                 .Where(a => a.DateTime.Date == date.Date)
//                 .OrderBy(a => a.DateTime)
//                 .ToList();
//         }
//     }
// }

using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class AppointmentService
{
private readonly List<Appointment> _appointments = new();

    public void BookAppointment(int patientId, int doctorId, DateTime dateTime)
    {
        bool alreadyBooked = _appointments.Any(a =>
            a.DoctorId == doctorId && a.DateTime == dateTime && a.Status == "SCHEDULED");

        if (alreadyBooked)
        {
            Console.WriteLine("Slot not available.");
            return;
        }

        var appointment = new Appointment
        {
            AppointmentId = IdGenerator.NextAppointmentId(),
            PatientId = patientId,
            DoctorId = doctorId,
            DateTime = dateTime
        };

        _appointments.Add(appointment);
        Console.WriteLine("Appointment booked successfully.");
    }

    public void ShowAppointments()
    {
        if (_appointments.Count == 0)
        {
            Console.WriteLine("No appointments scheduled.");
            return;
        }

        foreach (var a in _appointments.OrderBy(a => a.DateTime))
        {
            Console.WriteLine($"ApptID:{a.AppointmentId} Patient:{a.PatientId} Doctor:{a.DoctorId} Time:{a.DateTime}");
        }
    }
}

}
