using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Patient
{
    static string HospitalName = "XYZ HOSPITAL";

    string Name;

    int Age;

    string Ailment;

    readonly string PatientID;

    static int totalPatients = 0;

    public Patient(string Name, int Age, string Ailment, string PatientID)
    {

        this.Name = Name;

        this.Age = Age;

        this.Ailment = Ailment;

        this.PatientID = PatientID;

        totalPatients++;
    }

    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    public static void Main(string[] args)
    {
        TakeInputs();
    }

    public static void TakeInputs()
    {

        Console.WriteLine("ENTER PATIENT NAME");

        string Name = Console.ReadLine();

        Console.WriteLine("ENTER PATIENT AGE");

        int Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENTER PATIENT AILMENT");

        string Ailment = Console.ReadLine();

        Console.WriteLine("ENTER PATIENT ID");

        string PatientID = Console.ReadLine();


        Patient patient = new Patient(Name, Age, Ailment, PatientID);

        if (patient is Patient)
        {

            patient.DisplayDetails();

            Console.WriteLine("Total Patients: " + GetTotalPatients());

        }
    }
    public void DisplayDetails()
    {

        Console.WriteLine("\n--- PATIENT DETAILS ---");

        Console.WriteLine("Hospital Name: " + HospitalName);

        Console.WriteLine("PATIENT NAME: " + Name);

        Console.WriteLine("PATIENT AGE: " + Age);

        Console.WriteLine("PATIENT AILMENT: " + Ailment);

        Console.WriteLine("Patient ID:" + PatientID);
    }
}
