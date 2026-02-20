// using HealthClinicApp.Models;
// using HealthClinicApp.Utilities;

// namespace HealthClinicApp.Services
// {
//     public class PatientService
//     {
//         private readonly List<Patient> _patients = new();

//         public void RegisterPatient(string name, DateTime dob, string phone,
//                                     string address, string bloodGroup)
//         {
//             if (!Validator.IsValidPhone(phone))
//             {
//                 Console.WriteLine("Invalid phone number.");
//                 return;
//             }

//             if (_patients.Any(p => p.Phone == phone))
//             {
//                 Console.WriteLine("Patient already exists.");
//                 return;
//             }

//             var patient = new Patient
//             {
//                 PatientId = IdGenerator.NextPatientId(),
//                 Name = name,
//                 DOB = dob,
//                 Phone = phone,
//                 Address = address,
//                 BloodGroup = bloodGroup
//             };

//             _patients.Add(patient);
//             Console.WriteLine($"Patient Registered. ID: {patient.PatientId}");
//         }

//         public Patient? GetPatient(int id)
//         {
//             return _patients.FirstOrDefault(p => p.PatientId == id);
//         }

//         public List<Patient> Search(string name)
//         {
//             return _patients
//                 .Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
//                 .ToList();
//         }
//     }
// }



using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class PatientService
{
private readonly List<Patient> _patients = new();

    public void RegisterPatient(string name, DateTime dob, string phone,
                                string address, string bloodGroup)
    {
        if (!Validator.IsValidPhone(phone))
        {
            Console.WriteLine("Invalid phone number.");
            return;
        }

        if (_patients.Any(p => p.Phone == phone))
        {
            Console.WriteLine("Patient already exists.");
            return;
        }

        var patient = new Patient
        {
            PatientId = IdGenerator.NextPatientId(),
            Name = name,
            DOB = dob,
            Phone = phone,
            Address = address,
            BloodGroup = bloodGroup
        };

        _patients.Add(patient);
        Console.WriteLine($"Patient Registered. ID: {patient.PatientId}");
    }

    public void ShowAllPatients()
    {
        if (_patients.Count == 0)
        {
            Console.WriteLine("No patients found.");
            return;
        }

        foreach (var p in _patients)
        {
            Console.WriteLine($"{p.PatientId} | {p.Name} | {p.Phone} | {p.BloodGroup}");
        }
    }

    public Patient? GetPatient(int id)
    {
        return _patients.FirstOrDefault(p => p.PatientId == id);
    }
}

}
