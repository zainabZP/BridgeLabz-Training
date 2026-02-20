using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class PatientService
{
private readonly List<Patient> _patients;

    public PatientService()
    {
        _patients = FileStorage.LoadPatients();
    }

    public void RegisterPatient(string name, DateTime dob, string phone,
                                string address, string bloodGroup)
    {
        if (!Validator.IsValidPhone(phone))
        {
            Console.WriteLine("Invalid phone number.");
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
        FileStorage.SavePatients(_patients);

        Console.WriteLine("Patient saved to file.");
    }

    public void ShowAllPatients()
    {
        foreach (var p in _patients)
            Console.WriteLine($"{p.PatientId} | {p.Name} | {p.Phone}");
    }
}

}
