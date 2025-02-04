// using System;
// class Student
// {
	// public int rollNumber;
	// protected string name;
	// private double CGPA;
	// public double GetCGPA()
	// {
		// return CGPA;
	// }
	// public void SetCGPA(double cgpa)
	// {
		// CGPA=cgpa;
	// }
	// public Student(int rollNumber, string name, double CGPA)
	// {
		// this.rollNumber = rollNumber;
        // this.name = name;
		// SetCGPA(CGPA); // Using the setter to ensure CGPA validation	
	// }
	 // public void DisplayDetails()
    // {
        // Console.WriteLine("Roll Number: "+rollNumber);
        // Console.WriteLine("Name: "+name);
        // Console.WriteLine("CGPA: "+CGPA);
    // }
// }
// class PostgraduateStudent:Student
// {
	// private string specialization;
	// public PostgraduateStudent(int rollNumber, string name, double CGPA, string specialization): base(rollNumber, name, CGPA)
	// {
		// this.specialization = specialization;
	// }
	 // public void DisplayPostgraduateDetails()
    // {
        // DisplayDetails();
        // Console.WriteLine("Specialization Name: "+specialization);
    // }
// }
// class Program
// {
	// static void Main(string[] args)
	// {
		 // Student student1 = new Student(1, "Abhay", 9.1);
		 // student1.DisplayDetails();
		 // student1.SetCGPA(8.2);
		 // student1.DisplayDetails();
		 // PostgraduateStudent pgStudent = new PostgraduateStudent(2, "Bob", 8.7, "Advanced Machine Learning");
		 // pgStudent.DisplayPostgraduateDetails();
		 // pgStudent.SetCGPA(8.9);
		 // pgStudent.DisplayPostgraduateDetails();
	// }
// }
