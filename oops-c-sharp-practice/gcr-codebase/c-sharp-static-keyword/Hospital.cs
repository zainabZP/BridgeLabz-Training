using System;

class PatientInfo
{
    // static hospital name
    public static string hospitalTitle = "City Hospital";
    private static int totalPatients = 0;

    // readonly patient ID
    public readonly int patientID;
    public string patientName;
    public int patientAge;
    public string ailment;

    // constructor using 'this' keyword
    public PatientInfo(int patientID, string patientName, int patientAge, string ailment)
    {
        this.patientID = patientID;
        this.patientName = patientName;
        this.patientAge = patientAge;
        this.ailment = ailment;
        totalPatients++;
    }

    // static method to display total patients
    public static void showTotalPatients()
    {
        Console.WriteLine("Total Patients : " + totalPatients);
    }

    static void Main(string[] args)
    {
        // creating patient object
        PatientInfo patient1 = new PatientInfo(1, "Ana", 21, "Fever");

        // using 'is' operator for type checking
        if (patient1 is PatientInfo)
        {
            Console.WriteLine("Name     : " + patient1.patientName);
            Console.WriteLine("Age      : " + patient1.patientAge);
            Console.WriteLine("Ailment  : " + patient1.ailment);
            Console.WriteLine("Hospital : " + hospitalTitle);
        }

        // displaying total patients
        PatientInfo.showTotalPatients();
    }
}
