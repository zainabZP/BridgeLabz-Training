// using HealthClinicApp.Models;
// using HealthClinicApp.Utilities;

// namespace HealthClinicApp.Services
// {
//     public class DoctorService
//     {
//         private readonly List<Doctor> _doctors = new();

//         public void AddDoctor(string name, string specialty, decimal fee)
//         {
//             var doctor = new Doctor
//             {
//                 DoctorId = IdGenerator.NextDoctorId(),
//                 Name = name,
//                 Specialty = specialty,
//                 ConsultationFee = fee
//             };

//             _doctors.Add(doctor);
//             Console.WriteLine("Doctor added successfully.");
//         }

//         public List<Doctor> GetBySpecialty(string specialty)
//         {
//             return _doctors.Where(d => d.Specialty == specialty && d.IsActive).ToList();
//         }

//         public Doctor? GetDoctor(int id)
//         {
//             return _doctors.FirstOrDefault(d => d.DoctorId == id);
//         }
//     }
// }



using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class DoctorService
{
private readonly List<Doctor> _doctors = new();

    public void AddDoctor(string name, string specialty, decimal fee)
    {
        var doctor = new Doctor
        {
            DoctorId = IdGenerator.NextDoctorId(),
            Name = name,
            Specialty = specialty,
            ConsultationFee = fee
        };

        _doctors.Add(doctor);
        Console.WriteLine("Doctor added successfully.");
    }

    public void ShowAllDoctors()
    {
        if (_doctors.Count == 0)
        {
            Console.WriteLine("No doctors available.");
            return;
        }

        foreach (var d in _doctors)
        {
            Console.WriteLine($"{d.DoctorId} | {d.Name} | {d.Specialty} | Fee: {d.ConsultationFee}");
        }
    }

    public Doctor? GetDoctor(int id)
    {
        return _doctors.FirstOrDefault(d => d.DoctorId == id);
    }
}

}
