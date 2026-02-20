using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services
{
public class DoctorService
{
private readonly List<Doctor> _doctors;

    public DoctorService()
    {
        _doctors = FileStorage.LoadDoctors();
    }

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
        FileStorage.SaveDoctors(_doctors);

        Console.WriteLine("Doctor saved to file.");
    }

    public void ShowAllDoctors()
    {
        foreach (var d in _doctors)
            Console.WriteLine($"{d.DoctorId} | {d.Name} | {d.Specialty}");
    }
}

}
