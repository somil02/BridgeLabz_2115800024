using System;

class Vehicle
{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 10000.00; 

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public string VehicleType
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }

    public Vehicle() { }

    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: "+ownerName);
        Console.WriteLine("Vehicle Type: "+vehicleType);
        Console.WriteLine("Registration Fee: "+registrationFee);
        Console.WriteLine();
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
        Console.WriteLine("Registration Fee has been updated to: "+registrationFee);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle("Ramesh", "Sedan");
        Vehicle vehicle2 = new Vehicle("Suresh", "SUV");

        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(15000.00);

        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
