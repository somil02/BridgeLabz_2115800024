//using System;

//class Vehicle
//{
//    public static double RegistrationFee = 500.00;
//    public readonly string RegistrationNumber;
//    public string OwnerName { get; private set; }
//    public string VehicleType { get; private set; }
//    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
//    {
//        this.RegistrationNumber = registrationNumber;
//        this.OwnerName = ownerName;
//        this.VehicleType = vehicleType;
//    }
//    public static void UpdateRegistrationFee(double newFee)
//    {
//        if (newFee > 0)
//        {
//            RegistrationFee = newFee;
//            Console.WriteLine("Updated Registration Fee: " + RegistrationFee.ToString("C"));
//        }
//        else
//        {
//            Console.WriteLine("Registration fee must be a positive value.");
//        }
//    }
//    public void DisplayRegistrationDetails()
//    {
//        if (this is Vehicle)
//        {
//            Console.WriteLine("Vehicle Registration Details:");
//            Console.WriteLine("Registration Number: " + RegistrationNumber);
//            Console.WriteLine("Owner Name: " + OwnerName);
//            Console.WriteLine("Vehicle Type: " + VehicleType);
//            Console.WriteLine("Registration Fee: " + RegistrationFee.ToString("C"));
//        }
//        else
//        {
//            Console.WriteLine("The provided object is not a valid Vehicle instance.");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Vehicle vehicle1 = new Vehicle("ABC123", "Alice Johnson", "Car");
//        Vehicle vehicle2 = new Vehicle("XYZ456", "Bob Smith", "Motorcycle");

//        vehicle1.DisplayRegistrationDetails(vehicle1);
//        Console.WriteLine();
//        vehicle2.DisplayRegistrationDetails(vehicle2);
//        Vehicle.UpdateRegistrationFee(600.00);
//        Console.WriteLine();
//        vehicle1.DisplayRegistrationDetails(vehicle1);
//    }
//}
