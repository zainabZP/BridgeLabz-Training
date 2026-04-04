using System;
interface IPayable{
    double CalculateBill();
}
class Patient{
    private int patientId;
    private string name;
    public void SetPatientId(int id){
        patientId = id;
    }
    public int GetPatientId(){
        return patientId;
    }
    public void SetName(string n){
        name = n;
    }
    public string GetName(){
        return name;
    }
    public void DisplayInfo(){
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
    }
}
class InPatient : Patient, IPayable{
    private int days;
    private double charge;
    public void SetDays(int d){
        days = d;
    }
    public void SetCharge(double c){
        charge = c;
    }
    public double CalculateBill(){
        return days * charge;
    }
    public void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Patient Type: InPatient");
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}
class OutPatient : Patient, IPayable{
    private double fee;
    public void SetFee(double f){
        fee = f;
    }
    public double CalculateBill(){
        return fee;
    }
    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: OutPatient");
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}
class Doctor{
    private int doctorId;
    private string doctorName;
    private string specialization;
    public void SetDoctorId(int id){
        doctorId = id;
    }
    public void SetDoctorName(string name){
        doctorName = name;
    }
    public void SetSpecialization(string spec){
        specialization = spec;
    }
    public void DisplayDoctor()
    {
        Console.WriteLine("Doctor ID: " + doctorId);
        Console.WriteLine("Doctor Name: " + doctorName);
        Console.WriteLine("Specialization: " + specialization);
    }
}

class Program
{
    static void Main(){
        InPatient ip = new InPatient();
        ip.SetPatientId(101);
        ip.SetName("zaina3");
        ip.SetDays(4);
        ip.SetCharge(1000);

        OutPatient op = new OutPatient();
        op.SetPatientId(102);
        op.SetName("Apurva");
        op.SetFee(500);

        Console.WriteLine("InPatient : ");
        ip.DisplayInfo();
        Console.WriteLine("OutPatient : ");
        op.DisplayInfo();

        Doctor d = new Doctor();
        d.SetDoctorId(1);
        d.SetDoctorName("Dr. Mahi");
        d.SetSpecialization("Cardiologist");

        Console.WriteLine("Doctor : ");
        d.DisplayDoctor();
    }
}
