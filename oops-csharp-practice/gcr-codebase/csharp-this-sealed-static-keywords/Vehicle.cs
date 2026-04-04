using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
internal class Vehicle
{
    // static
    static int RegistrationFee = 1000;

    // instance variables
    string OwnerName;
    string VehicleType;

    // readonly
    readonly int RegistrationNumber;

    // constructor using this
    public Vehicle(string OwnerName, string VehicleType, int RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    // static method to update fee
    public static void UpdateRegistrationFee(int fee)
    {
        RegistrationFee = fee;
    }

    public static void Main(string[] args)
    {
        TakeInputs();
    }

    public static void TakeInputs()
    {
        Console.Write("Enter Registration Fee: ");
        int fee = Convert.ToInt32(Console.ReadLine());
        UpdateRegistrationFee(fee);

        Console.Write("Enter Owner Name: ");
        string? owner = Console.ReadLine();
        if (owner == null)
        {
            throw new InvalidOperationException("Owner Name cannot be null.");
        }

        Console.Write("Enter Vehicle Type: ");
        string type = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new InvalidOperationException("Vehicle Type cannot be null.");
        }

        Console.Write("Enter Registration Number: ");
        int regNo = Convert.ToInt32(Console.ReadLine());

        Vehicle v = new Vehicle(owner, type, regNo);

        if (v is Vehicle)
        {
            v.DisplayDetails();
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n--- VEHICLE DETAILS ---");
        Console.WriteLine("Owner Name        : " + OwnerName);
        Console.WriteLine("Vehicle Type      : " + VehicleType);
        Console.WriteLine("Registration No   : " + RegistrationNumber);
        Console.WriteLine("Registration Fee  : " + RegistrationFee);
    }
}
