
using System;

interface IManage
{
    void AddPatient();
    void RemovePatient();
    int CalculateBill(Patient p);
}

class Manager : IManage
{
    private static Patient[] patient = new Patient[10];
    private static Patient[] arrOut = new Patient[10];
    static int idx = 0;
    static int iout = 0;

    public Patient[] GetOutpatient()
    {
        return arrOut;
    }

    public void AddPatient()
    {
        if (idx >= patient.Length)
        {
            Console.WriteLine("No space available");
            return;
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter In Date (day only): ");
        string inDate = Console.ReadLine();

        patient[idx++] = new Patient(name, inDate);
        Console.WriteLine("Patient Added");
    }

    public void RemovePatient()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < patient.Length; i++)
        {
            if (patient[i] != null && patient[i].name == name)
            {
                Console.Write("Enter Out Date (day only): ");
                patient[i].outDate = Console.ReadLine();

                patient[i].Bill = CalculateBill(patient[i]);

                arrOut[iout++] = patient[i];
                patient[i] = null;

                Console.WriteLine("Patient Exited");
                return;
            }
        }

        Console.WriteLine("Patient not found");
    }

    public int CalculateBill(Patient p)
    {
        int inDay = int.Parse(p.inDate);
        int outDay = int.Parse(p.outDate);
        return (outDay - inDay) * 500;
    }

    public static void Divide(int s, int e, Patient[] arr)
    {
        if (s < e)
        {
            int mid = (s + e) / 2;
            Divide(s, mid, arr);
            Divide(mid + 1, e, arr);
            Conq(s, mid, e, arr);
        }
    }

    public static void Conq(int s, int m, int e, Patient[] arr)
    {
        Patient[] temp = new Patient[e - s + 1];
        int i = s, j = m + 1, k = 0;

        while (i <= m && j <= e)
        {
            if (arr[i].Bill < arr[j].Bill)
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= m)
            temp[k++] = arr[i++];

        while (j <= e)
            temp[k++] = arr[j++];

        for (int p = 0; p < temp.Length; p++)
            arr[s + p] = temp[p];
    }

    public static void DisplayPatient()
    {
        for (int i = 0; i < patient.Length; i++)
        {
            if (patient[i] != null)
                Console.WriteLine(patient[i].name + " | In: " + patient[i].inDate);
        }
    }
}

class Patient
{
    public string name;
    public string inDate;
    public string outDate;
    public int Bill;

    public Patient(string name, string inDate)
    {
        this.name = name;
        this.inDate = inDate;
    }
}

class Program
{
    public static void Main()
    {
        Manager obj = new Manager();

        obj.AddPatient();
        obj.AddPatient();

        Manager.DisplayPatient();

        obj.RemovePatient();
        obj.RemovePatient();

        Patient[] outArr = obj.GetOutpatient();

        Manager.Divide(0, 1, outArr);

        Console.WriteLine("\nSorted Out Patients:");
        for (int i = 0; i < outArr.Length; i++)
        {
            if (outArr[i] != null)
                Console.WriteLine(outArr[i].name + " | Bill: " + outArr[i].Bill);
        }
    }
}
