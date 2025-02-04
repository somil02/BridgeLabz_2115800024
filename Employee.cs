//using System;

//public class Employee
//{
//	public static string CompanyName = "Capgemini";
//    private static int TotalEmployees = 0;
//    public readonly int Id;
//    public string Name { get; private set; }
//    public string Designation { get; private set; }
//    public static void DisplayTotalEmployees()
//    {
//        Console.WriteLine("Total Employees: " + TotalEmployees);
//    }
//    public Employee(int id, string name, string designation)
//    {
//        this.Id = id;
//        this.Name = name;
//        this.Designation = designation;
//        TotalEmployees++;
//    }
//    public void DisplayEmployeeDetails()
//    {
//        if (this is Employee)
//        {
//            Console.WriteLine("Company Name: " + CompanyName);
//            Console.WriteLine("Employee ID: " + Id);
//            Console.WriteLine("Employee Name: " + Name);
//            Console.WriteLine("Designation: " + Designation);
//        }
//        else
//        {
//            Console.WriteLine("This is not a valid Employee object.");
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee emp1 = new Employee(101, "John Doe", "Software Developer");
//        Employee emp2 = new Employee(102, "Jane Doe", "HR Manager");
//        emp1.DisplayEmployeeDetails();
//        Console.WriteLine(); // To separate the output visually
//        emp2.DisplayEmployeeDetails();
//        Employee.DisplayTotalEmployees();
//    }
//}
