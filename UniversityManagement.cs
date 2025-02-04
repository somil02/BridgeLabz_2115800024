//using System;

//public class Student
//{
//    public static string UniversityName = "GLA University";
//    private static int TotalStudents = 0;
//    public readonly int RollNumber;
//    public string Name;
//    public char Grade;

//    public static void DisplayTotalStudents()
//    {
//        Console.WriteLine("Total Students: " + TotalStudents);
//    }
//    public Student(int rollNumber, string name, char grade)
//    {
//        this.RollNumber = rollNumber;
//        this.Name = name;
//        this.Grade = grade;
//        TotalStudents++;
//    }
//    public void UpdateGrade(char newGrade)
//    {
//        if (this is Student)
//        {
//            if (newGrade >= 'A' && newGrade <= 'F')
//            {
//                this.Grade = newGrade;
//                Console.WriteLine("Updated Grade for " + Name + " (Roll Number: " + RollNumber + ") to: " + Grade);
//            }
//            else
//            {
//                Console.WriteLine("Invalid grade. Please enter a grade between A and F.");
//            }
//        }
//    }
//    public void DisplayStudentDetails()
//    {
//        if (this is Student)
//        {
//            Console.WriteLine("Student Name: " + Name);
//            Console.WriteLine("RollNumber: " + RollNumber);
//            Console.WriteLine("Grade: " + Grade);
//            Console.WriteLine("University Name: " + UniversityName);
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
//        Student student1 = new Student(101, "John Doe", 'A');
//        Student student2 = new Student(102, "Jane Doe", 'B');
//        student1.DisplayStudentDetails();
//        Console.WriteLine();
//        student2.DisplayStudentDetails();
//        student1.UpdateGrade('B');
//        student2.UpdateGrade('C');
//        Console.WriteLine();
//        student1.DisplayStudentDetails();
//        student2.DisplayStudentDetails();
//        Student.DisplayTotalStudents();
//    }
//}
