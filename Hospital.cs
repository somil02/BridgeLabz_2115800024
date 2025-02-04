//using System;

//class Patient
//{
//    public static string HospitalName = "City Care Hospital";
//    private static int TotalPatients = 0;
//    public readonly int PatientID;
//    public string Name { get; private set; }
//    public int Age { get; private set; }
//    public string Ailment;
//    public Patient(int patientID, string name, int age, string ailment)
//    {
//        this.PatientID = patientID;
//        this.Name = name;
//        this.Age = age;
//        this.Ailment = ailment;
//        TotalPatients++;
//    }
//    public static void GetTotalPatients()
//    {
//        Console.WriteLine("Total Patients Admitted: " + TotalPatients);
//    }
//    public void DisplayPatientDetails(object obj)
//    {
//        if (obj is Patient)
//        {
//            Console.WriteLine("Patient Details:");
//            Console.WriteLine("Patient ID: " + PatientID);
//            Console.WriteLine("Name: " + Name);
//            Console.WriteLine("Age: " + Age);
//            Console.WriteLine("Ailment: " + Ailment);
//            Console.WriteLine("Hospital Name: " + HospitalName);
//        }
//        else
//        {
//            Console.WriteLine("The provided object is not a valid Patient instance.");
//        }
//    }
//}
//class Program { 
//    public static void Main(string[] args)
//    {
//        Patient patient1 = new Patient(101, "Alice Johnson", 30, "Fever");
//        Patient patient2 = new Patient(102, "Bob Smith", 45, "Diabetes");
//        patient1.DisplayPatientDetails(patient1);
//        Console.WriteLine();
//        patient2.DisplayPatientDetails(patient2);
//        Console.WriteLine();
//        Patient.GetTotalPatients();
//    }
//}
