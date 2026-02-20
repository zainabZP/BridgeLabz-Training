using HealthClinicApp.Services;
using HealthClinicApp.Data;

var patientService = new PatientService();
var doctorService = new DoctorService();
var appointmentService = new AppointmentService();

var connectionString = "Server=WASEEM\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";
var visitService = new VisitService();
var prescriptionService = new PrescriptionService();
var billingService = new BillingService(connectionString);
var reportService = new ReportService(connectionString);

while (true)
{
    Console.WriteLine("\n========== HEALTH CLINIC SYSTEM ==========");
    Console.WriteLine("1. Register Patient");
    Console.WriteLine("2. View All Patients");
    Console.WriteLine("3. Search Patient");

    Console.WriteLine("4. Add Doctor");
    Console.WriteLine("5. View Active Doctors");
    Console.WriteLine("6. Deactivate Doctor");

    Console.WriteLine("7. Book Appointment");
    Console.WriteLine("8. View Appointment Schedule");

    Console.WriteLine("9. Record Visit");
    Console.WriteLine("10. Add Prescription");

    Console.WriteLine("11. Generate Bill");
    Console.WriteLine("12. Record Payment");

    Console.WriteLine("13. Revenue Report");

    Console.WriteLine("0. Exit");
    Console.Write("Select Option: ");

    string choice = Console.ReadLine() ?? "";

    try
    {
        switch (choice)
        {
            // ================= PATIENT =================
            case "1":
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("DOB (yyyy-mm-dd): ");
                DateTime.TryParse(Console.ReadLine(), out DateTime dob);

                Console.Write("Phone: ");
                string phone = Console.ReadLine() ?? "";

                Console.Write("Address: ");
                string address = Console.ReadLine() ?? "";

                Console.Write("Blood Group: ");
                string bg = Console.ReadLine() ?? "";

                patientService.RegisterPatient(name, dob, phone, address, bg);
                break;

            case "2":
                patientService.ShowAllPatients();
                break;

            case "3":
                Console.Write("Enter Name or Phone: ");
                patientService.Search(Console.ReadLine() ?? "");
                break;

            // ================= DOCTOR =================
            case "4":
                Console.Write("Doctor Name: ");
                string dname = Console.ReadLine() ?? "";

                int.TryParse(Console.ReadLine(), out int specId);
                decimal.TryParse(Console.ReadLine(), out decimal fee);

                doctorService.AddDoctor(dname, specId, fee);
                break;

            case "5":
                doctorService.ShowAllDoctors();
                break;

            case "6":
                int.TryParse(Console.ReadLine(), out int docId);
                doctorService.DeactivateDoctor(docId);
                break;

            // ================= APPOINTMENT =================
            case "7":
                int.TryParse(Console.ReadLine(), out int pid);
                int.TryParse(Console.ReadLine(), out int did);
                DateTime.TryParse(Console.ReadLine(), out DateTime dt);

                appointmentService.BookAppointment(pid, did, dt);
                break;

            case "8":
                appointmentService.ViewSchedule();
                break;

            // ================= VISIT =================
            case "9":
                int.TryParse(Console.ReadLine(), out int apptId);
                string diag = Console.ReadLine() ?? "";
                string notes = Console.ReadLine() ?? "";

                int visitId = visitService.RecordVisit(apptId, diag, notes);
                Console.WriteLine($"Visit Recorded. VisitId = {visitId}");
                break;

            // ================= PRESCRIPTION =================
            case "10":
                int.TryParse(Console.ReadLine(), out int vId);
                string med = Console.ReadLine() ?? "";
                string dose = Console.ReadLine() ?? "";
                string dur = Console.ReadLine() ?? "";

                prescriptionService.AddPrescription(vId, med, dose, dur);
                Console.WriteLine("Prescription Added.");
                break;

            // ================= BILLING =================
            case "11":
                int.TryParse(Console.ReadLine(), out int visitForBill);
                decimal.TryParse(Console.ReadLine(), out decimal amount);

                int billId = billingService.GenerateBill(visitForBill, amount);
                Console.WriteLine($"Bill Generated. BillId = {billId}");
                break;

            case "12":
                int.TryParse(Console.ReadLine(), out int payBillId);
                string mode = Console.ReadLine() ?? "";

                billingService.RecordPayment(payBillId, mode);
                Console.WriteLine("Payment Recorded.");
                break;

            // ================= REPORT =================
            case "13":
                DateTime.TryParse(Console.ReadLine(), out DateTime from);
                DateTime.TryParse(Console.ReadLine(), out DateTime to);

                reportService.RevenueReport(from, to);
                break;

            case "0":
                return;

            default:
                Console.WriteLine("Invalid Option.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}