// using HealthClinicApp.Services;

// class Program
// {
//     static void Main()
//     {
//         var patientService = new PatientService();
//         var doctorService = new DoctorService();
//         var appointmentService = new AppointmentService();
//         var billingService = new BillingService();

//         // Sample Flow (Simulating Receptionist + Doctor)

//         patientService.RegisterPatient("Ayesha Khan",
//             new DateTime(1999, 5, 10), "9876543210", "Delhi", "B+");

//         doctorService.AddDoctor("Dr. Sharma", "Cardiology", 500);

//         appointmentService.BookAppointment(1, 1, DateTime.Now.AddHours(2));

//         var total = billingService.GenerateBill(500, 200);

//         Console.WriteLine("System Running Successfully...");
//     }
// }



using HealthClinicApp.Services;

class Program
{
static void Main()
{
var patientService = new PatientService();
var doctorService = new DoctorService();
var appointmentService = new AppointmentService();
var billingService = new BillingService();

    while (true)
    {
        Console.WriteLine("\n==== HEALTH CLINIC MENU ====");
        Console.WriteLine("1. Register Patient");
        Console.WriteLine("2. View Patients");
        Console.WriteLine("3. Add Doctor");
        Console.WriteLine("4. View Doctors");
        Console.WriteLine("5. Book Appointment");
        Console.WriteLine("6. View Appointments");
        Console.WriteLine("7. Generate Bill");
        Console.WriteLine("0. Exit");
        Console.Write("Select Option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("DOB (yyyy-mm-dd): ");
                DateTime dob = DateTime.Parse(Console.ReadLine());

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Blood Group: ");
                string bg = Console.ReadLine();

                patientService.RegisterPatient(name, dob, phone, address, bg);
                break;

            case "2":
                patientService.ShowAllPatients();
                break;

            case "3":
                Console.Write("Doctor Name: ");
                string dname = Console.ReadLine();

                Console.Write("Specialty: ");
                string spec = Console.ReadLine();

                Console.Write("Consultation Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                doctorService.AddDoctor(dname, spec, fee);
                break;

            case "4":
                doctorService.ShowAllDoctors();
                break;

            case "5":
                Console.Write("Patient ID: ");
                int pid = int.Parse(Console.ReadLine());

                Console.Write("Doctor ID: ");
                int did = int.Parse(Console.ReadLine());

                Console.Write("Date & Time (yyyy-mm-dd HH:mm): ");
                DateTime dt = DateTime.Parse(Console.ReadLine());

                appointmentService.BookAppointment(pid, did, dt);
                break;

            case "6":
                appointmentService.ShowAppointments();
                break;

            case "7":
                Console.Write("Consultation Fee: ");
                decimal cfee = decimal.Parse(Console.ReadLine());

                Console.Write("Extra Charges: ");
                decimal extra = decimal.Parse(Console.ReadLine());

                billingService.GenerateBill(cfee, extra);
                break;

            case "0":
                return;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

}
