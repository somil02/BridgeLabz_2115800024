using System;

class Employee
{
    public int employeeID;
    protected string department;
    private double salary;
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        SetSalary(salary);  // Using setter to set the initial salary
    }
    public double GetSalary()
    {
        return salary;
    }
    public void SetSalary(double salary)
    {
        if (salary >= 0)
        {
            this.salary = salary;
        }
        else
        {
            Console.WriteLine("Invalid salary amount. Salary cannot be negative.");
        }
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: $" + GetSalary());
    }
}
class Manager : Employee
{
    private string project;
    public Manager(int employeeID, string department, double salary, string project)
        : base(employeeID, department, salary)
    {
        this.project = project;
    }

    public void DisplayManagerDetails()
    {
        DisplayEmployeeDetails(); 
        Console.WriteLine("Project: " + project);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(101, "HR", 50000);
        employee1.DisplayEmployeeDetails(); 
        employee1.SetSalary(55000);
        Console.WriteLine("\nUpdated Employee Details after salary change:");
        employee1.DisplayEmployeeDetails(); 
        Manager manager1 = new Manager(201, "IT", 80000, "Software Development");
        manager1.DisplayManagerDetails();
    }
}
