using System;
using System.Collections.Generic;

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }
}

interface IEnrollable
{
    void Enroll(Course course);
}

class User : IEnrollable
{
    private List<Course> enrolledCourses = new List<Course>();
    private double totalFee = 0;

    public void Enroll(Course course)
    {
        enrolledCourses.Add(course);
        totalFee += course.Fee;
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = 0;
        if (couponCode == "SAVE10")
        {
            discount = 0.1;
        }

        enrolledCourses.Add(course);
        totalFee += course.Fee * (1 - discount);
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine("Enrolled Courses:");
        foreach (Course course in enrolledCourses)
        {
            Console.WriteLine(course.Title);
        }
        Console.WriteLine("Total Amount Paid: " + totalFee);
    }
}

class Program
{
    static void Main()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Title = "C# Fundamentals";
        course1.Fee = 300;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Title = "OOP in C#";
        course2.Fee = 400;

        User user = new User();

        user.Enroll(course1);
        user.Enroll(course2, "SAVE10");

        user.PrintEnrolledCourses();
    }
}