using System;

class Course
{
    private string courseName;
    private int duration;
    private double fee;

    private static string instituteName = "GLA University";

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public double Fee
    {
        get { return fee; }
        set { fee = value; }
    }

    public Course() { }

    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute Name: "+instituteName);
        Console.WriteLine($"Course Name: "+courseName);
        Console.WriteLine($"Duration: "+duration+ " months");
        Console.WriteLine($"Fee: "+fee);
        Console.WriteLine();
    }

    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course("Data Science", 12, 1500.00);
        Course course2 = new Course("Web Development", 10, 1200.00);

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        Course.UpdateInstituteName("Amity University");

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
